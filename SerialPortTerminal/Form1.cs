﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.IO.Ports;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
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
            comboBox_PortNum.Items.Clear();
            foreach (string port in ports)
            {
                Console.WriteLine(port);
                comboBox_PortNum.Items.Add(port);
            }
            if (ports.Count() == 0)
            {
                comboBox_PortNum.Enabled = false;
            }
            else
            {
                comboBox_PortNum.SelectedIndex = 0;
                comboBox_PortNum.Enabled = true;
            }
        }
        #region HotKey       
        private void callButtonEvent(Button btn, string EventName)
        {
            //建立一個型別      
            Type t = typeof(Button);
            //引數物件      
            object[] p = new object[1];
            //產生方法      
            MethodInfo m = t.GetMethod(EventName, BindingFlags.NonPublic | BindingFlags.Instance);
            //引數賦值。傳入函式      
            //獲得引數資料  
            ParameterInfo[] para = m.GetParameters();
            //根據引數的名字，拿引數的空值。  
            p[0] = Type.GetType(para[0].ParameterType.BaseType.FullName).GetProperty("Empty");
            //呼叫      
            m.Invoke(btn, p);
            return;
        }

        List<HotKeyClass> HotName = new List<HotKeyClass>()
        {
            new HotKeyClass("Start Serial Port",100,Keys.None,Keys.F10,"button_StartStop"),
            new HotKeyClass("Refresh Serial Port",101,Keys.None,Keys.F5,"button_ReFresh"),
            new HotKeyClass("Save Log for View",102,Keys.Control,Keys.S,"button_Save"),
            new HotKeyClass("Save Log Start",103,Keys.Alt,Keys.D,"button_SaveLog"),
            new HotKeyClass("Search",104,Keys.None,Keys.F3,"button_Find"),
            new HotKeyClass("Clear View",105,Keys.Control,Keys.X,"button_Clear"),
            //bunifuMaterialTextbox
            new HotKeyClass("Search Text",106,Keys.Control,Keys.F,"underLineTextBox_Find"),

            new HotKeyClass("Search Previous",107,Keys.Shift,Keys.F3,"Previous"),
        };
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            HotKeyClass hotKeyClass = HotName.Find(x => x.keyModifiers == e.Modifiers && x.keys == e.KeyCode);
            if (hotKeyClass == null)
                return;
            if (hotKeyClass.ControlName.Contains("button"))
            {
                Control[] nowtb;
                nowtb = Controls.Find(hotKeyClass.ControlName, true);
                Button tileButton = null;

                tileButton = nowtb[0] as Button;
                callButtonEvent(tileButton, "OnClick");
            }
            else if (hotKeyClass.ControlName.Contains("underLineTextBox"))
            {
                Control[] nowtb;
                nowtb = Controls.Find(hotKeyClass.ControlName, true);
                UnderLineTextBox textbox = null;

                textbox = nowtb[0] as UnderLineTextBox;
                textbox.Focus();
            }
            else if (hotKeyClass.ControlName == "Previous")
                FindPrevious();

        }
        private void HotKey_Init()
        {
            foreach (HotKeyClass hotKeyClass in HotName)
            {             
                string keycomb = "";
                Keys keynum = hotKeyClass.keys;
                Keys keyModnum = hotKeyClass.keyModifiers;

                //HotKey.RegisterHotKey(Handle, hotKeyClass.ID, keyModnum, keynum);

                if (hotKeyClass.keyModifiers != Keys.None)
                    keycomb = "(" + keyModnum + "-" + keynum + ")";
                else
                    keycomb = "(" + keynum.ToString() + ")";

                if (hotKeyClass.ControlName.Contains("button"))
                {
                    Control[] nowtb;
                    nowtb = Controls.Find(hotKeyClass.ControlName, true);
                    if (nowtb.Count() != 0)
                    {
                        Button tileButton = null;

                        tileButton = nowtb[0] as Button;

                        toolTip1.SetToolTip(tileButton, hotKeyClass.IniName + keycomb);
                    }
                }

            }
        }
        #endregion
        private void Form1_Load(object sender, EventArgs e)
        {
            InitSerialPortNum();
            comboBox_Speed.SelectedIndex = 6;
            HotKey_Init();
            panel1.MakeDoubleBuffered(true);
            panel4.MakeDoubleBuffered(true);
            richTextBox_View.MakeDoubleBuffered(true);

            //string str1 = "tCL\ttRCD/tRP\ttRAS\ttWR\ttCWL\ttRRD_S\ttRRD_L\ttWTR_S\ttWTR_L\ttRFC\ttRFC2\ttRFC4\ttRTP\ttFAW\tCMD_stretch\t\n";
            //string str2 = "19\t26\t46\t24\t18\t9\t14\t3\t8\t842\t278\t171\t12\t53\t1\n";
            //string str3 = "tRDRD_sg\ttRDRD_dg\ttRDRD_dr\ttRDRD_dd\t-tRDWR_sg\ttRDWR_dg\ttRDWR_dr\ttRDWR_dd\t-tWRWR_sg\ttWRWR_dg\ttWRWR_dr\ttWRWR_dd\t-tWRRD_sg\ttWRRD_dg\ttWRRD_dr\ttWRRD_dd\n";
            //string str4 = "16\t16\t16\t16\t-16\t16\t16\t16\t-16\t16\t16\t16\t-16\t16\t16\t16\n\n";
            List<int> css = new List<int>();

            for (int width = 1; width < 33; width++)
                css.Add(width * 100);

            richTextBox_View.SelectionTabs = css.ToArray();

            //richTextBox_View.AppendText(str1);
            //richTextBox_View.AppendText(str2);
            //richTextBox_View.AppendText(str3);
            //richTextBox_View.AppendText(str4);
        }

        private void bunifuImageButton_ReFresh_Click(object sender, EventArgs e)
        {
            InitSerialPortNum();
        }

        public void serial_OPEN()
        {

            _serialPort = new SerialPort();

            // Allow the user to set the appropriate properties.
            _serialPort.PortName = comboBox_PortNum.Text;
            _serialPort.BaudRate = Convert.ToInt32(comboBox_Speed.Text);
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
                        string buffer = _serialPort.ReadExisting();

                        Display d = new Display(DisplayText);
                        this.Invoke(d, new Object[] { buffer });//使用委託的方式操作control
                        //this.BeginInvoke(d, new Object[] { buffer });//使用委託的方式操作control
                        //Thread.Sleep(1);
                    }
                    //catch (TimeoutException timeoutEx)
                    //{
                    //    //以下這邊請自行撰寫你想要的例外處理
                    //}
                    catch (Exception ex)
                    {
                        //以下這邊請自行撰寫你想要的例外處理
                    }
                }
                else
                    Thread.Sleep(1);
            }
        }
        private void DisplayText(string buffer)
        {
            if(WriteLog != null)
                WriteLog.WriteLine(buffer.Replace("\r", ""));

            richTextBox_View.AppendText(buffer.Replace("\r\n", "\n"));
            if (checkBox_ENdLine.Checked)
            {
                richTextBox_View.SelectionStart = richTextBox_View.Text.Length;
                richTextBox_View.ScrollToCaret();
            }
        }
        private void bunifuImageButton_StartStop_Click(object sender, EventArgs e)
        {
            if (comboBox_PortNum.Items.Count < 1)
            {
                const string message =
                    "Please connent Debug Card and enter SerialPort to Reflash.";
                const string caption = "error";
                var result = MessageBox.Show(message, caption,
                                             MessageBoxButtons.OK,
                                             MessageBoxIcon.Error);

                return;
            }


            if (button_StartStop.Tag.ToString() == "Start")
            {
                readThread = new Thread(comport_DataReceived);
                serial_OPEN();
                try
                {
                    _serialPort.Open();//開啟serial
                    button_StartStop.Tag = "Stop";
                    button_StartStop.BackgroundImage = Properties.Resources.pause_90px;
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
            else if (button_StartStop.Tag.ToString() == "Stop")
            {
                _continue = false;//停止thread
                _serialPort.Close();//關閉serial port

                if (WriteLog != null)
                    WriteLog.Close();

                button_StartStop.Tag = "Start";
                button_StartStop.BackgroundImage = Properties.Resources.play_96px;

                if (readThread != null)
                    readThread.Abort();

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

            if (button_SaveLog.Tag.ToString() == "SaveStart")
            {
                DialogResult dialogResult = SaveFile();
                if (dialogResult == DialogResult.OK)
                {
                    button_SaveLog.Tag = "SaveStop";
                    button_SaveLog.Image = Properties.Resources.close_window_96px;
                    WriteLog = new StreamWriter(File.Open(saveFile.FileName, FileMode.Create));
                }
            }
            else if (button_SaveLog.Tag.ToString() == "SaveStop")
            {
                button_SaveLog.Tag = "SaveStart";
                button_SaveLog.Image = Properties.Resources.save_as_96px;
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

            if (readThread != null)
                readThread.Abort();
        }
        #region search
        int selectionStart = 0;
        int selectionStop = 0;
        private void ShowFind()
        {
            
            if (selectionStart == -1)
            {
                MessageBox.Show("Not find.");
            }
            else
            {
                selectionStop = selectionStart + underLineTextBox_Find.Text.Length;
                richTextBox_View.SelectionBackColor = Color.Yellow;
                richTextBox_View.Focus();
            }

        }
        private void FindNext()
        {
            richTextBox_View.SelectionBackColor = Color.White;
            selectionStart = richTextBox_View.Find(underLineTextBox_Find.Text, selectionStop, richTextBox_View.TextLength, RichTextBoxFinds.None);
            ShowFind();
        }

        private void FindPrevious()
        {
            richTextBox_View.SelectionBackColor = Color.White;
            selectionStart = richTextBox_View.Find(underLineTextBox_Find.Text, 0, selectionStart, RichTextBoxFinds.Reverse);
            ShowFind();
        }
        #endregion

        private void bunifuImageButton_Find_Click(object sender, EventArgs e)
        {
            FindNext();
        }

        private void bunifuMaterialTextbox_Find_OnValueChanged(object sender, EventArgs e)
        {
            if (checkBox_ENdLine.Checked)
                checkBox_ENdLine.Checked = false;
        }

        private void bunifuTileButton_Close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void bunifuMaterialTextbox_Find_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                FindNext();
            if (checkBox_ENdLine.Checked)
                checkBox_ENdLine.Checked = false;
        }
        private void richTextBox_View_VScroll(object sender, EventArgs e)
        {

        }
    }

    public static class ControlExtentions
    {
        public static void MakeDoubleBuffered(this Control control, bool setting)
        {
            Type controlType = control.GetType();
            PropertyInfo pi = controlType.GetProperty("DoubleBuffered",
            BindingFlags.Instance | BindingFlags.NonPublic);
            pi.SetValue(control, setting, null);
        }
    }
}
