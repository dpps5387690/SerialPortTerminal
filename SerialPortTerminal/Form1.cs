﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SerialPortTerminal
{
    public partial class Form1 : Form
    {
        static bool _continue;
        Thread readThread;
        private SerialPort _serialPort;
        delegate void Display(string buffer);
        public Form1()
        {
            InitializeComponent();
        }

        private void InitSerialPortNum()
        {
            // Get a list of serial port names.
            string[] ports = SerialPort.GetPortNames();
            // Display each port name to the console.
            bunifuDropdown__PortNum.Items.Clear();
            foreach (string port in ports)
            {
                Console.WriteLine(port);
                bunifuDropdown__PortNum.Items.Add(port);
            }
            if (ports.Count() == 0)
            {
                bunifuDropdown__PortNum.Enabled = false;
            }
            else
            {
                bunifuDropdown__PortNum.SelectedIndex = 0;
                bunifuDropdown__PortNum.Enabled = true;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            InitSerialPortNum();
            bunifuDropdown__Speed.SelectedIndex = 6;
        }

        private void bunifuImageButton_ReFresh_Click(object sender, EventArgs e)
        {
            InitSerialPortNum();
        }

        public void serial_OPEN()
        {

            _serialPort = new SerialPort();

            // Allow the user to set the appropriate properties.
            _serialPort.PortName = bunifuDropdown__PortNum.Text;
            _serialPort.BaudRate = Convert.ToInt32(bunifuDropdown__Speed.Text);
            _serialPort.Parity = Parity.None;
            _serialPort.DataBits = 8;
            _serialPort.StopBits = StopBits.One;
            _serialPort.Handshake = Handshake.None;
            //_serialPort.ReadTimeout = 10;
            //_serialPort.DataReceived += new SerialDataReceivedEventHandler(comport_DataReceived);
            //_serialPort.WriteTimeout = 500;
        }
        private void comport_DataReceived()
        {
            while (_continue)
            {
                if (_serialPort.BytesToRead > 0)
                {
                    try
                    {
                        string buffer = _serialPort.ReadLine();

                        Display d = new Display(DisplayText);
                        this.Invoke(d, new Object[] { buffer });//使用委託的方式操作control
                        //this.BeginInvoke(d, new Object[] { buffer });//使用委託的方式操作control
                        //Thread.Sleep(1);
                    }
                    catch (TimeoutException timeoutEx)
                    {
                        //以下這邊請自行撰寫你想要的例外處理
                    }
                    catch (Exception ex)
                    {
                        //以下這邊請自行撰寫你想要的例外處理
                    }
                }
                
            }
        }
        private void DisplayText(string buffer)
        {
            if(WriteLog != null)
                WriteLog.WriteLine(buffer.Replace("\r", ""));

            richTextBox_View.AppendText(buffer.Replace("\r", "") + Environment.NewLine);
            if (bunifuCheckBox_ENdLine.Checked)
            {
                richTextBox_View.SelectionStart = richTextBox_View.Text.Length;
                richTextBox_View.ScrollToCaret();
            }
        }
        private void bunifuImageButton_StartStop_Click(object sender, EventArgs e)
        {
            if (bunifuDropdown__PortNum.Items.Count < 1)
            {
                const string message =
                    "Please connent Debug Card and enter SerialPort to Reflash.";
                const string caption = "error";
                var result = MessageBox.Show(message, caption,
                                             MessageBoxButtons.OK,
                                             MessageBoxIcon.Error);

                return;
            }


            if (bunifuImageButton_StartStop.Tag.ToString() == "Start")
            {
                readThread = new Thread(comport_DataReceived);
                serial_OPEN();
                try
                {
                    _serialPort.Open();//開啟serial
                    bunifuImageButton_StartStop.Tag = "Stop";
                    bunifuImageButton_StartStop.Image = Properties.Resources.pause_90px;
                    _continue = true;
                    readThread.Start();
                    readThread.IsBackground = true;//thread 背景執行  
                }
                catch (UnauthorizedAccessException er)
                {
                    Console.WriteLine(er.Message);
                    MessageBox.Show(er.Message, "Error");
                }

            }
            else if (bunifuImageButton_StartStop.Tag.ToString() == "Stop")
            {
                _continue = false;//停止thread
                _serialPort.Close();//關閉serial port

                if (WriteLog != null)
                    WriteLog.Close();

                bunifuImageButton_StartStop.Tag = "Start";
                bunifuImageButton_StartStop.Image = Properties.Resources.play_96px;

            }
        }

        private void bunifuImageButton_Clear_Click(object sender, EventArgs e)
        {
            richTextBox_View.Clear();
        }
        SaveFileDialog saveFile = null;
        private DialogResult SaveFile()
        {
            saveFile = new SaveFileDialog();
            saveFile.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            saveFile.FilterIndex = 1;
            saveFile.Title = "Save As Log";
            return saveFile.ShowDialog();
        }
        private void bunifuImageButton_Save_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = SaveFile();

            if (dialogResult == DialogResult.OK)
            {
                richTextBox_View.SaveFile(saveFile.FileName, RichTextBoxStreamType.PlainText);
            }
        }
        StreamWriter WriteLog;
        private void bunifuImageButton_SaveLog_Click(object sender, EventArgs e)
        {

            if (bunifuImageButton_SaveLog.Tag.ToString() == "SaveStart")
            {
                DialogResult dialogResult = SaveFile();
                if (dialogResult == DialogResult.OK)
                {
                    bunifuImageButton_SaveLog.Tag = "SaveStop";
                    bunifuImageButton_SaveLog.Image = Properties.Resources.close_window_96px;
                    WriteLog = new StreamWriter(File.Open(saveFile.FileName, FileMode.Create));
                }
            }
            else if (bunifuImageButton_SaveLog.Tag.ToString() == "SaveStop")
            {
                bunifuImageButton_SaveLog.Tag = "SaveStart";
                bunifuImageButton_SaveLog.Image = Properties.Resources.save_as_96px;
                WriteLog.Close();
                WriteLog = null;
            }
            
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            _continue = false;
            if (_serialPort != null)
                _serialPort.Close();

            if (WriteLog != null)
                WriteLog.Close();
        }
        int start = 0;
        int count = 0;
        string findstring;
        private void bunifuImageButto_Find_Click(object sender, EventArgs e)
        {
            if (start >= richTextBox_View.Text.Length)
            {
                MessageBox.Show("Find end.");
                start = 0;
            }
            else
            {
                start = richTextBox_View.Find(findstring, start, RichTextBoxFinds.None);

                if (start == -1)
                {
                    if (count == 0)
                    {
                        MessageBox.Show("Not find.");
                        start = 0;
                    }
                    else
                    {
                        MessageBox.Show("Find end.");
                        start = 0;
                    }
                }
                else
                {
                    count++;
                    start += findstring.Length;
                    richTextBox_View.Focus();
                }
                
            }
        }

        private void bunifuMaterialTextbox_Find_OnValueChanged(object sender, EventArgs e)
        {
            findstring = bunifuMaterialTextbox_Find.Text;
            count = 0;

            if (bunifuCheckBox_ENdLine.Checked)
                bunifuCheckBox_ENdLine.Checked = false;
        }

        private void bunifuTileButton_Close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bunifuTileButton_MaxSize_Click(object sender, EventArgs e)
        {
            if (bunifuFormDock1.WindowState == Bunifu.UI.WinForms.BunifuFormDock.FormWindowStates.Maximized)
            {
                bunifuFormDock1.WindowState = Bunifu.UI.WinForms.BunifuFormDock.FormWindowStates.Normal;
            }
            else
            {
                bunifuFormDock1.WindowState = Bunifu.UI.WinForms.BunifuFormDock.FormWindowStates.Maximized;

            }
        }

        private void bunifuTileButton__MinSize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
            bunifuFormDock1.WindowState = Bunifu.UI.WinForms.BunifuFormDock.FormWindowStates.Minimized;
        }
    }
}
