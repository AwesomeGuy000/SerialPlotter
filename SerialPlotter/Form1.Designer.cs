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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.wheelVelPage = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rightMeasured = new System.Windows.Forms.Label();
            this.rightTarget = new System.Windows.Forms.Label();
            this.leftTarget = new System.Windows.Forms.Label();
            this.leftMeasured = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.offButton2 = new System.Windows.Forms.Button();
            this.rightSpeedDisplay = new System.Windows.Forms.Label();
            this.drive500 = new System.Windows.Forms.Button();
            this.leftSpeedDisplay = new System.Windows.Forms.Label();
            this.drive400 = new System.Windows.Forms.Button();
            this.rightDirRadioPanel = new System.Windows.Forms.Panel();
            this.fwdRight = new System.Windows.Forms.RadioButton();
            this.revRight = new System.Windows.Forms.RadioButton();
            this.drive300 = new System.Windows.Forms.Button();
            this.leftDirRadioPanel = new System.Windows.Forms.Panel();
            this.fwdLeft = new System.Windows.Forms.RadioButton();
            this.revLeft = new System.Windows.Forms.RadioButton();
            this.drive100 = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.radioButtonLeft = new System.Windows.Forms.RadioButton();
            this.radioButtonRight = new System.Windows.Forms.RadioButton();
            this.radioButtonBoth = new System.Windows.Forms.RadioButton();
            this.drive50 = new System.Windows.Forms.Button();
            this.trackBarRight = new System.Windows.Forms.TrackBar();
            this.drive200 = new System.Windows.Forms.Button();
            this.trackBarLeft = new System.Windows.Forms.TrackBar();
            this.drive600 = new System.Windows.Forms.Button();
            this.brakeButton = new System.Windows.Forms.Button();
            this.targetCoordPage = new System.Windows.Forms.TabPage();
            this.offResetButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.form1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button16 = new System.Windows.Forms.Button();
            this.button20 = new System.Windows.Forms.Button();
            this.button21 = new System.Windows.Forms.Button();
            this.button22 = new System.Windows.Forms.Button();
            this.button23 = new System.Windows.Forms.Button();
            this.button24 = new System.Windows.Forms.Button();
            this.button25 = new System.Windows.Forms.Button();
            this.button26 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.button17 = new System.Windows.Forms.Button();
            this.button18 = new System.Windows.Forms.Button();
            this.button19 = new System.Windows.Forms.Button();
            this.button27 = new System.Windows.Forms.Button();
            this.button28 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.wheelVelPage.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.rightDirRadioPanel.SuspendLayout();
            this.leftDirRadioPanel.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarRight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarLeft)).BeginInit();
            this.targetCoordPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.form1BindingSource)).BeginInit();
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
            this.comboBoxPort.Text = "COM3";
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
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.wheelVelPage);
            this.tabControl1.Controls.Add(this.targetCoordPage);
            this.tabControl1.Enabled = false;
            this.tabControl1.Location = new System.Drawing.Point(13, 122);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(706, 363);
            this.tabControl1.TabIndex = 14;
            // 
            // wheelVelPage
            // 
            this.wheelVelPage.Controls.Add(this.groupBox2);
            this.wheelVelPage.Controls.Add(this.groupBox1);
            this.wheelVelPage.Location = new System.Drawing.Point(4, 22);
            this.wheelVelPage.Name = "wheelVelPage";
            this.wheelVelPage.Padding = new System.Windows.Forms.Padding(3);
            this.wheelVelPage.Size = new System.Drawing.Size(698, 337);
            this.wheelVelPage.TabIndex = 0;
            this.wheelVelPage.Text = "Wheel Velocities";
            this.wheelVelPage.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Location = new System.Drawing.Point(4, 141);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(679, 195);
            this.groupBox2.TabIndex = 35;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Data Received";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rightMeasured);
            this.groupBox3.Controls.Add(this.rightTarget);
            this.groupBox3.Controls.Add(this.leftTarget);
            this.groupBox3.Controls.Add(this.leftMeasured);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Location = new System.Drawing.Point(534, 114);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(136, 75);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Raw Velocities";
            // 
            // rightMeasured
            // 
            this.rightMeasured.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.rightMeasured.Location = new System.Drawing.Point(48, 55);
            this.rightMeasured.Name = "rightMeasured";
            this.rightMeasured.Size = new System.Drawing.Size(32, 13);
            this.rightMeasured.TabIndex = 8;
            this.rightMeasured.Text = "0";
            this.rightMeasured.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // rightTarget
            // 
            this.rightTarget.Location = new System.Drawing.Point(97, 55);
            this.rightTarget.Name = "rightTarget";
            this.rightTarget.Size = new System.Drawing.Size(32, 13);
            this.rightTarget.TabIndex = 7;
            this.rightTarget.Text = "0";
            this.rightTarget.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // leftTarget
            // 
            this.leftTarget.Location = new System.Drawing.Point(97, 36);
            this.leftTarget.Name = "leftTarget";
            this.leftTarget.Size = new System.Drawing.Size(32, 13);
            this.leftTarget.TabIndex = 6;
            this.leftTarget.Text = "0";
            this.leftTarget.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // leftMeasured
            // 
            this.leftMeasured.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.leftMeasured.Location = new System.Drawing.Point(48, 36);
            this.leftMeasured.Name = "leftMeasured";
            this.leftMeasured.Size = new System.Drawing.Size(32, 13);
            this.leftMeasured.TabIndex = 4;
            this.leftMeasured.Text = "0";
            this.leftMeasured.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(39, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Measured";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(94, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Target";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Right";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Left";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.offButton2);
            this.groupBox1.Controls.Add(this.rightSpeedDisplay);
            this.groupBox1.Controls.Add(this.drive500);
            this.groupBox1.Controls.Add(this.leftSpeedDisplay);
            this.groupBox1.Controls.Add(this.drive400);
            this.groupBox1.Controls.Add(this.rightDirRadioPanel);
            this.groupBox1.Controls.Add(this.drive300);
            this.groupBox1.Controls.Add(this.leftDirRadioPanel);
            this.groupBox1.Controls.Add(this.drive100);
            this.groupBox1.Controls.Add(this.panel3);
            this.groupBox1.Controls.Add(this.drive50);
            this.groupBox1.Controls.Add(this.trackBarRight);
            this.groupBox1.Controls.Add(this.drive200);
            this.groupBox1.Controls.Add(this.trackBarLeft);
            this.groupBox1.Controls.Add(this.drive600);
            this.groupBox1.Controls.Add(this.brakeButton);
            this.groupBox1.Location = new System.Drawing.Point(4, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(688, 129);
            this.groupBox1.TabIndex = 34;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Preset Drive";
            // 
            // offButton2
            // 
            this.offButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.offButton2.Location = new System.Drawing.Point(594, 18);
            this.offButton2.Name = "offButton2";
            this.offButton2.Size = new System.Drawing.Size(88, 73);
            this.offButton2.TabIndex = 24;
            this.offButton2.Text = "OFF";
            this.offButton2.UseVisualStyleBackColor = true;
            this.offButton2.Click += new System.EventHandler(this.offButton2_Click);
            // 
            // rightSpeedDisplay
            // 
            this.rightSpeedDisplay.AutoSize = true;
            this.rightSpeedDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rightSpeedDisplay.Location = new System.Drawing.Point(490, 104);
            this.rightSpeedDisplay.Name = "rightSpeedDisplay";
            this.rightSpeedDisplay.Size = new System.Drawing.Size(16, 18);
            this.rightSpeedDisplay.TabIndex = 34;
            this.rightSpeedDisplay.Text = "0";
            // 
            // drive500
            // 
            this.drive500.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.drive500.Location = new System.Drawing.Point(486, 19);
            this.drive500.Name = "drive500";
            this.drive500.Size = new System.Drawing.Size(42, 37);
            this.drive500.TabIndex = 19;
            this.drive500.Text = "500";
            this.drive500.UseVisualStyleBackColor = true;
            this.drive500.Click += new System.EventHandler(this.drive500_Click);
            // 
            // leftSpeedDisplay
            // 
            this.leftSpeedDisplay.AutoSize = true;
            this.leftSpeedDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.leftSpeedDisplay.Location = new System.Drawing.Point(314, 104);
            this.leftSpeedDisplay.Name = "leftSpeedDisplay";
            this.leftSpeedDisplay.Size = new System.Drawing.Size(16, 18);
            this.leftSpeedDisplay.TabIndex = 33;
            this.leftSpeedDisplay.Text = "0";
            // 
            // drive400
            // 
            this.drive400.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.drive400.Location = new System.Drawing.Point(438, 19);
            this.drive400.Name = "drive400";
            this.drive400.Size = new System.Drawing.Size(42, 37);
            this.drive400.TabIndex = 18;
            this.drive400.Text = "400";
            this.drive400.UseVisualStyleBackColor = true;
            this.drive400.Click += new System.EventHandler(this.drive400_Click);
            // 
            // rightDirRadioPanel
            // 
            this.rightDirRadioPanel.Controls.Add(this.fwdRight);
            this.rightDirRadioPanel.Controls.Add(this.revRight);
            this.rightDirRadioPanel.Location = new System.Drawing.Point(124, 69);
            this.rightDirRadioPanel.Name = "rightDirRadioPanel";
            this.rightDirRadioPanel.Size = new System.Drawing.Size(90, 44);
            this.rightDirRadioPanel.TabIndex = 32;
            // 
            // fwdRight
            // 
            this.fwdRight.AutoSize = true;
            this.fwdRight.Checked = true;
            this.fwdRight.Location = new System.Drawing.Point(3, 3);
            this.fwdRight.Name = "fwdRight";
            this.fwdRight.Size = new System.Drawing.Size(78, 17);
            this.fwdRight.TabIndex = 28;
            this.fwdRight.TabStop = true;
            this.fwdRight.Text = "Forward (+)";
            this.fwdRight.UseVisualStyleBackColor = true;
            this.fwdRight.CheckedChanged += new System.EventHandler(this.fwdRight_CheckedChanged);
            // 
            // revRight
            // 
            this.revRight.AutoSize = true;
            this.revRight.Location = new System.Drawing.Point(3, 21);
            this.revRight.Name = "revRight";
            this.revRight.Size = new System.Drawing.Size(77, 17);
            this.revRight.TabIndex = 29;
            this.revRight.Text = "Reverse (-)";
            this.revRight.UseVisualStyleBackColor = true;
            this.revRight.CheckedChanged += new System.EventHandler(this.revRight_CheckedChanged);
            // 
            // drive300
            // 
            this.drive300.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.drive300.Location = new System.Drawing.Point(390, 19);
            this.drive300.Name = "drive300";
            this.drive300.Size = new System.Drawing.Size(42, 37);
            this.drive300.TabIndex = 17;
            this.drive300.Text = "300";
            this.drive300.UseVisualStyleBackColor = true;
            this.drive300.Click += new System.EventHandler(this.drive300_Click);
            // 
            // leftDirRadioPanel
            // 
            this.leftDirRadioPanel.Controls.Add(this.fwdLeft);
            this.leftDirRadioPanel.Controls.Add(this.revLeft);
            this.leftDirRadioPanel.Location = new System.Drawing.Point(124, 19);
            this.leftDirRadioPanel.Name = "leftDirRadioPanel";
            this.leftDirRadioPanel.Size = new System.Drawing.Size(90, 44);
            this.leftDirRadioPanel.TabIndex = 31;
            // 
            // fwdLeft
            // 
            this.fwdLeft.AutoSize = true;
            this.fwdLeft.Checked = true;
            this.fwdLeft.Location = new System.Drawing.Point(3, 3);
            this.fwdLeft.Name = "fwdLeft";
            this.fwdLeft.Size = new System.Drawing.Size(78, 17);
            this.fwdLeft.TabIndex = 28;
            this.fwdLeft.TabStop = true;
            this.fwdLeft.Text = "Forward (+)";
            this.fwdLeft.UseVisualStyleBackColor = true;
            this.fwdLeft.CheckedChanged += new System.EventHandler(this.fwdLeft_CheckedChanged);
            // 
            // revLeft
            // 
            this.revLeft.AutoSize = true;
            this.revLeft.Location = new System.Drawing.Point(3, 21);
            this.revLeft.Name = "revLeft";
            this.revLeft.Size = new System.Drawing.Size(77, 17);
            this.revLeft.TabIndex = 29;
            this.revLeft.Text = "Reverse (-)";
            this.revLeft.UseVisualStyleBackColor = true;
            this.revLeft.CheckedChanged += new System.EventHandler(this.revLeft_CheckedChanged);
            // 
            // drive100
            // 
            this.drive100.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.drive100.Location = new System.Drawing.Point(294, 19);
            this.drive100.Name = "drive100";
            this.drive100.Size = new System.Drawing.Size(42, 37);
            this.drive100.TabIndex = 15;
            this.drive100.Text = "100";
            this.drive100.UseVisualStyleBackColor = true;
            this.drive100.Click += new System.EventHandler(this.drive100_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.radioButtonLeft);
            this.panel3.Controls.Add(this.radioButtonRight);
            this.panel3.Controls.Add(this.radioButtonBoth);
            this.panel3.Location = new System.Drawing.Point(13, 33);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(102, 65);
            this.panel3.TabIndex = 30;
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
            this.radioButtonLeft.CheckedChanged += new System.EventHandler(this.radioButtonLeft_CheckedChanged);
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
            this.radioButtonRight.CheckedChanged += new System.EventHandler(this.radioButtonRight_CheckedChanged);
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
            this.radioButtonBoth.CheckedChanged += new System.EventHandler(this.radioButtonBoth_CheckedChanged);
            // 
            // drive50
            // 
            this.drive50.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.drive50.Location = new System.Drawing.Point(243, 19);
            this.drive50.Name = "drive50";
            this.drive50.Size = new System.Drawing.Size(45, 37);
            this.drive50.TabIndex = 14;
            this.drive50.Text = "50";
            this.drive50.UseVisualStyleBackColor = true;
            this.drive50.Click += new System.EventHandler(this.drive50_Click);
            // 
            // trackBarRight
            // 
            this.trackBarRight.BackColor = System.Drawing.SystemColors.Window;
            this.trackBarRight.Location = new System.Drawing.Point(411, 71);
            this.trackBarRight.Maximum = 600;
            this.trackBarRight.Name = "trackBarRight";
            this.trackBarRight.Size = new System.Drawing.Size(165, 45);
            this.trackBarRight.TabIndex = 27;
            this.trackBarRight.TickFrequency = 50;
            this.trackBarRight.ValueChanged += new System.EventHandler(this.rightSlider_ValueChanged);
            // 
            // drive200
            // 
            this.drive200.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.drive200.Location = new System.Drawing.Point(342, 19);
            this.drive200.Name = "drive200";
            this.drive200.Size = new System.Drawing.Size(42, 37);
            this.drive200.TabIndex = 16;
            this.drive200.Text = "200";
            this.drive200.UseVisualStyleBackColor = true;
            this.drive200.Click += new System.EventHandler(this.drive200_Click);
            // 
            // trackBarLeft
            // 
            this.trackBarLeft.BackColor = System.Drawing.SystemColors.Window;
            this.trackBarLeft.Location = new System.Drawing.Point(240, 71);
            this.trackBarLeft.Maximum = 600;
            this.trackBarLeft.Name = "trackBarLeft";
            this.trackBarLeft.Size = new System.Drawing.Size(165, 45);
            this.trackBarLeft.TabIndex = 26;
            this.trackBarLeft.TickFrequency = 50;
            this.trackBarLeft.ValueChanged += new System.EventHandler(this.LeftSlider_ValueChanged);
            // 
            // drive600
            // 
            this.drive600.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.drive600.Location = new System.Drawing.Point(534, 19);
            this.drive600.Name = "drive600";
            this.drive600.Size = new System.Drawing.Size(42, 37);
            this.drive600.TabIndex = 20;
            this.drive600.Text = "600";
            this.drive600.UseVisualStyleBackColor = true;
            this.drive600.Click += new System.EventHandler(this.drive600_Click);
            // 
            // brakeButton
            // 
            this.brakeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.brakeButton.Location = new System.Drawing.Point(594, 95);
            this.brakeButton.Name = "brakeButton";
            this.brakeButton.Size = new System.Drawing.Size(88, 28);
            this.brakeButton.TabIndex = 25;
            this.brakeButton.Text = "BRAKE";
            this.brakeButton.UseVisualStyleBackColor = true;
            this.brakeButton.Click += new System.EventHandler(this.brakeButton_Click);
            // 
            // targetCoordPage
            // 
            this.targetCoordPage.Controls.Add(this.button28);
            this.targetCoordPage.Controls.Add(this.button27);
            this.targetCoordPage.Controls.Add(this.button19);
            this.targetCoordPage.Controls.Add(this.button18);
            this.targetCoordPage.Controls.Add(this.button17);
            this.targetCoordPage.Controls.Add(this.button14);
            this.targetCoordPage.Controls.Add(this.button12);
            this.targetCoordPage.Controls.Add(this.button10);
            this.targetCoordPage.Controls.Add(this.button6);
            this.targetCoordPage.Controls.Add(this.button5);
            this.targetCoordPage.Controls.Add(this.button4);
            this.targetCoordPage.Controls.Add(this.button3);
            this.targetCoordPage.Controls.Add(this.button2);
            this.targetCoordPage.Controls.Add(this.button26);
            this.targetCoordPage.Controls.Add(this.button25);
            this.targetCoordPage.Controls.Add(this.button24);
            this.targetCoordPage.Controls.Add(this.button23);
            this.targetCoordPage.Controls.Add(this.button22);
            this.targetCoordPage.Controls.Add(this.button21);
            this.targetCoordPage.Controls.Add(this.button20);
            this.targetCoordPage.Controls.Add(this.button16);
            this.targetCoordPage.Controls.Add(this.button15);
            this.targetCoordPage.Controls.Add(this.button13);
            this.targetCoordPage.Controls.Add(this.button11);
            this.targetCoordPage.Controls.Add(this.button9);
            this.targetCoordPage.Controls.Add(this.button8);
            this.targetCoordPage.Controls.Add(this.button7);
            this.targetCoordPage.Controls.Add(this.button1);
            this.targetCoordPage.Controls.Add(this.offResetButton);
            this.targetCoordPage.Location = new System.Drawing.Point(4, 22);
            this.targetCoordPage.Name = "targetCoordPage";
            this.targetCoordPage.Padding = new System.Windows.Forms.Padding(3);
            this.targetCoordPage.Size = new System.Drawing.Size(698, 337);
            this.targetCoordPage.TabIndex = 1;
            this.targetCoordPage.Text = "Target Coordinates";
            this.targetCoordPage.UseVisualStyleBackColor = true;
            // 
            // offResetButton
            // 
            this.offResetButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.offResetButton.Location = new System.Drawing.Point(329, 286);
            this.offResetButton.Name = "offResetButton";
            this.offResetButton.Size = new System.Drawing.Size(46, 45);
            this.offResetButton.TabIndex = 25;
            this.offResetButton.Text = "OFF + Reset";
            this.offResetButton.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(329, 235);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(46, 45);
            this.button1.TabIndex = 31;
            this.button1.Text = "0.5\r\n0";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.Location = new System.Drawing.Point(329, 184);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(46, 45);
            this.button7.TabIndex = 36;
            this.button7.Text = "1\r\n0";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            this.button8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.Location = new System.Drawing.Point(329, 133);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(46, 45);
            this.button8.TabIndex = 37;
            this.button8.Text = "1.5\r\n0";
            this.button8.UseVisualStyleBackColor = true;
            // 
            // button9
            // 
            this.button9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button9.Location = new System.Drawing.Point(329, 82);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(46, 45);
            this.button9.TabIndex = 38;
            this.button9.Text = "2\r\n0";
            this.button9.UseVisualStyleBackColor = true;
            // 
            // button11
            // 
            this.button11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button11.Location = new System.Drawing.Point(381, 235);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(46, 45);
            this.button11.TabIndex = 40;
            this.button11.Text = "0.5\r\n-0.5";
            this.button11.UseVisualStyleBackColor = true;
            // 
            // button13
            // 
            this.button13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button13.Location = new System.Drawing.Point(381, 286);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(46, 45);
            this.button13.TabIndex = 42;
            this.button13.Text = "0\r\n-0.5";
            this.button13.UseVisualStyleBackColor = true;
            // 
            // button15
            // 
            this.button15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button15.Location = new System.Drawing.Point(433, 286);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(46, 45);
            this.button15.TabIndex = 44;
            this.button15.Text = "0\r\n-1";
            this.button15.UseVisualStyleBackColor = true;
            // 
            // form1BindingSource
            // 
            this.form1BindingSource.DataSource = typeof(SerialPlotter.Form1);
            // 
            // button16
            // 
            this.button16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button16.Location = new System.Drawing.Point(277, 286);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(46, 45);
            this.button16.TabIndex = 45;
            this.button16.Text = "0\r\n0.5";
            this.button16.UseVisualStyleBackColor = true;
            // 
            // button20
            // 
            this.button20.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button20.Location = new System.Drawing.Point(433, 235);
            this.button20.Name = "button20";
            this.button20.Size = new System.Drawing.Size(46, 45);
            this.button20.TabIndex = 49;
            this.button20.Text = "0.5\r\n-1";
            this.button20.UseVisualStyleBackColor = true;
            // 
            // button21
            // 
            this.button21.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button21.Location = new System.Drawing.Point(485, 235);
            this.button21.Name = "button21";
            this.button21.Size = new System.Drawing.Size(46, 45);
            this.button21.TabIndex = 50;
            this.button21.Text = "0.5\r\n-1.5";
            this.button21.UseVisualStyleBackColor = true;
            // 
            // button22
            // 
            this.button22.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button22.Location = new System.Drawing.Point(537, 235);
            this.button22.Name = "button22";
            this.button22.Size = new System.Drawing.Size(46, 45);
            this.button22.TabIndex = 51;
            this.button22.Text = "0.5\r\n-2";
            this.button22.UseVisualStyleBackColor = true;
            // 
            // button23
            // 
            this.button23.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button23.Location = new System.Drawing.Point(485, 286);
            this.button23.Name = "button23";
            this.button23.Size = new System.Drawing.Size(46, 45);
            this.button23.TabIndex = 52;
            this.button23.Text = "0\r\n-1.5";
            this.button23.UseVisualStyleBackColor = true;
            // 
            // button24
            // 
            this.button24.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button24.Location = new System.Drawing.Point(537, 286);
            this.button24.Name = "button24";
            this.button24.Size = new System.Drawing.Size(46, 45);
            this.button24.TabIndex = 53;
            this.button24.Text = "0\r\n-2";
            this.button24.UseVisualStyleBackColor = true;
            // 
            // button25
            // 
            this.button25.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button25.Location = new System.Drawing.Point(225, 286);
            this.button25.Name = "button25";
            this.button25.Size = new System.Drawing.Size(46, 45);
            this.button25.TabIndex = 54;
            this.button25.Text = "0\r\n1";
            this.button25.UseVisualStyleBackColor = true;
            // 
            // button26
            // 
            this.button26.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button26.Location = new System.Drawing.Point(173, 286);
            this.button26.Name = "button26";
            this.button26.Size = new System.Drawing.Size(46, 45);
            this.button26.TabIndex = 55;
            this.button26.Text = "0\r\n1.5";
            this.button26.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(277, 235);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(46, 45);
            this.button2.TabIndex = 56;
            this.button2.Text = "0.5\r\n0.5";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(121, 286);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(46, 45);
            this.button3.TabIndex = 57;
            this.button3.Text = "0\r\n2";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(225, 235);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(46, 45);
            this.button4.TabIndex = 58;
            this.button4.Text = "0.5\r\n-1";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(173, 235);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(46, 45);
            this.button5.TabIndex = 59;
            this.button5.Text = "0.5\r\n-1.5";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.Location = new System.Drawing.Point(121, 235);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(46, 45);
            this.button6.TabIndex = 60;
            this.button6.Text = "0.5\r\n-2";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button10
            // 
            this.button10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button10.Location = new System.Drawing.Point(173, 184);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(46, 45);
            this.button10.TabIndex = 61;
            this.button10.Text = "0\r\n1.5";
            this.button10.UseVisualStyleBackColor = true;
            // 
            // button12
            // 
            this.button12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button12.Location = new System.Drawing.Point(225, 184);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(46, 45);
            this.button12.TabIndex = 62;
            this.button12.Text = "0\r\n1";
            this.button12.UseVisualStyleBackColor = true;
            // 
            // button14
            // 
            this.button14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button14.Location = new System.Drawing.Point(277, 184);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(46, 45);
            this.button14.TabIndex = 63;
            this.button14.Text = "0\r\n0.5";
            this.button14.UseVisualStyleBackColor = true;
            // 
            // button17
            // 
            this.button17.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button17.Location = new System.Drawing.Point(121, 184);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(46, 45);
            this.button17.TabIndex = 64;
            this.button17.Text = "0\r\n2";
            this.button17.UseVisualStyleBackColor = true;
            // 
            // button18
            // 
            this.button18.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button18.Location = new System.Drawing.Point(173, 133);
            this.button18.Name = "button18";
            this.button18.Size = new System.Drawing.Size(46, 45);
            this.button18.TabIndex = 65;
            this.button18.Text = "0\r\n1.5";
            this.button18.UseVisualStyleBackColor = true;
            // 
            // button19
            // 
            this.button19.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button19.Location = new System.Drawing.Point(225, 133);
            this.button19.Name = "button19";
            this.button19.Size = new System.Drawing.Size(46, 45);
            this.button19.TabIndex = 66;
            this.button19.Text = "0\r\n1";
            this.button19.UseVisualStyleBackColor = true;
            // 
            // button27
            // 
            this.button27.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button27.Location = new System.Drawing.Point(277, 133);
            this.button27.Name = "button27";
            this.button27.Size = new System.Drawing.Size(46, 45);
            this.button27.TabIndex = 67;
            this.button27.Text = "0\r\n0.5";
            this.button27.UseVisualStyleBackColor = true;
            // 
            // button28
            // 
            this.button28.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button28.Location = new System.Drawing.Point(225, 82);
            this.button28.Name = "button28";
            this.button28.Size = new System.Drawing.Size(46, 45);
            this.button28.TabIndex = 68;
            this.button28.Text = "0\r\n1";
            this.button28.UseVisualStyleBackColor = true;
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
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.wheelVelPage.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.rightDirRadioPanel.ResumeLayout(false);
            this.rightDirRadioPanel.PerformLayout();
            this.leftDirRadioPanel.ResumeLayout(false);
            this.leftDirRadioPanel.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarRight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarLeft)).EndInit();
            this.targetCoordPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.form1BindingSource)).EndInit();
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
        private System.Windows.Forms.Button drive600;
        private System.Windows.Forms.RadioButton radioButtonBoth;
        private System.Windows.Forms.RadioButton radioButtonRight;
        private System.Windows.Forms.RadioButton radioButtonLeft;
        private System.Windows.Forms.TrackBar trackBarLeft;
        private System.Windows.Forms.Button brakeButton;
        private System.Windows.Forms.Button offButton2;
        private System.Windows.Forms.RadioButton revLeft;
        private System.Windows.Forms.RadioButton fwdLeft;
        private System.Windows.Forms.TrackBar trackBarRight;
        private System.Windows.Forms.Label rightSpeedDisplay;
        private System.Windows.Forms.Label leftSpeedDisplay;
        private System.Windows.Forms.Panel rightDirRadioPanel;
        private System.Windows.Forms.RadioButton fwdRight;
        private System.Windows.Forms.RadioButton revRight;
        private System.Windows.Forms.Panel leftDirRadioPanel;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label leftMeasured;
        private System.Windows.Forms.Label rightTarget;
        private System.Windows.Forms.Label leftTarget;
        private System.Windows.Forms.BindingSource form1BindingSource;
        private System.Windows.Forms.Label rightMeasured;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button offResetButton;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button28;
        private System.Windows.Forms.Button button27;
        private System.Windows.Forms.Button button19;
        private System.Windows.Forms.Button button18;
        private System.Windows.Forms.Button button17;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button26;
        private System.Windows.Forms.Button button25;
        private System.Windows.Forms.Button button24;
        private System.Windows.Forms.Button button23;
        private System.Windows.Forms.Button button22;
        private System.Windows.Forms.Button button21;
        private System.Windows.Forms.Button button20;
        private System.Windows.Forms.Button button16;
    }
}

