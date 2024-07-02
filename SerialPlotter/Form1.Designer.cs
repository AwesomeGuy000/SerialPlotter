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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
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
            this.clearGraph = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rightMeasured = new System.Windows.Forms.Label();
            this.rightTarget = new System.Windows.Forms.Label();
            this.leftTarget = new System.Windows.Forms.Label();
            this.leftMeasured = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.driveControls = new System.Windows.Forms.GroupBox();
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
            this.targetCoord = new System.Windows.Forms.TabPage();
            this.targetControls = new System.Windows.Forms.Panel();
            this.targetCoordLabel = new System.Windows.Forms.Label();
            this.targetOffButton = new System.Windows.Forms.Button();
            this.resetTarget = new System.Windows.Forms.Button();
            this.trackBarXTarget = new System.Windows.Forms.TrackBar();
            this.label6 = new System.Windows.Forms.Label();
            this.goButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.resetOdoButton = new System.Windows.Forms.Button();
            this.trackBarYTarget = new System.Windows.Forms.TrackBar();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.targVelRLabel = new System.Windows.Forms.Label();
            this.targVelLLabel = new System.Windows.Forms.Label();
            this.measuredHeading = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.measuredY = new System.Windows.Forms.Label();
            this.targetY = new System.Windows.Forms.Label();
            this.targetX = new System.Windows.Forms.Label();
            this.measuredX = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.wheelVelPage.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.driveControls.SuspendLayout();
            this.rightDirRadioPanel.SuspendLayout();
            this.leftDirRadioPanel.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarRight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarLeft)).BeginInit();
            this.targetCoord.SuspendLayout();
            this.targetControls.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarXTarget)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarYTarget)).BeginInit();
            this.groupBox4.SuspendLayout();
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
            this.writeInputTextBox.Location = new System.Drawing.Point(67, 2);
            this.writeInputTextBox.Name = "writeInputTextBox";
            this.writeInputTextBox.Size = new System.Drawing.Size(201, 20);
            this.writeInputTextBox.TabIndex = 9;
            this.writeInputTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.writeInputTextBox_KeyPress);
            // 
            // writeLabel
            // 
            this.writeLabel.AutoSize = true;
            this.writeLabel.Location = new System.Drawing.Point(3, 5);
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
            this.writeStatusLabel.Text = "Open a serial port to write data";
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
            this.tabControl1.Controls.Add(this.targetCoord);
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
            this.wheelVelPage.Controls.Add(this.driveControls);
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
            this.groupBox2.Controls.Add(this.clearGraph);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Controls.Add(this.chart1);
            this.groupBox2.Location = new System.Drawing.Point(4, 141);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(688, 195);
            this.groupBox2.TabIndex = 35;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Data Received";
            // 
            // clearGraph
            // 
            this.clearGraph.Location = new System.Drawing.Point(2, 167);
            this.clearGraph.Name = "clearGraph";
            this.clearGraph.Size = new System.Drawing.Size(43, 23);
            this.clearGraph.TabIndex = 5;
            this.clearGraph.Text = "CLR";
            this.clearGraph.UseVisualStyleBackColor = true;
            this.clearGraph.Click += new System.EventHandler(this.clearGraph_Click);
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
            this.groupBox3.Location = new System.Drawing.Point(534, 103);
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
            // chart1
            // 
            chartArea1.AxisX.Maximum = 250D;
            chartArea1.AxisX.ScaleBreakStyle.CollapsibleSpaceThreshold = 90;
            chartArea1.AxisX.ScaleBreakStyle.Enabled = true;
            chartArea1.AxisY.Maximum = 800D;
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(0, 19);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series1.Legend = "Legend1";
            series1.Name = "Measured Left";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series2.Legend = "Legend1";
            series2.Name = "Measured Right";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series3.Legend = "Legend1";
            series3.Name = "Target Left";
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series4.Legend = "Legend1";
            series4.Name = "Target Right";
            this.chart1.Series.Add(series1);
            this.chart1.Series.Add(series2);
            this.chart1.Series.Add(series3);
            this.chart1.Series.Add(series4);
            this.chart1.Size = new System.Drawing.Size(688, 177);
            this.chart1.TabIndex = 4;
            this.chart1.Text = "chart1";
            // 
            // driveControls
            // 
            this.driveControls.Controls.Add(this.offButton2);
            this.driveControls.Controls.Add(this.rightSpeedDisplay);
            this.driveControls.Controls.Add(this.drive500);
            this.driveControls.Controls.Add(this.leftSpeedDisplay);
            this.driveControls.Controls.Add(this.drive400);
            this.driveControls.Controls.Add(this.rightDirRadioPanel);
            this.driveControls.Controls.Add(this.drive300);
            this.driveControls.Controls.Add(this.leftDirRadioPanel);
            this.driveControls.Controls.Add(this.drive100);
            this.driveControls.Controls.Add(this.panel3);
            this.driveControls.Controls.Add(this.drive50);
            this.driveControls.Controls.Add(this.trackBarRight);
            this.driveControls.Controls.Add(this.drive200);
            this.driveControls.Controls.Add(this.trackBarLeft);
            this.driveControls.Controls.Add(this.drive600);
            this.driveControls.Controls.Add(this.brakeButton);
            this.driveControls.Location = new System.Drawing.Point(4, 6);
            this.driveControls.Name = "driveControls";
            this.driveControls.Size = new System.Drawing.Size(688, 129);
            this.driveControls.TabIndex = 34;
            this.driveControls.TabStop = false;
            this.driveControls.Text = "Preset Drive";
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
            this.trackBarRight.Maximum = 800;
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
            this.trackBarLeft.Maximum = 800;
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
            // targetCoord
            // 
            this.targetCoord.Controls.Add(this.targetControls);
            this.targetCoord.Location = new System.Drawing.Point(4, 22);
            this.targetCoord.Name = "targetCoord";
            this.targetCoord.Size = new System.Drawing.Size(698, 337);
            this.targetCoord.TabIndex = 2;
            this.targetCoord.Text = "Target Coordinate";
            this.targetCoord.UseVisualStyleBackColor = true;
            // 
            // targetControls
            // 
            this.targetControls.Controls.Add(this.targetCoordLabel);
            this.targetControls.Controls.Add(this.targetOffButton);
            this.targetControls.Controls.Add(this.resetTarget);
            this.targetControls.Controls.Add(this.trackBarXTarget);
            this.targetControls.Controls.Add(this.label6);
            this.targetControls.Controls.Add(this.goButton);
            this.targetControls.Controls.Add(this.label5);
            this.targetControls.Controls.Add(this.resetOdoButton);
            this.targetControls.Controls.Add(this.trackBarYTarget);
            this.targetControls.Controls.Add(this.groupBox4);
            this.targetControls.Location = new System.Drawing.Point(42, 3);
            this.targetControls.Name = "targetControls";
            this.targetControls.Size = new System.Drawing.Size(642, 318);
            this.targetControls.TabIndex = 15;
            // 
            // targetCoordLabel
            // 
            this.targetCoordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.targetCoordLabel.Location = new System.Drawing.Point(240, 63);
            this.targetCoordLabel.Name = "targetCoordLabel";
            this.targetCoordLabel.Size = new System.Drawing.Size(135, 30);
            this.targetCoordLabel.TabIndex = 103;
            this.targetCoordLabel.Text = "(0,0)";
            this.targetCoordLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // targetOffButton
            // 
            this.targetOffButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.targetOffButton.Location = new System.Drawing.Point(239, 140);
            this.targetOffButton.Name = "targetOffButton";
            this.targetOffButton.Size = new System.Drawing.Size(136, 73);
            this.targetOffButton.TabIndex = 102;
            this.targetOffButton.Text = "OFF";
            this.targetOffButton.UseVisualStyleBackColor = true;
            this.targetOffButton.Click += new System.EventHandler(this.targetOff_Click);
            // 
            // resetTarget
            // 
            this.resetTarget.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resetTarget.Location = new System.Drawing.Point(239, 253);
            this.resetTarget.Name = "resetTarget";
            this.resetTarget.Size = new System.Drawing.Size(136, 28);
            this.resetTarget.TabIndex = 101;
            this.resetTarget.Text = "Reset Target";
            this.resetTarget.UseVisualStyleBackColor = true;
            this.resetTarget.Click += new System.EventHandler(this.resetTarget_Click);
            // 
            // trackBarXTarget
            // 
            this.trackBarXTarget.BackColor = System.Drawing.SystemColors.Window;
            this.trackBarXTarget.Location = new System.Drawing.Point(86, 3);
            this.trackBarXTarget.Maximum = 200;
            this.trackBarXTarget.Minimum = -200;
            this.trackBarXTarget.Name = "trackBarXTarget";
            this.trackBarXTarget.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBarXTarget.Size = new System.Drawing.Size(45, 328);
            this.trackBarXTarget.TabIndex = 95;
            this.trackBarXTarget.TickFrequency = 25;
            this.trackBarXTarget.ValueChanged += new System.EventHandler(this.targetCoords_Changed);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(2, 161);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 13);
            this.label6.TabIndex = 100;
            this.label6.Text = "Target X Value";
            // 
            // goButton
            // 
            this.goButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.goButton.Location = new System.Drawing.Point(239, 99);
            this.goButton.Name = "goButton";
            this.goButton.Size = new System.Drawing.Size(136, 35);
            this.goButton.TabIndex = 96;
            this.goButton.Text = "Go";
            this.goButton.UseVisualStyleBackColor = true;
            this.goButton.Click += new System.EventHandler(this.goButton_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(499, 8);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 13);
            this.label5.TabIndex = 99;
            this.label5.Text = "Target Y Value";
            // 
            // resetOdoButton
            // 
            this.resetOdoButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resetOdoButton.Location = new System.Drawing.Point(239, 219);
            this.resetOdoButton.Name = "resetOdoButton";
            this.resetOdoButton.Size = new System.Drawing.Size(136, 28);
            this.resetOdoButton.TabIndex = 97;
            this.resetOdoButton.Text = "Reset Odometry";
            this.resetOdoButton.UseVisualStyleBackColor = true;
            this.resetOdoButton.Click += new System.EventHandler(this.resetOdoButton_Click);
            // 
            // trackBarYTarget
            // 
            this.trackBarYTarget.BackColor = System.Drawing.SystemColors.Window;
            this.trackBarYTarget.Location = new System.Drawing.Point(122, 3);
            this.trackBarYTarget.Maximum = 200;
            this.trackBarYTarget.Minimum = -200;
            this.trackBarYTarget.Name = "trackBarYTarget";
            this.trackBarYTarget.Size = new System.Drawing.Size(378, 45);
            this.trackBarYTarget.TabIndex = 94;
            this.trackBarYTarget.TickFrequency = 25;
            this.trackBarYTarget.ValueChanged += new System.EventHandler(this.targetCoords_Changed);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.targVelRLabel);
            this.groupBox4.Controls.Add(this.targVelLLabel);
            this.groupBox4.Controls.Add(this.measuredHeading);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.measuredY);
            this.groupBox4.Controls.Add(this.targetY);
            this.groupBox4.Controls.Add(this.targetX);
            this.groupBox4.Controls.Add(this.measuredX);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Controls.Add(this.label12);
            this.groupBox4.Location = new System.Drawing.Point(452, 208);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(173, 94);
            this.groupBox4.TabIndex = 98;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Data Received";
            // 
            // targVelRLabel
            // 
            this.targVelRLabel.Location = new System.Drawing.Point(134, 55);
            this.targVelRLabel.Name = "targVelRLabel";
            this.targVelRLabel.Size = new System.Drawing.Size(32, 13);
            this.targVelRLabel.TabIndex = 13;
            this.targVelRLabel.Text = "0";
            this.targVelRLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // targVelLLabel
            // 
            this.targVelLLabel.Location = new System.Drawing.Point(134, 36);
            this.targVelLLabel.Name = "targVelLLabel";
            this.targVelLLabel.Size = new System.Drawing.Size(32, 13);
            this.targVelLLabel.TabIndex = 12;
            this.targVelLLabel.Text = "0";
            this.targVelLLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // measuredHeading
            // 
            this.measuredHeading.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.measuredHeading.Location = new System.Drawing.Point(38, 75);
            this.measuredHeading.Name = "measuredHeading";
            this.measuredHeading.Size = new System.Drawing.Size(32, 13);
            this.measuredHeading.TabIndex = 11;
            this.measuredHeading.Text = "0";
            this.measuredHeading.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(13, 74);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(13, 13);
            this.label8.TabIndex = 10;
            this.label8.Text = "h";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(134, 18);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(32, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "Drive";
            // 
            // measuredY
            // 
            this.measuredY.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.measuredY.Location = new System.Drawing.Point(38, 55);
            this.measuredY.Name = "measuredY";
            this.measuredY.Size = new System.Drawing.Size(32, 13);
            this.measuredY.TabIndex = 8;
            this.measuredY.Text = "0";
            this.measuredY.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // targetY
            // 
            this.targetY.Location = new System.Drawing.Point(89, 55);
            this.targetY.Name = "targetY";
            this.targetY.Size = new System.Drawing.Size(32, 13);
            this.targetY.TabIndex = 7;
            this.targetY.Text = "0";
            this.targetY.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // targetX
            // 
            this.targetX.Location = new System.Drawing.Point(89, 36);
            this.targetX.Name = "targetX";
            this.targetX.Size = new System.Drawing.Size(32, 13);
            this.targetX.TabIndex = 6;
            this.targetX.Text = "0";
            this.targetX.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // measuredX
            // 
            this.measuredX.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.measuredX.Location = new System.Drawing.Point(38, 36);
            this.measuredX.Name = "measuredX";
            this.measuredX.Size = new System.Drawing.Size(32, 13);
            this.measuredX.TabIndex = 4;
            this.measuredX.Text = "0";
            this.measuredX.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(29, 18);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(54, 13);
            this.label9.TabIndex = 3;
            this.label9.Text = "Measured";
            this.label9.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(86, 18);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(38, 13);
            this.label10.TabIndex = 2;
            this.label10.Text = "Target";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(13, 54);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(12, 13);
            this.label11.TabIndex = 1;
            this.label11.Text = "y";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(13, 35);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(12, 13);
            this.label12.TabIndex = 0;
            this.label12.Text = "x";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(726, 490);
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
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Serial Utility";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.formClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.wheelVelPage.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.driveControls.ResumeLayout(false);
            this.driveControls.PerformLayout();
            this.rightDirRadioPanel.ResumeLayout(false);
            this.rightDirRadioPanel.PerformLayout();
            this.leftDirRadioPanel.ResumeLayout(false);
            this.leftDirRadioPanel.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarRight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarLeft)).EndInit();
            this.targetCoord.ResumeLayout(false);
            this.targetControls.ResumeLayout(false);
            this.targetControls.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarXTarget)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarYTarget)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
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
        private System.Windows.Forms.GroupBox driveControls;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label leftMeasured;
        private System.Windows.Forms.Label rightTarget;
        private System.Windows.Forms.Label leftTarget;
        private System.Windows.Forms.Label rightMeasured;
        private System.Windows.Forms.TabPage targetCoord;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label measuredY;
        private System.Windows.Forms.Label targetY;
        private System.Windows.Forms.Label targetX;
        private System.Windows.Forms.Label measuredX;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button resetOdoButton;
        private System.Windows.Forms.Button goButton;
        private System.Windows.Forms.TrackBar trackBarXTarget;
        private System.Windows.Forms.TrackBar trackBarYTarget;
        private System.Windows.Forms.Button resetTarget;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Button targetOffButton;
        private System.Windows.Forms.Button clearGraph;
        private System.Windows.Forms.Label targVelRLabel;
        private System.Windows.Forms.Label targVelLLabel;
        private System.Windows.Forms.Label measuredHeading;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel targetControls;
        private System.Windows.Forms.Label targetCoordLabel;
    }
}

