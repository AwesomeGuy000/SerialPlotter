using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using System.Windows.Forms.DataVisualization.Charting;
using System.Text.RegularExpressions;

public struct Vec
{
    public float x;
    public float y;
}



namespace SerialPlotter
{

    public partial class Form1 : Form
    {

        private static readonly Regex dataPatternPID = new Regex(@"^<(\d+\.?\d*,\d+\.?\d*,\d+\.?\d*,\d+\.?\d*)>$");
        private static readonly Regex dataPatternTarg = new Regex(@"^<(-?\d+(?:\.\d+)?),(-?\d+(?:\.\d+)?),(-?\d+(?:\.\d+)?),(-?\d+(?:\.\d+)?),(-?\d+(?:\.\d+)?),(-?\d+(?:\.\d+)?),(-?\d+(?:\.\d+)?)>$");
        private int xVal;
        private int yVal;
        private int leftDir = 1;
        private int rightDir = 1;
        private int leftEn = 1;
        private int rightEn = 1;

        public string readData = "";
        public List<int> currLVel;
        public List<int> currRVel;
        public List<int> targLVel;
        public List<int> targRVel;
        private int latestCurrLVel = 0;
        private int latestCurrRVel = 0;
        private int latestTargLVel = 0;
        private int latestTargRVel = 0;
        public static int maxSeriesLength = 250;

        private Vec currPos = new Vec();
        private float currHead = 0;
        private Vec targPos = new Vec();
        private Vec targSpeed = new Vec();

        private bool robotMode = false; //false = pid, true = targeting

        private int xTarget = 0;
        private int yTarget = 0;



        private void parseAndAppend(string data)
        {
            // Use Regex to check the format
            if (dataPatternPID.IsMatch(data))
            {
                robotMode = false;
                driveControls.Enabled = true;
                targetControls.Enabled = false;
                // Remove the start and end markers
                data = data.Substring(1, data.Length - 2);

                // Split the string by commas
                string[] values = data.Split(',');

                // Check if we have enough values
                if (values.Length != 4)
                {
                    // Handle invalid data (e.g., log an error or display a message)
                    return;
                }

                // Parse the values as integers (handling potential decimals)
                latestCurrLVel = Convert.ToInt32(double.Parse(values[0]));
                latestCurrRVel = Convert.ToInt32(double.Parse(values[1]));
                latestTargLVel = Convert.ToInt32(double.Parse(values[2]));
                latestTargRVel = Convert.ToInt32(double.Parse(values[3]));
                
                // Check if the lists are full and remove the first element if needed
                if (currLVel.Count >= maxSeriesLength)
                {
                    currLVel.RemoveAt(0);
                }
                if (currRVel.Count >= maxSeriesLength)
                {
                    currRVel.RemoveAt(0);
                }
                if (targLVel.Count >= maxSeriesLength)
                {
                    targLVel.RemoveAt(0);
                }
                if (targRVel.Count >= maxSeriesLength)
                {
                    targRVel.RemoveAt(0);
                }

                // Append to the lists
                currLVel.Add(latestCurrLVel);
                currRVel.Add(latestCurrRVel);
                targLVel.Add(latestTargLVel);
                targRVel.Add(latestTargRVel);
            }
            else if  (dataPatternTarg.IsMatch(data)) 
            {
                robotMode = true;
                driveControls.Enabled = false;
                targetControls.Enabled = true;
                Match match = dataPatternTarg.Match(data);
                currPos.x = float.Parse(match.Groups[1].Value);
                currPos.y = float.Parse(match.Groups[2].Value);
                currHead = float.Parse(match.Groups[3].Value);
                targPos.x = float.Parse(match.Groups[4].Value);
                targPos.y = float.Parse(match.Groups[5].Value);
                targSpeed.x = float.Parse(match.Groups[6].Value);
                targSpeed.y = float.Parse(match.Groups[7].Value);

                measuredX.Text = currPos.x.ToString();
                measuredY.Text = currPos.y.ToString();
                measuredHeading.Text = currHead.ToString();
                targetX.Text = targPos.x.ToString();
                targetY.Text = targPos.y.ToString();
                targVelLLabel.Text = targSpeed.x.ToString();
                targVelRLabel.Text = targSpeed.y.ToString();
            }
            else
            {
                // Handle invalid data (e.g., log an error or display a message)
                Console.WriteLine("Invalid data format.");
            }
        }

        private void updateVels()
        {
            leftMeasured.Text = latestCurrLVel.ToString();
            rightMeasured.Text = latestCurrRVel.ToString();
            leftTarget.Text = latestTargLVel.ToString();
            rightTarget.Text = latestTargRVel.ToString();
        }

        private void updateChart()
        {
            /*for (int i = 0; i < currLVel.Count; i++)
            {
                chart1.Series["Measured Left"].Points.AddXY(i, currLVel[i]); // Measured Left
                chart1.Series["Measured Right"].Points.AddXY(i, currRVel[i]); // Measured Right
                chart1.Series["Target Left"].Points.AddXY(i, targLVel[i]); // Target Left
                chart1.Series["Target Right"].Points.AddXY(i, targRVel[i]); // Target Right
            }*/

            //chart1.Invalidate();
            // Refresh the chart
            chart1.Series["Measured Left"].Points.AddY(latestCurrLVel);
            chart1.Series["Measured Right"].Points.AddY(latestCurrRVel);
            chart1.Series["Target Left"].Points.AddY(latestTargLVel);
            chart1.Series["Target Right"].Points.AddY(latestTargRVel);

            if (chart1.Series["Measured Left"].Points.Count() > maxSeriesLength)
            {
                clearGraphPoints();
            }
        }

        private void clearGraphPoints()
        {
            chart1.Series["Measured Left"].Points.Clear();
            chart1.Series["Measured Right"].Points.Clear();
            chart1.Series["Target Left"].Points.Clear();
            chart1.Series["Target Right"].Points.Clear();
        }

        public Form1()
        {
            InitializeComponent();
            getSerialPorts();
            currLVel = new List<int>();
            currRVel = new List<int>();
            targLVel = new List<int>();
            targRVel = new List<int>();
        }


        void getSerialPorts()
        {
            String[] availablePorts = SerialPort.GetPortNames();
            comboBoxPort.Items.AddRange(availablePorts);
        }

        void Form1_Load(object sender, EventArgs e)
        {

        }

        private void serialBegin_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboBoxPort.Text == "" || comboBoxBaud.Text == "")
                {
                    serialDataBox.Text = "Please select serial port settings.";
                }
                else
                {
                    serialPort1.PortName = comboBoxPort.Text;
                    serialPort1.BaudRate = Convert.ToInt32(comboBoxBaud.Text);
                    serialPort1.Open();
                    serialBeginButton.Enabled = false;
                    serialCloseButton.Enabled = true;
                    sendWriteButton.Enabled = true;
                    tabControl1.Enabled = true;
                    offButtonGlobal.Enabled = true;
                    writeStatusLabel.Text = "Ready to send data";
                }
            }
            catch (UnauthorizedAccessException)
            {
                serialDataBox.Text = "Unauthorised Access";
                throw;
            }
        }

        private void serialCloseButton_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                serialPort1.DiscardInBuffer();
                serialPort1.Close();
                serialBeginButton.Enabled = true;
                serialCloseButton.Enabled = false;
                sendWriteButton.Enabled = false;
                tabControl1.Enabled = false;
                offButtonGlobal.Enabled = false;
                writeStatusLabel.Text = "Open a serial port to write data";
                serialPort1.Dispose();
            }
        }
        /*
        private void serialDataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            // Read data asynchronously
            Task.Run(() =>
            {
                string indata = serialPort1.ReadExisting();
                //Console.WriteLine(indata);
                serialPort1.DiscardInBuffer();

                // Update the TextBox on the UI thread (using Invoke)
                this.Invoke(new MethodInvoker(delegate ()
                {
                    serialDataBox.Text = indata;
                    readData = indata;
                    Console.WriteLine(readData);
                    updateVels();
                    updateChart();
                }));

            });
        }
        */
        private void serialDataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            // Read data asynchronously
            Task.Run(() =>
            {
                // Read data until the end delimiter is found
                string indata = "";
                while (serialPort1.BytesToRead > 0)
                {
                    indata += (char)serialPort1.ReadByte();
                    if (indata.EndsWith(">"))
                    {
                        break;
                    }
                }

                // Log the raw data
                Console.WriteLine("Received Data: " + indata);

                // Update the TextBox on the UI thread (using Invoke)
                this.Invoke(new MethodInvoker(delegate ()
                {
                    serialDataBox.Text = indata;
                    readData = indata;

                    // Parse and append data
                    parseAndAppend(readData);

                    // Update the chart
                    if (chart1.InvokeRequired)
                    {
                        chart1.BeginInvoke(new MethodInvoker(updateChart));
                    }
                    else
                    {
                        updateChart();
                        updateVels();
                    }

                    // Clear the buffer after processing data
                    serialPort1.DiscardInBuffer();
                }));
            });
        }

        private void sendWriteButton_Click(object sender, EventArgs e)
        {
            serialPort1.WriteLine(writeInputTextBox.Text);
            writeStatusLabel.Text = "Successfully sent: " + writeInputTextBox.Text;
            writeInputTextBox.Clear();
        }

        private void writeInputTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                // User pressed Enter key
                e.Handled = true; // Prevent the default Enter behavior (new line)

                // Send the text from the TextBox
                serialPort1.WriteLine(writeInputTextBox.Text);
                writeStatusLabel.Text = "Successfully sent: " + writeInputTextBox.Text;
                // Clear the TextBox
                writeInputTextBox.Clear();
            }
        }

        private void formClosing(object sender, FormClosingEventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                try
                {
                    serialPort1.Close(); // Close the port if it's open
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error closing serial port: " + ex.Message);
                }
                finally
                {
                    serialPort1.Dispose(); // Dispose of the SerialPort object
                }
            }
        }


        private void sendDrive(int x, int y, int driveState, int encState)
        {
            string writeString = "<" + x + ',' + y + ',' + driveState + ',' + encState + '>';
            serialPort1.WriteLine(writeString);
            writeStatusLabel.Text = "Successfully sent: " + writeString;
            writeInputTextBox.Clear();
        }

        private void offButtonGlobal_Click(object sender, EventArgs e)
        {
            sendDrive(xVal, yVal, 1, 0);
        }
        

        //RADIO BUTTONS FOR LEFT OR RIGHT SIDE
        private void radioButtonBoth_CheckedChanged(object sender, EventArgs e)
        {
            rightDirRadioPanel.Enabled = true;
            leftDirRadioPanel.Enabled = true;

            trackBarLeft.Enabled = true;
            trackBarRight.Enabled = true;
            leftEn = 1;
            rightEn = 1;
        }

        private void radioButtonLeft_CheckedChanged(object sender, EventArgs e)
        {
            rightDirRadioPanel.Enabled = false;
            leftDirRadioPanel.Enabled = true;

            trackBarLeft.Enabled = true;
            trackBarRight.Enabled = false;
            leftEn = 1;
            rightEn = 0;
        }

        private void radioButtonRight_CheckedChanged(object sender, EventArgs e)
        {
            rightDirRadioPanel.Enabled = true;
            leftDirRadioPanel.Enabled = false;


            trackBarLeft.Enabled = false;
            trackBarRight.Enabled = true;
            leftEn = 0;
            rightEn = 1;
        }


        //DIRECTION SELECTION
        private void fwdLeft_CheckedChanged(object sender, EventArgs e)
        {
            leftDir = 1;
        }

        private void revLeft_CheckedChanged(object sender, EventArgs e)
        {
            leftDir = -1;
        }

        private void fwdRight_CheckedChanged(object sender, EventArgs e)
        {
            rightDir = 1;
        }

        private void revRight_CheckedChanged(object sender, EventArgs e)
        {
            rightDir = -1;
        }

        private void updateSliders()
        {
            trackBarLeft.Value = Math.Abs(xVal);
            trackBarRight.Value = Math.Abs(yVal);
            leftSpeedDisplay.Text = xVal.ToString();
            rightSpeedDisplay.Text = yVal.ToString();
        }


        //PRESELECT DRIVE BUTTONS
        private void drive50_Click(object sender, EventArgs e)
        {
            xVal = leftDir * leftEn * 50;
            yVal = rightDir * rightEn * 50;
            updateSliders();
            sendDrive(xVal, yVal, 0, 0);
        }

        private void drive100_Click(object sender, EventArgs e)
        {
            xVal = leftDir * leftEn * 100;
            yVal = rightDir * rightEn * 100;
            updateSliders();
            sendDrive(xVal, yVal, 0, 0);
        }

        private void drive200_Click(object sender, EventArgs e)
        {
            xVal = leftDir * leftEn * 200;
            yVal = rightDir * rightEn * 200;
            updateSliders();
            sendDrive(xVal, yVal, 0, 0);
        }

        private void drive300_Click(object sender, EventArgs e)
        {
            xVal = leftDir * leftEn * 300;
            yVal = rightDir * rightEn * 300;
            updateSliders();
            sendDrive(xVal, yVal, 0, 0);
        }

        private void drive400_Click(object sender, EventArgs e)
        {
            xVal = leftDir * leftEn * 400;
            yVal = rightDir * rightEn * 400;
            updateSliders();
            sendDrive(xVal, yVal, 0, 0);
        }

        private void drive500_Click(object sender, EventArgs e)
        {
            xVal = leftDir * leftEn * 500;
            yVal = rightDir * rightEn * 500;
            updateSliders();
            sendDrive(xVal, yVal, 0, 0);
        }

        private void drive600_Click(object sender, EventArgs e)
        {
            xVal = leftDir * leftEn * 600;
            yVal = rightDir * rightEn * 600;
            updateSliders();
            sendDrive(xVal, yVal, 0, 0);
        }

        private void offButton2_Click(object sender, EventArgs e)
        {
            xVal = 0;
            yVal = 0;
            sendDrive(0,0,1,0);
            sendDrive(0,0,1,0);
            sendDrive(0,0,1,0);
            updateSliders();
        }

        private void brakeButton_Click(object sender, EventArgs e)
        {
            sendDrive(0,0,2,0);
            updateSliders();
        }

        private void rightSlider_ValueChanged(object sender, EventArgs e)
        {
            yVal = rightDir * rightEn * trackBarRight.Value;
            updateSliders();
            sendDrive(xVal, yVal, 0, 0);
        }

        private void LeftSlider_ValueChanged(object sender, EventArgs e)
        {
            xVal = leftDir * leftEn * trackBarLeft.Value;
            updateSliders();
            sendDrive(xVal, yVal, 0, 0);
        }

        private void clearGraph_Click(object sender, EventArgs e)
        {
            clearGraphPoints();
        }


        private void targetCoords_Changed(object sender, EventArgs e)
        {
            xTarget = trackBarXTarget.Value;
            yTarget = -trackBarYTarget.Value;
            targetCoordLabel.Text = "(" + xTarget + ", " + yTarget + ")";
        }

        private void goButton_Click(object sender, EventArgs e)
        {
            sendDrive(xTarget, yTarget, 0, 0);
        }

        private void resetOdoButton_Click(object sender, EventArgs e)
        {
            sendDrive(xTarget, yTarget, 1, 1);
        }

        private void targetOff_Click(object sender, EventArgs e)
        {
            sendDrive(xTarget, yTarget, 1, 0);
        }

        private void resetTarget_Click(object sender, EventArgs e)
        {
            xTarget = 0;
            yTarget = 0;
            trackBarYTarget.Value = 0;
            trackBarXTarget.Value = 0;
        }
    }
}
