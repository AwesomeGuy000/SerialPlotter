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


public struct Vec
{
    public float x;
    public float y;
}



namespace SerialPlotter
{

    public partial class Form1 : Form
    {


        private int xVal;
        private int yVal;
        private int leftDir = 1;
        private int rightDir = 1;
        private int leftEn = 1;
        private int rightEn = 1;

        public string readData;
        public List<int> currLVel;
        public List<int> currRVel;
        public List<int> targLVel;
        public List<int> targRVel;
        private int latestCurrLVel = 0;
        private int latestCurrRVel = 0;
        private int latestTargLVel = 0;
        private int latestTargRVel = 0;
        public static int maxSeriesLength = 100;


        private void parseAndAppend(string data)
        {
            // Use Regex to check the format
            if (System.Text.RegularExpressions.Regex.IsMatch(data, @"^<(\d+\.?\d*,\d+\.?\d*,\d+\.?\d*,\d+\.?\d*)>$"))
            {
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
                serialPort1.Close();
                serialBeginButton.Enabled = true;
                serialCloseButton.Enabled = false;
                sendWriteButton.Enabled = false;
                tabControl1.Enabled = false;
                offButtonGlobal.Enabled = false;
                writeStatusLabel.Text = "Open a serial port to write data";
            }
        }

        private void serialDataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            // Read data asynchronously
            Task.Run(() =>
            {
                string indata = serialPort1.ReadExisting();
                //Console.WriteLine(indata);

                // Update the TextBox on the UI thread (using Invoke)
                this.Invoke(new MethodInvoker(delegate ()
                {
                    serialDataBox.Text = indata;
                    readData = indata;
                    parseAndAppend(readData);
                    updateVels();
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
    }
}
