namespace SerialPlotter
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.portLabel = new System.Windows.Forms.Label();
            this.serialDataBox = new System.Windows.Forms.TextBox();
            this.baudLabel = new System.Windows.Forms.Label();
            this.serialBeginButton = new System.Windows.Forms.Button();
            this.comboBoxPort = new System.Windows.Forms.ComboBox();
            this.comboBoxBaud = new System.Windows.Forms.ComboBox();
            this.serialCloseButton = new System.Windows.Forms.Button();
            this.writeInputTextBox = new System.Windows.Forms.TextBox();
            this.writeLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.writeStatusLabel = new System.Windows.Forms.Label();
            this.sendWriteButton = new System.Windows.Forms.Button();
            this.offButtonGlobal = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.wheelVelPage = new System.Windows.Forms.TabPage();
            this.targetCoordPage = new System.Windows.Forms.TabPage();
            this.drive50 = new System.Windows.Forms.Button();
            this.drive100 = new System.Windows.Forms.Button();
            this.drive200 = new System.Windows.Forms.Button();
            this.drive300 = new System.Windows.Forms.Button();
            this.drive400 = new System.Windows.Forms.Button();
            this.drive500 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.drive600 = new System.Windows.Forms.Button();
            this.radioButtonBoth = new System.Windows.Forms.RadioButton();
            this.radioButtonLeft = new System.Windows.Forms.RadioButton();
            this.radioButtonRight = new System.Windows.Forms.RadioButton();
            this.offButton2 = new System.Windows.Forms.Button();
            this.brakeButton = new System.Windows.Forms.Button();
            this.trackBarLeft = new System.Windows.Forms.TrackBar();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.panel5 = new System.Windows.Forms.Panel();
            this.leftSpeedDisplay = new System.Windows.Forms.Label();
            this.rightSpeedDisplay = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.wheelVelPage.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarLeft)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // serialPort1
            // 
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialDataReceived);
            // 
            // portLabel
            // 
            this.portLabel.AutoSize = true;
            this.portLabel.Location = new System.Drawing.Point(13, 13);
            this.portLabel.Name = "portLabel";
            this.portLabel.Size = new System.Drawing.Size(55, 13);
            this.portLabel.TabIndex = 0;
            this.portLabel.Text = "Serial Port";
            // 
            // serialDataBox
            // 
            this.serialDataBox.Location = new System.Drawing.Point(155, 9);
            this.serialDataBox.Multiline = true;
            this.serialDataBox.Name = "serialDataBox";
            this.serialDataBox.ReadOnly = true;
            this.serialDataBox.Size = new System.Drawing.Size(216, 48);
            this.serialDataBox.TabIndex = 2;
            // 
            // baudLabel
            // 
            this.baudLabel.AutoSize = true;
            this.baudLabel.Location = new System.Drawing.Point(10, 41);
            this.baudLabel.Name = "baudLabel";
            this.baudLabel.Size = new System.Drawing.Size(58, 13);
            this.baudLabel.TabIndex = 3;
            this.baudLabel.Text = "Baud Rate";
            // 
            // serialBeginButton
            // 
            this.serialBeginButton.Location = new System.Drawing.Point(16, 63);
            this.serialBeginButton.Name = "serialBeginButton";
            this.serialBeginButton.Size = new System.Drawing.Size(178, 53);
            this.serialBeginButton.TabIndex = 5;
            this.serialBeginButton.Text = "Begin";
            this.serialBeginButton.UseVisualStyleBackColor = true;
            this.serialBeginButton.Click += new System.EventHandler(this.serialBegin_Click);
            // 
            // comboBoxPort
            // 
            this.comboBoxPort.FormattingEnabled = true;
            this.comboBoxPort.Location = new System.Drawing.Point(74, 9);
            this.comboBoxPort.Name = "comboBoxPort";
            this.comboBoxPort.Size = new System.Drawing.Size(75, 21);
            this.comboBoxPort.TabIndex = 6;
            // 
            // comboBoxBaud
            // 
            this.comboBoxBaud.FormattingEnabled = true;
            this.comboBoxBaud.Items.AddRange(new object[] {
            "4800",
            "9600",
            "19200",
            "57600",
            "115200",
            "500000",
            "1000000"});
            this.comboBoxBaud.Location = new System.Drawing.Point(74, 36);
            this.comboBoxBaud.Name = "comboBoxBaud";
            this.comboBoxBaud.Size = new System.Drawing.Size(75, 21);
            this.comboBoxBaud.TabIndex = 7;
            this.comboBoxBaud.Text = "500000";
            // 
            // serialCloseButton
            // 
            this.serialCloseButton.Enabled = false;
            this.serialCloseButton.Location = new System.Drawing.Point(200, 63);
            this.serialCloseButton.Name = "serialCloseButton";
            this.serialCloseButton.Size = new System.Drawing.Size(171, 53);
            this.serialCloseButton.TabIndex = 8;
            this.serialCloseButton.Text = "Close";
            this.serialCloseButton.UseVisualStyleBackColor = true;
            this.serialCloseButton.Click += new System.EventHandler(this.serialCloseButton_Click);
            // 
            // writeInputTextBox
            // 
            this.writeInputTextBox.Location = new System.Drawing.Point(67, 0);
            this.writeInputTextBox.Name = "writeInputTextBox";
            this.writeInputTextBox.Size = new System.Drawing.Size(201, 20);
            this.writeInputTextBox.TabIndex = 9;
            this.writeInputTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.writeInputTextBox_KeyPress);
            // 
            // writeLabel
            // 
            this.writeLabel.AutoSize = true;
            this.writeLabel.Location = new System.Drawing.Point(3, 3);
            this.writeLabel.Name = "writeLabel";
            this.writeLabel.Size = new System.Drawing.Size(58, 13);
            this.writeLabel.TabIndex = 10;
            this.writeLabel.Text = "Write Data";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.writeStatusLabel);
            this.panel1.Controls.Add(this.sendWriteButton);
            this.panel1.Controls.Add(this.writeLabel);
            this.panel1.Controls.Add(this.writeInputTextBox);
            this.panel1.Location = new System.Drawing.Point(377, 9);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(342, 48);
            this.panel1.TabIndex = 11;
            // 
            // writeStatusLabel
            // 
            this.writeStatusLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.writeStatusLabel.Location = new System.Drawing.Point(2, 23);
            this.writeStatusLabel.Name = "writeStatusLabel";
            this.writeStatusLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.writeStatusLabel.Size = new System.Drawing.Size(262, 21);
            this.writeStatusLabel.TabIndex = 12;
            this.writeStatusLabel.Text = "Open a serial port to write data ya idiot";
            this.writeStatusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // sendWriteButton
            // 
            this.sendWriteButton.Enabled = false;
            this.sendWriteButton.Location = new System.Drawing.Point(274, 1);
            this.sendWriteButton.Name = "sendWriteButton";
            this.sendWriteButton.Size = new System.Drawing.Size(63, 44);
            this.sendWriteButton.TabIndex = 11;
            this.sendWriteButton.Text = "Send";
            this.sendWriteButton.UseVisualStyleBackColor = true;
            this.sendWriteButton.Click += new System.EventHandler(this.sendWriteButton_Click);
            // 
            // offButtonGlobal
            // 
            this.offButtonGlobal.Enabled = false;
            this.offButtonGlobal.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.offButtonGlobal.Location = new System.Drawing.Point(377, 63);
            this.offButtonGlobal.Name = "offButtonGlobal";
            this.offButtonGlobal.Size = new System.Drawing.Size(337, 53);
            this.offButtonGlobal.TabIndex = 12;
            this.offButtonGlobal.Text = "OFF";
            this.offButtonGlobal.UseVisualStyleBackColor = true;
            this.offButtonGlobal.Click += new System.EventHandler(this.offButtonGlobal_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(4, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 16);
            this.label1.TabIndex = 13;
            this.label1.Text = "Preset Drive Values";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.wheelVelPage);
            this.tabControl1.Controls.Add(this.targetCoordPage);
            this.tabControl1.Enabled = false;
            this.tabControl1.Location = new System.Drawing.Point(16, 122);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(698, 316);
            this.tabControl1.TabIndex = 14;
            // 
            // wheelVelPage
            // 
            this.wheelVelPage.Controls.Add(this.panel2);
            this.wheelVelPage.Location = new System.Drawing.Point(4, 22);
            this.wheelVelPage.Name = "wheelVelPage";
            this.wheelVelPage.Padding = new System.Windows.Forms.Padding(3);
            this.wheelVelPage.Size = new System.Drawing.Size(690, 290);
            this.wheelVelPage.TabIndex = 0;
            this.wheelVelPage.Text = "Wheel Velocities";
            this.wheelVelPage.UseVisualStyleBackColor = true;
            // 
            // targetCoordPage
            // 
            this.targetCoordPage.Location = new System.Drawing.Point(4, 22);
            this.targetCoordPage.Name = "targetCoordPage";
            this.targetCoordPage.Padding = new System.Windows.Forms.Padding(3);
            this.targetCoordPage.Size = new System.Drawing.Size(690, 290);
            this.targetCoordPage.TabIndex = 1;
            this.targetCoordPage.Text = "Target Coordinates";
            this.targetCoordPage.UseVisualStyleBackColor = true;
            // 
            // drive50
            // 
            this.drive50.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.drive50.Location = new System.Drawing.Point(239, 15);
            this.drive50.Name = "drive50";
            this.drive50.Size = new System.Drawing.Size(45, 37);
            this.drive50.TabIndex = 14;
            this.drive50.Text = "50";
            this.drive50.UseVisualStyleBackColor = true;
            this.drive50.Click += new System.EventHandler(this.drive50_Click);
            // 
            // drive100
            // 
            this.drive100.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.drive100.Location = new System.Drawing.Point(290, 15);
            this.drive100.Name = "drive100";
            this.drive100.Size = new System.Drawing.Size(42, 37);
            this.drive100.TabIndex = 15;
            this.drive100.Text = "100";
            this.drive100.UseVisualStyleBackColor = true;
            this.drive100.Click += new System.EventHandler(this.drive100_Click);
            // 
            // drive200
            // 
            this.drive200.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.drive200.Location = new System.Drawing.Point(338, 15);
            this.drive200.Name = "drive200";
            this.drive200.Size = new System.Drawing.Size(42, 37);
            this.drive200.TabIndex = 16;
            this.drive200.Text = "200";
            this.drive200.UseVisualStyleBackColor = true;
            this.drive200.Click += new System.EventHandler(this.drive200_Click);
            // 
            // drive300
            // 
            this.drive300.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.drive300.Location = new System.Drawing.Point(386, 15);
            this.drive300.Name = "drive300";
            this.drive300.Size = new System.Drawing.Size(42, 37);
            this.drive300.TabIndex = 17;
            this.drive300.Text = "300";
            this.drive300.UseVisualStyleBackColor = true;
            this.drive300.Click += new System.EventHandler(this.drive300_Click);
            // 
            // drive400
            // 
            this.drive400.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.drive400.Location = new System.Drawing.Point(434, 15);
            this.drive400.Name = "drive400";
            this.drive400.Size = new System.Drawing.Size(42, 37);
            this.drive400.TabIndex = 18;
            this.drive400.Text = "400";
            this.drive400.UseVisualStyleBackColor = true;
            this.drive400.Click += new System.EventHandler(this.drive400_Click);
            // 
            // drive500
            // 
            this.drive500.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.drive500.Location = new System.Drawing.Point(482, 15);
            this.drive500.Name = "drive500";
            this.drive500.Size = new System.Drawing.Size(42, 37);
            this.drive500.TabIndex = 19;
            this.drive500.Text = "500";
            this.drive500.UseVisualStyleBackColor = true;
            this.drive500.Click += new System.EventHandler(this.drive500_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.rightSpeedDisplay);
            this.panel2.Controls.Add(this.leftSpeedDisplay);
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.trackBar1);
            this.panel2.Controls.Add(this.trackBarLeft);
            this.panel2.Controls.Add(this.brakeButton);
            this.panel2.Controls.Add(this.offButton2);
            this.panel2.Controls.Add(this.drive600);
            this.panel2.Controls.Add(this.drive200);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.drive50);
            this.panel2.Controls.Add(this.drive100);
            this.panel2.Controls.Add(this.drive300);
            this.panel2.Controls.Add(this.drive400);
            this.panel2.Controls.Add(this.drive500);
            this.panel2.Location = new System.Drawing.Point(3, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(684, 132);
            this.panel2.TabIndex = 33;
            // 
            // drive600
            // 
            this.drive600.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.drive600.Location = new System.Drawing.Point(530, 15);
            this.drive600.Name = "drive600";
            this.drive600.Size = new System.Drawing.Size(42, 37);
            this.drive600.TabIndex = 20;
            this.drive600.Text = "600";
            this.drive600.UseVisualStyleBackColor = true;
            this.drive600.Click += new System.EventHandler(this.drive600_Click);
            // 
            // radioButtonBoth
            // 
            this.radioButtonBoth.AutoSize = true;
            this.radioButtonBoth.Checked = true;
            this.radioButtonBoth.Location = new System.Drawing.Point(3, 2);
            this.radioButtonBoth.Name = "radioButtonBoth";
            this.radioButtonBoth.Size = new System.Drawing.Size(76, 17);
            this.radioButtonBoth.TabIndex = 21;
            this.radioButtonBoth.TabStop = true;
            this.radioButtonBoth.Text = "Both Sides";
            this.radioButtonBoth.UseVisualStyleBackColor = true;
            // 
            // radioButtonLeft
            // 
            this.radioButtonLeft.AutoSize = true;
            this.radioButtonLeft.Location = new System.Drawing.Point(3, 22);
            this.radioButtonLeft.Name = "radioButtonLeft";
            this.radioButtonLeft.Size = new System.Drawing.Size(91, 17);
            this.radioButtonLeft.TabIndex = 22;
            this.radioButtonLeft.Text = "Left Side Only";
            this.radioButtonLeft.UseVisualStyleBackColor = true;
            // 
            // radioButtonRight
            // 
            this.radioButtonRight.AutoSize = true;
            this.radioButtonRight.Location = new System.Drawing.Point(3, 42);
            this.radioButtonRight.Name = "radioButtonRight";
            this.radioButtonRight.Size = new System.Drawing.Size(98, 17);
            this.radioButtonRight.TabIndex = 23;
            this.radioButtonRight.Text = "Right Side Only";
            this.radioButtonRight.UseVisualStyleBackColor = true;
            // 
            // offButton2
            // 
            this.offButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.offButton2.Location = new System.Drawing.Point(596, 14);
            this.offButton2.Name = "offButton2";
            this.offButton2.Size = new System.Drawing.Size(80, 56);
            this.offButton2.TabIndex = 24;
            this.offButton2.Text = "OFF";
            this.offButton2.UseVisualStyleBackColor = true;
            // 
            // brakeButton
            // 
            this.brakeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.brakeButton.Location = new System.Drawing.Point(596, 76);
            this.brakeButton.Name = "brakeButton";
            this.brakeButton.Size = new System.Drawing.Size(80, 27);
            this.brakeButton.TabIndex = 25;
            this.brakeButton.Text = "BRAKE";
            this.brakeButton.UseVisualStyleBackColor = true;
            // 
            // trackBarLeft
            // 
            this.trackBarLeft.BackColor = System.Drawing.SystemColors.Window;
            this.trackBarLeft.Location = new System.Drawing.Point(242, 66);
            this.trackBarLeft.Maximum = 600;
            this.trackBarLeft.Name = "trackBarLeft";
            this.trackBarLeft.Size = new System.Drawing.Size(165, 45);
            this.trackBarLeft.TabIndex = 26;
            this.trackBarLeft.TickFrequency = 50;
            this.trackBarLeft.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // trackBar1
            // 
            this.trackBar1.BackColor = System.Drawing.SystemColors.Window;
            this.trackBar1.Location = new System.Drawing.Point(413, 66);
            this.trackBar1.Maximum = 600;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(165, 45);
            this.trackBar1.TabIndex = 27;
            this.trackBar1.TickFrequency = 50;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(3, 3);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(78, 17);
            this.radioButton1.TabIndex = 28;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Forward (+)";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(3, 21);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(77, 17);
            this.radioButton2.TabIndex = 29;
            this.radioButton2.Text = "Reverse (-)";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.radioButtonLeft);
            this.panel3.Controls.Add(this.radioButtonRight);
            this.panel3.Controls.Add(this.radioButtonBoth);
            this.panel3.Location = new System.Drawing.Point(15, 38);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(102, 65);
            this.panel3.TabIndex = 30;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.radioButton1);
            this.panel4.Controls.Add(this.radioButton2);
            this.panel4.Location = new System.Drawing.Point(123, 25);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(90, 44);
            this.panel4.TabIndex = 31;
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(3, 21);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(77, 17);
            this.radioButton4.TabIndex = 29;
            this.radioButton4.Text = "Reverse (-)";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Checked = true;
            this.radioButton3.Location = new System.Drawing.Point(3, 3);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(78, 17);
            this.radioButton3.TabIndex = 28;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Forward (+)";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.radioButton3);
            this.panel5.Controls.Add(this.radioButton4);
            this.panel5.Location = new System.Drawing.Point(123, 72);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(90, 44);
            this.panel5.TabIndex = 32;
            // 
            // leftSpeedDisplay
            // 
            this.leftSpeedDisplay.AutoSize = true;
            this.leftSpeedDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.leftSpeedDisplay.Location = new System.Drawing.Point(316, 103);
            this.leftSpeedDisplay.Name = "leftSpeedDisplay";
            this.leftSpeedDisplay.Size = new System.Drawing.Size(16, 18);
            this.leftSpeedDisplay.TabIndex = 33;
            this.leftSpeedDisplay.Text = "0";
            // 
            // rightSpeedDisplay
            // 
            this.rightSpeedDisplay.AutoSize = true;
            this.rightSpeedDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rightSpeedDisplay.Location = new System.Drawing.Point(492, 103);
            this.rightSpeedDisplay.Name = "rightSpeedDisplay";
            this.rightSpeedDisplay.Size = new System.Drawing.Size(16, 18);
            this.rightSpeedDisplay.TabIndex = 34;
            this.rightSpeedDisplay.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(726, 497);
            this.Controls.Add(this.offButtonGlobal);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.serialDataBox);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.serialCloseButton);
            this.Controls.Add(this.comboBoxBaud);
            this.Controls.Add(this.comboBoxPort);
            this.Controls.Add(this.serialBeginButton);
            this.Controls.Add(this.baudLabel);
            this.Controls.Add(this.portLabel);
            this.Name = "Form1";
            this.Text = "Serial Writer";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.formClosing);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.wheelVelPage.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarLeft)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Label portLabel;
        private System.Windows.Forms.TextBox serialDataBox;
        private System.Windows.Forms.Label baudLabel;
        private System.Windows.Forms.Button serialBeginButton;
        private System.Windows.Forms.ComboBox comboBoxPort;
        private System.Windows.Forms.ComboBox comboBoxBaud;
        private System.Windows.Forms.Button serialCloseButton;
        private System.Windows.Forms.TextBox writeInputTextBox;
        private System.Windows.Forms.Label writeLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button sendWriteButton;
        private System.Windows.Forms.Label writeStatusLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage wheelVelPage;
        private System.Windows.Forms.TabPage targetCoordPage;
        private System.Windows.Forms.Button offButtonGlobal;
        private System.Windows.Forms.Button drive50;
        private System.Windows.Forms.Button drive500;
        private System.Windows.Forms.Button drive400;
        private System.Windows.Forms.Button drive300;
        private System.Windows.Forms.Button drive200;
        private System.Windows.Forms.Button drive100;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button drive600;
        private System.Windows.Forms.RadioButton radioButtonBoth;
        private System.Windows.Forms.RadioButton radioButtonRight;
        private System.Windows.Forms.RadioButton radioButtonLeft;
        private System.Windows.Forms.TrackBar trackBarLeft;
        private System.Windows.Forms.Button brakeButton;
        private System.Windows.Forms.Button offButton2;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Label rightSpeedDisplay;
        private System.Windows.Forms.Label leftSpeedDisplay;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
    }
}

