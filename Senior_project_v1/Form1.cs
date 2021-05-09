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

namespace Senior_project_v1
{
    public partial class BackGroundForm : Form
    {
        /* Declare variable */
        string dataOut;
        string dataIn;
        string I2C_read = "i r";
        string I2C_write = "i w";
        string SPI_read = "s r";
        string SPI_write = "s w";
        public BackGroundForm()
        {
            InitializeComponent();
        }

        private void BackGroundForm_Load(object sender, EventArgs e)
        {
            /*Create Port varible */
            string[] ports = SerialPort.GetPortNames();
            /* Show available Port*/
            ComboBoxPortNum.Items.AddRange(ports);

            /* Button Initialization */
            ButtonOpen.Enabled = true;
            ButtonClose.Enabled = false;

            /*  Check Box Initialization */
            CheckBoxDTR.Checked = false;
            serialPort1.DtrEnable = false;
            CheckBoxRTS.Checked = false;
            serialPort1.RtsEnable = false;
            ButtonSendData.Enabled = false;
            CheckBoxAddToOldData.Checked = true;
            CheckBoxAlwaysUpdate.Checked = false;
            CheckBoxUseButton.Checked = true;
            CheckBoxUseEnter.Checked = false;

        }
        /*========================================================================================*/
        /* Click event --> Open Button */
        private void ButtonOpen_Click(object sender, EventArgs e)
        {
            try
            {
                serialPort1.PortName = ComboBoxPortNum.Text;
                serialPort1.BaudRate = Convert.ToInt32(ComboBoxBaudRate.Text);
                serialPort1.DataBits = Convert.ToInt32(ComboBoxDataBit.Text);
                serialPort1.StopBits = (StopBits)Enum.Parse(typeof(StopBits), ComboBoxStopBit.Text);
                serialPort1.Parity = (Parity)Enum.Parse(typeof(Parity), ComboBoxParityBit.Text);

                /*Status*/
                serialPort1.Open();
                progressBar1.Value = 100;
                ButtonOpen.Enabled = false;
                ButtonClose.Enabled = true;
                LabelStatus.Text = "ON";

            }
            /* In Case some *** happen */
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "S*** ! Error happen", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ButtonOpen.Enabled = true;
                ButtonClose.Enabled = false;
                LabelStatus.Text = "OFF";
            }
        }
        /*========================================================================================*/
        /* Click event --> Close Button */
        private void ButtonClose_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                serialPort1.Close();
                progressBar1.Value = 0;
                ButtonOpen.Enabled = true;
                ButtonClose.Enabled = false;
                LabelStatus.Text = "OFF";

            }
        }
        /*========================================================================================*/
        /* Click event --> Send Data Button */
        private void ButtonSendData_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                dataOut = TextBoxDataOut.Text + "\r\n";
                serialPort1.Write(dataOut);
                //serialPort1.WriteLine(dataOut);
            }
        }
        /*========================================================================================*/
        /* Click  event --> Clear Output Button */
        private void ButtonClearOutput_Click(object sender, EventArgs e)
        {
            if (TextBoxDataOut.Text != "")
            {
                TextBoxDataOut.Text = "";
            }
        }
        /*========================================================================================*/
        /* Check event --> DTR check box */
        private void CheckBoxDTR_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckBoxDTR.Checked)
            {
                serialPort1.DtrEnable = true;
                MessageBox.Show("DTR Enable", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                serialPort1.DtrEnable = false;
            }
        }
        /*========================================================================================*/
        /* Check event --> RTS check box */
        private void CheckBoxRTS_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckBoxRTS.Checked)
            {
                serialPort1.RtsEnable = true;
                MessageBox.Show("RTS Enable", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                serialPort1.RtsEnable = false;
            }
        }
        /*========================================================================================*/
        /* Check event --> CheckBox Using Button */
        private void CheckBoxUseButton_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckBoxUseButton.Checked)
            {
                ButtonSendData.Enabled = true;
            }
            else
            {
                ButtonSendData.Enabled = false;
            }
        }
        /*========================================================================================*/
        /* Check event --> CheckBox Using Enter  */
        private void TextBoxDataOut_KeyDown(object sender, KeyEventArgs e)
        {
            if (CheckBoxUseEnter.Checked)
            {
                if (e.KeyCode == Keys.Enter)
                {
                    if (serialPort1.IsOpen)
                    {
                        dataOut = TextBoxDataOut.Text + "\r\n";
                        serialPort1.Write(dataOut);
                        //serialPort1.WriteLine(dataOut);
                    }
                }
            }
        }
        /*========================================================================================*/
        /* Text Change Event --> Handel text Change in TextBox Dataout */
        private void TextBoxDataOut_TextChanged(object sender, EventArgs e)
        {
            if (CheckBoxUseEnter.Checked)
            {
                TextBoxDataOut.Text = TextBoxDataOut.Text.Replace(Environment.NewLine, "");
            }
        }
        /*========================================================================================*/
        /* Text Change Event --> Handel text Change in TextBox DataIN  */
        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            dataIn = serialPort1.ReadExisting();
            this.Invoke(new EventHandler(ShowData)); // This method show data serial into Text box
            /* There is another way to show data directly */
        }

        private void ShowData(object sender, EventArgs e)
        {
            if (CheckBoxAlwaysUpdate.Checked)
            {
                TextBoxDataIn.Text = dataIn;
            }
            else if (CheckBoxAddToOldData.Checked)
            {
                TextBoxDataIn.Text += dataIn;
            }


        }
        /*========================================================================================*/
        /* Always update the output screen with new data  */
        private void CheckBoxAlwaysUpdate_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckBoxAlwaysUpdate.Checked)
            {
                CheckBoxAlwaysUpdate.Checked = true;
                CheckBoxAddToOldData.Checked = false;
            }
            else { CheckBoxAddToOldData.Checked = true; }
        }

        private void CheckBoxAddToOldData_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckBoxAddToOldData.Checked)
            {
                CheckBoxAlwaysUpdate.Checked = false;
                CheckBoxAddToOldData.Checked = true;
            }
            else { CheckBoxAlwaysUpdate.Checked = true; }
        }

        private void ButtonI2CRead_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                dataOut = I2C_read + " " + TextBoxSlaveAddress.Text + " " + TextBoxRegisterAddress.Text + " " + TextBoxNumberOfByte.Text + "\r\n";
                serialPort1.WriteLine(dataOut);
                progressBarRead.Value = 100;
                progressBarWrite.Value = 0;
                progressBarSPIread.Value = 0;
                progressBarSPIwrite.Value = 0;
            }
        }

        private void ButtonI2CWrite_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                dataOut = I2C_write + " " + TextBoxSlaveAddress.Text + " " + TextBoxRegisterAddress.Text + " " + TextBoxByteValue.Text + "\r\n";
                serialPort1.WriteLine(dataOut);
                progressBarRead.Value = 0;
                progressBarWrite.Value = 100;
                progressBarSPIread.Value = 0;
                progressBarSPIwrite.Value = 0;
            }
        }

        private void ButtonSPIRead_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                dataOut = SPI_read + " " + TextBoxOPCode.Text + " " + TextBoxRegisterAddress2.Text + " " + TextBoxNumberOfByteSPI.Text + "\r\n";
                serialPort1.WriteLine(dataOut);
                progressBarSPIread.Value = 100;
                progressBarSPIwrite.Value = 0;
                progressBarRead.Value = 0;
                progressBarWrite.Value = 0;

            }

        }

        private void ButtonSPIWrite_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {

                dataOut = SPI_write + " " + TextBoxOPCode.Text + " " + TextBoxRegisterAddress2.Text + " " + TextBoxByteValueSPI.Text + "\r\n";
                serialPort1.WriteLine(dataOut);
                progressBarSPIread.Value = 0;
                progressBarSPIwrite.Value = 100;
                progressBarRead.Value = 0;
                progressBarWrite.Value = 0;
            }
        }

        private void ButtonClearInput_Click(object sender, EventArgs e)
        {
            TextBoxDataIn.Text = " ";
        }

        private void ButtonClearGrid_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
        }

        private void ButtonAddReadI2C_Click(object sender, EventArgs e)
        {
            string[] row = new string[] { "READ I2C", TextBoxRegisterAddress.Text, TextBoxDataIn.Text };
            dataGridView1.Rows.Add(row);
        }

        private void ButtonAddWriteI2C_Click(object sender, EventArgs e)
        {
            string[] row = new string[] { "Write I2C", TextBoxRegisterAddress.Text, TextBoxByteValue.Text, TextBoxDataIn.Text };
            dataGridView1.Rows.Add(row);
        }

        private void ButtonAddReadSPI_Click(object sender, EventArgs e)
        {
            string[] row = new string[] { "READ SPI", TextBoxRegisterAddress2.Text, TextBoxDataIn.Text };
            dataGridView1.Rows.Add(row);
        }

        private void ButtonAddWriteSPI_Click(object sender, EventArgs e)
        {
            string[] row = new string[] { "Write SPI", TextBoxRegisterAddress2.Text, TextBoxByteValueSPI.Text, TextBoxDataIn.Text };
            dataGridView1.Rows.Add(row);
        }
    }
}
