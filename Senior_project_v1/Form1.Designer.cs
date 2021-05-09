namespace Senior_project_v1
{
    partial class BackGroundForm
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
            this.ComboBoxCOMPORT = new System.Windows.Forms.GroupBox();
            this.CheckBoxRTS = new System.Windows.Forms.CheckBox();
            this.CheckBoxDTR = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ComboBoxParityBit = new System.Windows.Forms.ComboBox();
            this.ComboBoxStopBit = new System.Windows.Forms.ComboBox();
            this.ComboBoxDataBit = new System.Windows.Forms.ComboBox();
            this.ComboBoxBaudRate = new System.Windows.Forms.ComboBox();
            this.ComboBoxPortNum = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.LabelStatus = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.ButtonClose = new System.Windows.Forms.Button();
            this.ButtonOpen = new System.Windows.Forms.Button();
            this.ButtonSendData = new System.Windows.Forms.Button();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.TextBoxDataOut = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.CheckBoxUseButton = new System.Windows.Forms.CheckBox();
            this.CheckBoxUseEnter = new System.Windows.Forms.CheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.CheckBoxWriteLine = new System.Windows.Forms.CheckBox();
            this.CheckBoxWrite = new System.Windows.Forms.CheckBox();
            this.ButtonClearOutput = new System.Windows.Forms.Button();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.TextBoxDataIn = new System.Windows.Forms.TextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.CheckBoxAlwaysUpdate = new System.Windows.Forms.CheckBox();
            this.CheckBoxAddToOldData = new System.Windows.Forms.CheckBox();
            this.ButtonClearInput = new System.Windows.Forms.Button();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.TextBoxRegisterAddress = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.TextBoxByteValue = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.TextBoxSlaveAddress = new System.Windows.Forms.TextBox();
            this.TextBoxNumberOfByte = new System.Windows.Forms.TextBox();
            this.ButtonI2CWrite = new System.Windows.Forms.Button();
            this.ButtonI2CRead = new System.Windows.Forms.Button();
            this.progressBarWrite = new System.Windows.Forms.ProgressBar();
            this.progressBarRead = new System.Windows.Forms.ProgressBar();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.ButtonSPIRead = new System.Windows.Forms.Button();
            this.TextBoxRegisterAddress2 = new System.Windows.Forms.TextBox();
            this.ButtonSPIWrite = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.TextBoxNumberOfByteSPI = new System.Windows.Forms.TextBox();
            this.TextBoxByteValueSPI = new System.Windows.Forms.TextBox();
            this.TextBoxOPCode = new System.Windows.Forms.TextBox();
            this.OPCode = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.progressBarSPIwrite = new System.Windows.Forms.ProgressBar();
            this.progressBarSPIread = new System.Windows.Forms.ProgressBar();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.groupBox12 = new System.Windows.Forms.GroupBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.ButtonAddWriteSPI = new System.Windows.Forms.Button();
            this.ButtonAddReadSPI = new System.Windows.Forms.Button();
            this.groupBox11 = new System.Windows.Forms.GroupBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.ButtonAddWriteI2C = new System.Windows.Forms.Button();
            this.ButtonAddReadI2C = new System.Windows.Forms.Button();
            this.ButtonClearGrid = new System.Windows.Forms.Button();
            this.groupBox10 = new System.Windows.Forms.GroupBox();
            this.ComboBoxCOMPORT.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox9.SuspendLayout();
            this.groupBox12.SuspendLayout();
            this.groupBox11.SuspendLayout();
            this.groupBox10.SuspendLayout();
            this.SuspendLayout();
            // 
            // ComboBoxCOMPORT
            // 
            this.ComboBoxCOMPORT.Controls.Add(this.CheckBoxRTS);
            this.ComboBoxCOMPORT.Controls.Add(this.CheckBoxDTR);
            this.ComboBoxCOMPORT.Controls.Add(this.label5);
            this.ComboBoxCOMPORT.Controls.Add(this.label4);
            this.ComboBoxCOMPORT.Controls.Add(this.label3);
            this.ComboBoxCOMPORT.Controls.Add(this.label2);
            this.ComboBoxCOMPORT.Controls.Add(this.label1);
            this.ComboBoxCOMPORT.Controls.Add(this.ComboBoxParityBit);
            this.ComboBoxCOMPORT.Controls.Add(this.ComboBoxStopBit);
            this.ComboBoxCOMPORT.Controls.Add(this.ComboBoxDataBit);
            this.ComboBoxCOMPORT.Controls.Add(this.ComboBoxBaudRate);
            this.ComboBoxCOMPORT.Controls.Add(this.ComboBoxPortNum);
            this.ComboBoxCOMPORT.Location = new System.Drawing.Point(21, 22);
            this.ComboBoxCOMPORT.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ComboBoxCOMPORT.Name = "ComboBoxCOMPORT";
            this.ComboBoxCOMPORT.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ComboBoxCOMPORT.Size = new System.Drawing.Size(281, 262);
            this.ComboBoxCOMPORT.TabIndex = 0;
            this.ComboBoxCOMPORT.TabStop = false;
            this.ComboBoxCOMPORT.Text = "COM Port Control";
            // 
            // CheckBoxRTS
            // 
            this.CheckBoxRTS.AutoSize = true;
            this.CheckBoxRTS.Location = new System.Drawing.Point(119, 232);
            this.CheckBoxRTS.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CheckBoxRTS.Name = "CheckBoxRTS";
            this.CheckBoxRTS.Size = new System.Drawing.Size(67, 24);
            this.CheckBoxRTS.TabIndex = 11;
            this.CheckBoxRTS.Text = "RTS";
            this.CheckBoxRTS.UseVisualStyleBackColor = true;
            this.CheckBoxRTS.CheckedChanged += new System.EventHandler(this.CheckBoxRTS_CheckedChanged);
            // 
            // CheckBoxDTR
            // 
            this.CheckBoxDTR.AutoSize = true;
            this.CheckBoxDTR.Location = new System.Drawing.Point(29, 232);
            this.CheckBoxDTR.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CheckBoxDTR.Name = "CheckBoxDTR";
            this.CheckBoxDTR.Size = new System.Drawing.Size(68, 24);
            this.CheckBoxDTR.TabIndex = 10;
            this.CheckBoxDTR.Text = "DTR";
            this.CheckBoxDTR.UseVisualStyleBackColor = true;
            this.CheckBoxDTR.CheckedChanged += new System.EventHandler(this.CheckBoxDTR_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 196);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Parity bit ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 154);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Stop Bit ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 112);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Data Bits";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 71);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Baud Rate";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 30);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "COM Port ";
            // 
            // ComboBoxParityBit
            // 
            this.ComboBoxParityBit.FormattingEnabled = true;
            this.ComboBoxParityBit.Items.AddRange(new object[] {
            "Odd ",
            "Even ",
            "None"});
            this.ComboBoxParityBit.Location = new System.Drawing.Point(118, 188);
            this.ComboBoxParityBit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ComboBoxParityBit.Name = "ComboBoxParityBit";
            this.ComboBoxParityBit.Size = new System.Drawing.Size(145, 28);
            this.ComboBoxParityBit.TabIndex = 4;
            this.ComboBoxParityBit.Text = "None";
            // 
            // ComboBoxStopBit
            // 
            this.ComboBoxStopBit.FormattingEnabled = true;
            this.ComboBoxStopBit.Items.AddRange(new object[] {
            "One",
            "Two"});
            this.ComboBoxStopBit.Location = new System.Drawing.Point(118, 146);
            this.ComboBoxStopBit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ComboBoxStopBit.Name = "ComboBoxStopBit";
            this.ComboBoxStopBit.Size = new System.Drawing.Size(145, 28);
            this.ComboBoxStopBit.TabIndex = 3;
            this.ComboBoxStopBit.Text = "One";
            // 
            // ComboBoxDataBit
            // 
            this.ComboBoxDataBit.FormattingEnabled = true;
            this.ComboBoxDataBit.Items.AddRange(new object[] {
            "6",
            "7",
            "8"});
            this.ComboBoxDataBit.Location = new System.Drawing.Point(118, 105);
            this.ComboBoxDataBit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ComboBoxDataBit.Name = "ComboBoxDataBit";
            this.ComboBoxDataBit.Size = new System.Drawing.Size(145, 28);
            this.ComboBoxDataBit.TabIndex = 2;
            this.ComboBoxDataBit.Text = "8";
            // 
            // ComboBoxBaudRate
            // 
            this.ComboBoxBaudRate.FormattingEnabled = true;
            this.ComboBoxBaudRate.Items.AddRange(new object[] {
            "1200",
            "2400",
            "4800",
            "9600",
            "14400",
            "19200",
            "38400",
            "57600",
            "115200",
            "128000",
            "256000"});
            this.ComboBoxBaudRate.Location = new System.Drawing.Point(118, 62);
            this.ComboBoxBaudRate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ComboBoxBaudRate.Name = "ComboBoxBaudRate";
            this.ComboBoxBaudRate.Size = new System.Drawing.Size(145, 28);
            this.ComboBoxBaudRate.TabIndex = 1;
            this.ComboBoxBaudRate.Text = "115200";
            // 
            // ComboBoxPortNum
            // 
            this.ComboBoxPortNum.FormattingEnabled = true;
            this.ComboBoxPortNum.Location = new System.Drawing.Point(118, 21);
            this.ComboBoxPortNum.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ComboBoxPortNum.Name = "ComboBoxPortNum";
            this.ComboBoxPortNum.Size = new System.Drawing.Size(145, 28);
            this.ComboBoxPortNum.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.LabelStatus);
            this.groupBox1.Controls.Add(this.progressBar1);
            this.groupBox1.Controls.Add(this.ButtonClose);
            this.groupBox1.Controls.Add(this.ButtonOpen);
            this.groupBox1.Location = new System.Drawing.Point(21, 296);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(281, 142);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Status ";
            // 
            // LabelStatus
            // 
            this.LabelStatus.AutoSize = true;
            this.LabelStatus.Font = new System.Drawing.Font("FMBF Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelStatus.Location = new System.Drawing.Point(114, 102);
            this.LabelStatus.Name = "LabelStatus";
            this.LabelStatus.Size = new System.Drawing.Size(59, 30);
            this.LabelStatus.TabIndex = 4;
            this.LabelStatus.Text = "OFF";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(9, 74);
            this.progressBar1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(261, 22);
            this.progressBar1.TabIndex = 3;
            // 
            // ButtonClose
            // 
            this.ButtonClose.Location = new System.Drawing.Point(144, 29);
            this.ButtonClose.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ButtonClose.Name = "ButtonClose";
            this.ButtonClose.Size = new System.Drawing.Size(126, 35);
            this.ButtonClose.TabIndex = 2;
            this.ButtonClose.Text = "Close";
            this.ButtonClose.UseVisualStyleBackColor = true;
            this.ButtonClose.Click += new System.EventHandler(this.ButtonClose_Click);
            // 
            // ButtonOpen
            // 
            this.ButtonOpen.Location = new System.Drawing.Point(9, 29);
            this.ButtonOpen.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ButtonOpen.Name = "ButtonOpen";
            this.ButtonOpen.Size = new System.Drawing.Size(126, 35);
            this.ButtonOpen.TabIndex = 1;
            this.ButtonOpen.Text = "Open ";
            this.ButtonOpen.UseVisualStyleBackColor = true;
            this.ButtonOpen.Click += new System.EventHandler(this.ButtonOpen_Click);
            // 
            // ButtonSendData
            // 
            this.ButtonSendData.Location = new System.Drawing.Point(8, 330);
            this.ButtonSendData.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ButtonSendData.Name = "ButtonSendData";
            this.ButtonSendData.Size = new System.Drawing.Size(122, 38);
            this.ButtonSendData.TabIndex = 2;
            this.ButtonSendData.Text = "Send Data";
            this.ButtonSendData.UseVisualStyleBackColor = true;
            this.ButtonSendData.Click += new System.EventHandler(this.ButtonSendData_Click);
            // 
            // serialPort1
            // 
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // TextBoxDataOut
            // 
            this.TextBoxDataOut.Location = new System.Drawing.Point(6, 28);
            this.TextBoxDataOut.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TextBoxDataOut.Multiline = true;
            this.TextBoxDataOut.Name = "TextBoxDataOut";
            this.TextBoxDataOut.Size = new System.Drawing.Size(407, 286);
            this.TextBoxDataOut.TabIndex = 3;
            this.TextBoxDataOut.TextChanged += new System.EventHandler(this.TextBoxDataOut_TextChanged);
            this.TextBoxDataOut.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextBoxDataOut_KeyDown);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.groupBox4);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Controls.Add(this.ButtonClearOutput);
            this.groupBox2.Controls.Add(this.TextBoxDataOut);
            this.groupBox2.Controls.Add(this.ButtonSendData);
            this.groupBox2.Location = new System.Drawing.Point(318, 22);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(426, 416);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Output";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.CheckBoxUseButton);
            this.groupBox4.Controls.Add(this.CheckBoxUseEnter);
            this.groupBox4.Location = new System.Drawing.Point(289, 321);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox4.Size = new System.Drawing.Size(127, 84);
            this.groupBox4.TabIndex = 9;
            this.groupBox4.TabStop = false;
            // 
            // CheckBoxUseButton
            // 
            this.CheckBoxUseButton.AutoSize = true;
            this.CheckBoxUseButton.Location = new System.Drawing.Point(6, 15);
            this.CheckBoxUseButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CheckBoxUseButton.Name = "CheckBoxUseButton";
            this.CheckBoxUseButton.Size = new System.Drawing.Size(116, 24);
            this.CheckBoxUseButton.TabIndex = 5;
            this.CheckBoxUseButton.Text = "Use Button";
            this.CheckBoxUseButton.UseVisualStyleBackColor = true;
            this.CheckBoxUseButton.CheckedChanged += new System.EventHandler(this.CheckBoxUseButton_CheckedChanged);
            // 
            // CheckBoxUseEnter
            // 
            this.CheckBoxUseEnter.AutoSize = true;
            this.CheckBoxUseEnter.Location = new System.Drawing.Point(6, 45);
            this.CheckBoxUseEnter.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CheckBoxUseEnter.Name = "CheckBoxUseEnter";
            this.CheckBoxUseEnter.Size = new System.Drawing.Size(107, 24);
            this.CheckBoxUseEnter.TabIndex = 5;
            this.CheckBoxUseEnter.Text = "Use Enter";
            this.CheckBoxUseEnter.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.CheckBoxWriteLine);
            this.groupBox3.Controls.Add(this.CheckBoxWrite);
            this.groupBox3.Location = new System.Drawing.Point(145, 321);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Size = new System.Drawing.Size(127, 84);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            // 
            // CheckBoxWriteLine
            // 
            this.CheckBoxWriteLine.AutoSize = true;
            this.CheckBoxWriteLine.Location = new System.Drawing.Point(6, 15);
            this.CheckBoxWriteLine.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CheckBoxWriteLine.Name = "CheckBoxWriteLine";
            this.CheckBoxWriteLine.Size = new System.Drawing.Size(106, 24);
            this.CheckBoxWriteLine.TabIndex = 6;
            this.CheckBoxWriteLine.Text = "Write Line";
            this.CheckBoxWriteLine.UseVisualStyleBackColor = true;
            // 
            // CheckBoxWrite
            // 
            this.CheckBoxWrite.AutoSize = true;
            this.CheckBoxWrite.Location = new System.Drawing.Point(6, 49);
            this.CheckBoxWrite.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CheckBoxWrite.Name = "CheckBoxWrite";
            this.CheckBoxWrite.Size = new System.Drawing.Size(72, 24);
            this.CheckBoxWrite.TabIndex = 7;
            this.CheckBoxWrite.Text = "Write";
            this.CheckBoxWrite.UseVisualStyleBackColor = true;
            // 
            // ButtonClearOutput
            // 
            this.ButtonClearOutput.Location = new System.Drawing.Point(9, 370);
            this.ButtonClearOutput.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ButtonClearOutput.Name = "ButtonClearOutput";
            this.ButtonClearOutput.Size = new System.Drawing.Size(122, 35);
            this.ButtonClearOutput.TabIndex = 4;
            this.ButtonClearOutput.Text = "Clear Output";
            this.ButtonClearOutput.UseVisualStyleBackColor = true;
            this.ButtonClearOutput.Click += new System.EventHandler(this.ButtonClearOutput_Click);
            // 
            // TextBoxDataIn
            // 
            this.TextBoxDataIn.Location = new System.Drawing.Point(7, 28);
            this.TextBoxDataIn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TextBoxDataIn.Multiline = true;
            this.TextBoxDataIn.Name = "TextBoxDataIn";
            this.TextBoxDataIn.Size = new System.Drawing.Size(407, 286);
            this.TextBoxDataIn.TabIndex = 5;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.groupBox6);
            this.groupBox5.Controls.Add(this.ButtonClearInput);
            this.groupBox5.Controls.Add(this.TextBoxDataIn);
            this.groupBox5.Location = new System.Drawing.Point(762, 22);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox5.Size = new System.Drawing.Size(425, 416);
            this.groupBox5.TabIndex = 6;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Input";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.CheckBoxAlwaysUpdate);
            this.groupBox6.Controls.Add(this.CheckBoxAddToOldData);
            this.groupBox6.Location = new System.Drawing.Point(117, 321);
            this.groupBox6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox6.Size = new System.Drawing.Size(184, 84);
            this.groupBox6.TabIndex = 9;
            this.groupBox6.TabStop = false;
            // 
            // CheckBoxAlwaysUpdate
            // 
            this.CheckBoxAlwaysUpdate.AutoSize = true;
            this.CheckBoxAlwaysUpdate.Location = new System.Drawing.Point(6, 15);
            this.CheckBoxAlwaysUpdate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CheckBoxAlwaysUpdate.Name = "CheckBoxAlwaysUpdate";
            this.CheckBoxAlwaysUpdate.Size = new System.Drawing.Size(141, 24);
            this.CheckBoxAlwaysUpdate.TabIndex = 6;
            this.CheckBoxAlwaysUpdate.Text = "Always Update";
            this.CheckBoxAlwaysUpdate.UseVisualStyleBackColor = true;
            this.CheckBoxAlwaysUpdate.CheckedChanged += new System.EventHandler(this.CheckBoxAlwaysUpdate_CheckedChanged);
            // 
            // CheckBoxAddToOldData
            // 
            this.CheckBoxAddToOldData.AutoSize = true;
            this.CheckBoxAddToOldData.Location = new System.Drawing.Point(6, 49);
            this.CheckBoxAddToOldData.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CheckBoxAddToOldData.Name = "CheckBoxAddToOldData";
            this.CheckBoxAddToOldData.Size = new System.Drawing.Size(146, 24);
            this.CheckBoxAddToOldData.TabIndex = 7;
            this.CheckBoxAddToOldData.Text = "Add to Old data";
            this.CheckBoxAddToOldData.UseVisualStyleBackColor = true;
            this.CheckBoxAddToOldData.CheckedChanged += new System.EventHandler(this.CheckBoxAddToOldData_CheckedChanged);
            // 
            // ButtonClearInput
            // 
            this.ButtonClearInput.Location = new System.Drawing.Point(7, 330);
            this.ButtonClearInput.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ButtonClearInput.Name = "ButtonClearInput";
            this.ButtonClearInput.Size = new System.Drawing.Size(92, 75);
            this.ButtonClearInput.TabIndex = 6;
            this.ButtonClearInput.Text = "Clear Input ";
            this.ButtonClearInput.UseVisualStyleBackColor = true;
            this.ButtonClearInput.Click += new System.EventHandler(this.ButtonClearInput_Click);
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.label8);
            this.groupBox7.Controls.Add(this.TextBoxRegisterAddress);
            this.groupBox7.Controls.Add(this.label7);
            this.groupBox7.Controls.Add(this.TextBoxByteValue);
            this.groupBox7.Controls.Add(this.label9);
            this.groupBox7.Controls.Add(this.label6);
            this.groupBox7.Controls.Add(this.TextBoxSlaveAddress);
            this.groupBox7.Controls.Add(this.TextBoxNumberOfByte);
            this.groupBox7.Controls.Add(this.ButtonI2CWrite);
            this.groupBox7.Controls.Add(this.ButtonI2CRead);
            this.groupBox7.Location = new System.Drawing.Point(21, 448);
            this.groupBox7.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox7.Size = new System.Drawing.Size(281, 202);
            this.groupBox7.TabIndex = 7;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "I2C";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(140, 130);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(132, 20);
            this.label8.TabIndex = 14;
            this.label8.Text = "Register Address";
            // 
            // TextBoxRegisterAddress
            // 
            this.TextBoxRegisterAddress.Location = new System.Drawing.Point(144, 152);
            this.TextBoxRegisterAddress.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TextBoxRegisterAddress.Name = "TextBoxRegisterAddress";
            this.TextBoxRegisterAddress.Size = new System.Drawing.Size(119, 26);
            this.TextBoxRegisterAddress.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(152, 68);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 20);
            this.label7.TabIndex = 8;
            this.label7.Text = "Byte Value";
            // 
            // TextBoxByteValue
            // 
            this.TextBoxByteValue.Location = new System.Drawing.Point(144, 91);
            this.TextBoxByteValue.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TextBoxByteValue.Name = "TextBoxByteValue";
            this.TextBoxByteValue.Size = new System.Drawing.Size(119, 26);
            this.TextBoxByteValue.TabIndex = 3;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 130);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(111, 20);
            this.label9.TabIndex = 13;
            this.label9.Text = "Slave Address";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 68);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(119, 20);
            this.label6.TabIndex = 4;
            this.label6.Text = "Number of Byte";
            // 
            // TextBoxSlaveAddress
            // 
            this.TextBoxSlaveAddress.Location = new System.Drawing.Point(9, 152);
            this.TextBoxSlaveAddress.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TextBoxSlaveAddress.Name = "TextBoxSlaveAddress";
            this.TextBoxSlaveAddress.Size = new System.Drawing.Size(126, 26);
            this.TextBoxSlaveAddress.TabIndex = 11;
            // 
            // TextBoxNumberOfByte
            // 
            this.TextBoxNumberOfByte.Location = new System.Drawing.Point(9, 91);
            this.TextBoxNumberOfByte.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TextBoxNumberOfByte.Name = "TextBoxNumberOfByte";
            this.TextBoxNumberOfByte.Size = new System.Drawing.Size(126, 26);
            this.TextBoxNumberOfByte.TabIndex = 2;
            // 
            // ButtonI2CWrite
            // 
            this.ButtonI2CWrite.Location = new System.Drawing.Point(144, 25);
            this.ButtonI2CWrite.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ButtonI2CWrite.Name = "ButtonI2CWrite";
            this.ButtonI2CWrite.Size = new System.Drawing.Size(119, 38);
            this.ButtonI2CWrite.TabIndex = 1;
            this.ButtonI2CWrite.Text = "Write";
            this.ButtonI2CWrite.UseVisualStyleBackColor = true;
            this.ButtonI2CWrite.Click += new System.EventHandler(this.ButtonI2CWrite_Click);
            // 
            // ButtonI2CRead
            // 
            this.ButtonI2CRead.Location = new System.Drawing.Point(9, 25);
            this.ButtonI2CRead.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ButtonI2CRead.Name = "ButtonI2CRead";
            this.ButtonI2CRead.Size = new System.Drawing.Size(126, 38);
            this.ButtonI2CRead.TabIndex = 0;
            this.ButtonI2CRead.Text = "Read";
            this.ButtonI2CRead.UseVisualStyleBackColor = true;
            this.ButtonI2CRead.Click += new System.EventHandler(this.ButtonI2CRead_Click);
            // 
            // progressBarWrite
            // 
            this.progressBarWrite.Location = new System.Drawing.Point(114, 115);
            this.progressBarWrite.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.progressBarWrite.Name = "progressBarWrite";
            this.progressBarWrite.Size = new System.Drawing.Size(66, 37);
            this.progressBarWrite.TabIndex = 10;
            // 
            // progressBarRead
            // 
            this.progressBarRead.Location = new System.Drawing.Point(114, 43);
            this.progressBarRead.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.progressBarRead.Name = "progressBarRead";
            this.progressBarRead.Size = new System.Drawing.Size(66, 37);
            this.progressBarRead.TabIndex = 9;
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.label10);
            this.groupBox8.Controls.Add(this.ButtonSPIRead);
            this.groupBox8.Controls.Add(this.TextBoxRegisterAddress2);
            this.groupBox8.Controls.Add(this.ButtonSPIWrite);
            this.groupBox8.Controls.Add(this.label11);
            this.groupBox8.Controls.Add(this.TextBoxNumberOfByteSPI);
            this.groupBox8.Controls.Add(this.TextBoxByteValueSPI);
            this.groupBox8.Controls.Add(this.TextBoxOPCode);
            this.groupBox8.Controls.Add(this.OPCode);
            this.groupBox8.Controls.Add(this.label13);
            this.groupBox8.Location = new System.Drawing.Point(21, 664);
            this.groupBox8.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox8.Size = new System.Drawing.Size(281, 187);
            this.groupBox8.TabIndex = 8;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "SPI";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(141, 130);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(132, 20);
            this.label10.TabIndex = 24;
            this.label10.Text = "Register Address";
            // 
            // ButtonSPIRead
            // 
            this.ButtonSPIRead.Location = new System.Drawing.Point(10, 25);
            this.ButtonSPIRead.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ButtonSPIRead.Name = "ButtonSPIRead";
            this.ButtonSPIRead.Size = new System.Drawing.Size(126, 38);
            this.ButtonSPIRead.TabIndex = 15;
            this.ButtonSPIRead.Text = "Read";
            this.ButtonSPIRead.UseVisualStyleBackColor = true;
            this.ButtonSPIRead.Click += new System.EventHandler(this.ButtonSPIRead_Click);
            // 
            // TextBoxRegisterAddress2
            // 
            this.TextBoxRegisterAddress2.Location = new System.Drawing.Point(145, 152);
            this.TextBoxRegisterAddress2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TextBoxRegisterAddress2.Name = "TextBoxRegisterAddress2";
            this.TextBoxRegisterAddress2.Size = new System.Drawing.Size(119, 26);
            this.TextBoxRegisterAddress2.TabIndex = 22;
            // 
            // ButtonSPIWrite
            // 
            this.ButtonSPIWrite.Location = new System.Drawing.Point(145, 25);
            this.ButtonSPIWrite.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ButtonSPIWrite.Name = "ButtonSPIWrite";
            this.ButtonSPIWrite.Size = new System.Drawing.Size(119, 38);
            this.ButtonSPIWrite.TabIndex = 16;
            this.ButtonSPIWrite.Text = "Write";
            this.ButtonSPIWrite.UseVisualStyleBackColor = true;
            this.ButtonSPIWrite.Click += new System.EventHandler(this.ButtonSPIWrite_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(153, 68);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(86, 20);
            this.label11.TabIndex = 20;
            this.label11.Text = "Byte Value";
            // 
            // TextBoxNumberOfByteSPI
            // 
            this.TextBoxNumberOfByteSPI.Location = new System.Drawing.Point(10, 91);
            this.TextBoxNumberOfByteSPI.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TextBoxNumberOfByteSPI.Name = "TextBoxNumberOfByteSPI";
            this.TextBoxNumberOfByteSPI.Size = new System.Drawing.Size(126, 26);
            this.TextBoxNumberOfByteSPI.TabIndex = 17;
            // 
            // TextBoxByteValueSPI
            // 
            this.TextBoxByteValueSPI.Location = new System.Drawing.Point(145, 91);
            this.TextBoxByteValueSPI.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TextBoxByteValueSPI.Name = "TextBoxByteValueSPI";
            this.TextBoxByteValueSPI.Size = new System.Drawing.Size(119, 26);
            this.TextBoxByteValueSPI.TabIndex = 18;
            // 
            // TextBoxOPCode
            // 
            this.TextBoxOPCode.Location = new System.Drawing.Point(10, 152);
            this.TextBoxOPCode.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TextBoxOPCode.Name = "TextBoxOPCode";
            this.TextBoxOPCode.Size = new System.Drawing.Size(126, 26);
            this.TextBoxOPCode.TabIndex = 21;
            // 
            // OPCode
            // 
            this.OPCode.AutoSize = true;
            this.OPCode.Location = new System.Drawing.Point(7, 130);
            this.OPCode.Name = "OPCode";
            this.OPCode.Size = new System.Drawing.Size(73, 20);
            this.OPCode.TabIndex = 23;
            this.OPCode.Text = "OP Code";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(7, 68);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(119, 20);
            this.label13.TabIndex = 19;
            this.label13.Text = "Number of Byte";
            // 
            // progressBarSPIwrite
            // 
            this.progressBarSPIwrite.Location = new System.Drawing.Point(114, 115);
            this.progressBarSPIwrite.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.progressBarSPIwrite.Name = "progressBarSPIwrite";
            this.progressBarSPIwrite.Size = new System.Drawing.Size(64, 37);
            this.progressBarSPIwrite.TabIndex = 26;
            // 
            // progressBarSPIread
            // 
            this.progressBarSPIread.Location = new System.Drawing.Point(114, 43);
            this.progressBarSPIread.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.progressBarSPIread.Name = "progressBarSPIread";
            this.progressBarSPIread.Size = new System.Drawing.Size(66, 37);
            this.progressBarSPIread.TabIndex = 25;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dataGridView1.Location = new System.Drawing.Point(13, 25);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(645, 441);
            this.dataGridView1.TabIndex = 9;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Action";
            this.Column1.MinimumWidth = 8;
            this.Column1.Name = "Column1";
            this.Column1.Width = 150;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Address";
            this.Column2.MinimumWidth = 8;
            this.Column2.Name = "Column2";
            this.Column2.Width = 150;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Value";
            this.Column3.MinimumWidth = 8;
            this.Column3.Name = "Column3";
            this.Column3.Width = 150;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Status";
            this.Column4.MinimumWidth = 8;
            this.Column4.Name = "Column4";
            this.Column4.Width = 150;
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.groupBox12);
            this.groupBox9.Controls.Add(this.groupBox11);
            this.groupBox9.Controls.Add(this.ButtonClearGrid);
            this.groupBox9.Location = new System.Drawing.Point(308, 448);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(204, 489);
            this.groupBox9.TabIndex = 15;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "Data Grid Control";
            // 
            // groupBox12
            // 
            this.groupBox12.Controls.Add(this.progressBarSPIwrite);
            this.groupBox12.Controls.Add(this.label15);
            this.groupBox12.Controls.Add(this.progressBarSPIread);
            this.groupBox12.Controls.Add(this.label16);
            this.groupBox12.Controls.Add(this.ButtonAddWriteSPI);
            this.groupBox12.Controls.Add(this.ButtonAddReadSPI);
            this.groupBox12.Location = new System.Drawing.Point(10, 216);
            this.groupBox12.Name = "groupBox12";
            this.groupBox12.Size = new System.Drawing.Size(188, 178);
            this.groupBox12.TabIndex = 4;
            this.groupBox12.TabStop = false;
            this.groupBox12.Text = "SPI";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(118, 93);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(46, 20);
            this.label15.TabIndex = 11;
            this.label15.Text = "Write";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(118, 21);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(48, 20);
            this.label16.TabIndex = 10;
            this.label16.Text = "Read";
            // 
            // ButtonAddWriteSPI
            // 
            this.ButtonAddWriteSPI.Location = new System.Drawing.Point(6, 115);
            this.ButtonAddWriteSPI.Name = "ButtonAddWriteSPI";
            this.ButtonAddWriteSPI.Size = new System.Drawing.Size(102, 37);
            this.ButtonAddWriteSPI.TabIndex = 2;
            this.ButtonAddWriteSPI.Text = "Add Value";
            this.ButtonAddWriteSPI.UseVisualStyleBackColor = true;
            this.ButtonAddWriteSPI.Click += new System.EventHandler(this.ButtonAddWriteSPI_Click);
            // 
            // ButtonAddReadSPI
            // 
            this.ButtonAddReadSPI.Location = new System.Drawing.Point(6, 43);
            this.ButtonAddReadSPI.Name = "ButtonAddReadSPI";
            this.ButtonAddReadSPI.Size = new System.Drawing.Size(102, 37);
            this.ButtonAddReadSPI.TabIndex = 1;
            this.ButtonAddReadSPI.Text = "Add Value ";
            this.ButtonAddReadSPI.UseVisualStyleBackColor = true;
            this.ButtonAddReadSPI.Click += new System.EventHandler(this.ButtonAddReadSPI_Click);
            // 
            // groupBox11
            // 
            this.groupBox11.Controls.Add(this.label14);
            this.groupBox11.Controls.Add(this.label12);
            this.groupBox11.Controls.Add(this.progressBarWrite);
            this.groupBox11.Controls.Add(this.ButtonAddWriteI2C);
            this.groupBox11.Controls.Add(this.ButtonAddReadI2C);
            this.groupBox11.Controls.Add(this.progressBarRead);
            this.groupBox11.Location = new System.Drawing.Point(10, 25);
            this.groupBox11.Name = "groupBox11";
            this.groupBox11.Size = new System.Drawing.Size(188, 177);
            this.groupBox11.TabIndex = 3;
            this.groupBox11.TabStop = false;
            this.groupBox11.Text = "I2C";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(118, 93);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(46, 20);
            this.label14.TabIndex = 11;
            this.label14.Text = "Write";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(118, 21);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(48, 20);
            this.label12.TabIndex = 10;
            this.label12.Text = "Read";
            // 
            // ButtonAddWriteI2C
            // 
            this.ButtonAddWriteI2C.Location = new System.Drawing.Point(6, 115);
            this.ButtonAddWriteI2C.Name = "ButtonAddWriteI2C";
            this.ButtonAddWriteI2C.Size = new System.Drawing.Size(102, 37);
            this.ButtonAddWriteI2C.TabIndex = 2;
            this.ButtonAddWriteI2C.Text = "Add Value";
            this.ButtonAddWriteI2C.UseVisualStyleBackColor = true;
            this.ButtonAddWriteI2C.Click += new System.EventHandler(this.ButtonAddWriteI2C_Click);
            // 
            // ButtonAddReadI2C
            // 
            this.ButtonAddReadI2C.Location = new System.Drawing.Point(6, 43);
            this.ButtonAddReadI2C.Name = "ButtonAddReadI2C";
            this.ButtonAddReadI2C.Size = new System.Drawing.Size(102, 37);
            this.ButtonAddReadI2C.TabIndex = 1;
            this.ButtonAddReadI2C.Text = "Add Value ";
            this.ButtonAddReadI2C.UseVisualStyleBackColor = true;
            this.ButtonAddReadI2C.Click += new System.EventHandler(this.ButtonAddReadI2C_Click);
            // 
            // ButtonClearGrid
            // 
            this.ButtonClearGrid.Location = new System.Drawing.Point(10, 400);
            this.ButtonClearGrid.Name = "ButtonClearGrid";
            this.ButtonClearGrid.Size = new System.Drawing.Size(188, 75);
            this.ButtonClearGrid.TabIndex = 0;
            this.ButtonClearGrid.Text = "Clear Grid ";
            this.ButtonClearGrid.UseVisualStyleBackColor = true;
            this.ButtonClearGrid.Click += new System.EventHandler(this.ButtonClearGrid_Click);
            // 
            // groupBox10
            // 
            this.groupBox10.Controls.Add(this.dataGridView1);
            this.groupBox10.Location = new System.Drawing.Point(518, 448);
            this.groupBox10.Name = "groupBox10";
            this.groupBox10.Size = new System.Drawing.Size(669, 489);
            this.groupBox10.TabIndex = 16;
            this.groupBox10.TabStop = false;
            this.groupBox10.Text = "History Table ";
            // 
            // BackGroundForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1202, 950);
            this.Controls.Add(this.groupBox10);
            this.Controls.Add(this.groupBox9);
            this.Controls.Add(this.groupBox8);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.ComboBoxCOMPORT);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "BackGroundForm";
            this.Text = "Senior COM Port ";
            this.Load += new System.EventHandler(this.BackGroundForm_Load);
            this.ComboBoxCOMPORT.ResumeLayout(false);
            this.ComboBoxCOMPORT.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox9.ResumeLayout(false);
            this.groupBox12.ResumeLayout(false);
            this.groupBox12.PerformLayout();
            this.groupBox11.ResumeLayout(false);
            this.groupBox11.PerformLayout();
            this.groupBox10.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox ComboBoxCOMPORT;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox ComboBoxParityBit;
        private System.Windows.Forms.ComboBox ComboBoxStopBit;
        private System.Windows.Forms.ComboBox ComboBoxDataBit;
        private System.Windows.Forms.ComboBox ComboBoxBaudRate;
        private System.Windows.Forms.ComboBox ComboBoxPortNum;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button ButtonClose;
        private System.Windows.Forms.Button ButtonOpen;
        private System.Windows.Forms.Button ButtonSendData;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.TextBox TextBoxDataOut;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label LabelStatus;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.CheckBox CheckBoxUseButton;
        private System.Windows.Forms.CheckBox CheckBoxUseEnter;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox CheckBoxWriteLine;
        private System.Windows.Forms.CheckBox CheckBoxWrite;
        private System.Windows.Forms.Button ButtonClearOutput;
        private System.Windows.Forms.CheckBox CheckBoxRTS;
        private System.Windows.Forms.CheckBox CheckBoxDTR;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.TextBox TextBoxDataIn;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.CheckBox CheckBoxAlwaysUpdate;
        private System.Windows.Forms.CheckBox CheckBoxAddToOldData;
        private System.Windows.Forms.Button ButtonClearInput;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ProgressBar progressBarWrite;
        private System.Windows.Forms.ProgressBar progressBarRead;
        private System.Windows.Forms.TextBox TextBoxRegisterAddress;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TextBoxByteValue;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TextBoxSlaveAddress;
        private System.Windows.Forms.TextBox TextBoxNumberOfByte;
        private System.Windows.Forms.Button ButtonI2CWrite;
        private System.Windows.Forms.Button ButtonI2CRead;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.ProgressBar progressBarSPIwrite;
        private System.Windows.Forms.ProgressBar progressBarSPIread;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button ButtonSPIRead;
        private System.Windows.Forms.TextBox TextBoxRegisterAddress2;
        private System.Windows.Forms.Button ButtonSPIWrite;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox TextBoxNumberOfByteSPI;
        private System.Windows.Forms.TextBox TextBoxByteValueSPI;
        private System.Windows.Forms.TextBox TextBoxOPCode;
        private System.Windows.Forms.Label OPCode;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.Button ButtonAddWriteI2C;
        private System.Windows.Forms.Button ButtonAddReadI2C;
        private System.Windows.Forms.Button ButtonClearGrid;
        private System.Windows.Forms.GroupBox groupBox12;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button ButtonAddWriteSPI;
        private System.Windows.Forms.Button ButtonAddReadSPI;
        private System.Windows.Forms.GroupBox groupBox11;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.GroupBox groupBox10;
    }
}

