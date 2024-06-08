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



namespace SerialPlotter
{

    public partial class Form1 : Form
    {
        public int xVal;
        public int yVal;

        public Form1()
        {
            InitializeComponent();
            getSerialPorts();
        }
        void getSerialPorts()
        {
            String[] availablePorts = SerialPort.GetPortNames();
            comboBoxPort.Items.AddRange(availablePorts);
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
                Console.WriteLine(indata);

                // Update the TextBox on the UI thread (using Invoke)
                this.Invoke(new MethodInvoker(delegate ()
                {
                    serialDataBox.Text = indata;
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

        private void drive50_Click(object sender, EventArgs e)
        {
            xVal = 50;
            yVal = 50;
            sendDrive(xVal, yVal, 0, 0);
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {

        }

        private void drive100_Click(object sender, EventArgs e)
        {

        }

        private void drive200_Click(object sender, EventArgs e)
        {

        }

        private void drive300_Click(object sender, EventArgs e)
        {

        }

        private void drive400_Click(object sender, EventArgs e)
        {

        }

        private void drive500_Click(object sender, EventArgs e)
        {

        }

        private void drive600_Click(object sender, EventArgs e)
        {

        }
    }
}
