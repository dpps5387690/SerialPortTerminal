namespace SerialPortTerminal
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.richTextBox_View = new System.Windows.Forms.RichTextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.button_SaveLog = new System.Windows.Forms.Button();
            this.button_Save = new System.Windows.Forms.Button();
            this.button_ReFresh = new System.Windows.Forms.Button();
            this.button_StartStop = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.underLineTextBox_Find = new SerialPortTerminal.UnderLineTextBox();
            this.button_Find = new System.Windows.Forms.Button();
            this.button_Clear = new System.Windows.Forms.Button();
            this.checkBox_ENdLine = new System.Windows.Forms.CheckBox();
            this.comboBox_PortNum = new System.Windows.Forms.ComboBox();
            this.comboBox_Speed = new System.Windows.Forms.ComboBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.panel4.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // richTextBox_View
            // 
            this.richTextBox_View.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox_View.Location = new System.Drawing.Point(0, 0);
            this.richTextBox_View.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.richTextBox_View.Name = "richTextBox_View";
            this.richTextBox_View.ReadOnly = true;
            this.richTextBox_View.Size = new System.Drawing.Size(1010, 588);
            this.richTextBox_View.TabIndex = 0;
            this.richTextBox_View.Text = "";
            this.richTextBox_View.WordWrap = false;
            this.richTextBox_View.VScroll += new System.EventHandler(this.richTextBox_View_VScroll);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.panel4.Controls.Add(this.comboBox_Speed);
            this.panel4.Controls.Add(this.comboBox_PortNum);
            this.panel4.Controls.Add(this.checkBox_ENdLine);
            this.panel4.Controls.Add(this.underLineTextBox_Find);
            this.panel4.Controls.Add(this.button_SaveLog);
            this.panel4.Controls.Add(this.button_Find);
            this.panel4.Controls.Add(this.button_Clear);
            this.panel4.Controls.Add(this.button_Save);
            this.panel4.Controls.Add(this.button_ReFresh);
            this.panel4.Controls.Add(this.button_StartStop);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Margin = new System.Windows.Forms.Padding(0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1010, 55);
            this.panel4.TabIndex = 33;
            // 
            // button_SaveLog
            // 
            this.button_SaveLog.BackColor = System.Drawing.Color.Gray;
            this.button_SaveLog.BackgroundImage = global::SerialPortTerminal.Properties.Resources.save_as_96px;
            this.button_SaveLog.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button_SaveLog.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.button_SaveLog.FlatAppearance.BorderSize = 0;
            this.button_SaveLog.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_SaveLog.Location = new System.Drawing.Point(297, 3);
            this.button_SaveLog.Name = "button_SaveLog";
            this.button_SaveLog.Size = new System.Drawing.Size(50, 50);
            this.button_SaveLog.TabIndex = 12;
            this.button_SaveLog.Tag = "SaveStart";
            this.button_SaveLog.UseVisualStyleBackColor = false;
            this.button_SaveLog.Click += new System.EventHandler(this.bunifuImageButton_SaveLog_Click);
            // 
            // button_Save
            // 
            this.button_Save.BackColor = System.Drawing.Color.Gray;
            this.button_Save.BackgroundImage = global::SerialPortTerminal.Properties.Resources.save_96px;
            this.button_Save.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button_Save.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.button_Save.FlatAppearance.BorderSize = 0;
            this.button_Save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Save.Location = new System.Drawing.Point(241, 3);
            this.button_Save.Name = "button_Save";
            this.button_Save.Size = new System.Drawing.Size(50, 50);
            this.button_Save.TabIndex = 12;
            this.button_Save.Tag = "";
            this.button_Save.UseVisualStyleBackColor = false;
            this.button_Save.Click += new System.EventHandler(this.bunifuImageButton_Save_Click);
            // 
            // button_ReFresh
            // 
            this.button_ReFresh.BackColor = System.Drawing.Color.Gray;
            this.button_ReFresh.BackgroundImage = global::SerialPortTerminal.Properties.Resources.refresh_96px;
            this.button_ReFresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button_ReFresh.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.button_ReFresh.FlatAppearance.BorderSize = 0;
            this.button_ReFresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_ReFresh.Location = new System.Drawing.Point(185, 3);
            this.button_ReFresh.Name = "button_ReFresh";
            this.button_ReFresh.Size = new System.Drawing.Size(50, 50);
            this.button_ReFresh.TabIndex = 12;
            this.button_ReFresh.Tag = "";
            this.button_ReFresh.UseVisualStyleBackColor = false;
            this.button_ReFresh.Click += new System.EventHandler(this.bunifuImageButton_ReFresh_Click);
            // 
            // button_StartStop
            // 
            this.button_StartStop.BackColor = System.Drawing.Color.Gray;
            this.button_StartStop.BackgroundImage = global::SerialPortTerminal.Properties.Resources.play_96px;
            this.button_StartStop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button_StartStop.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.button_StartStop.FlatAppearance.BorderSize = 0;
            this.button_StartStop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_StartStop.Location = new System.Drawing.Point(129, 3);
            this.button_StartStop.Name = "button_StartStop";
            this.button_StartStop.Size = new System.Drawing.Size(50, 50);
            this.button_StartStop.TabIndex = 12;
            this.button_StartStop.Tag = "Start";
            this.button_StartStop.UseVisualStyleBackColor = false;
            this.button_StartStop.Click += new System.EventHandler(this.bunifuImageButton_StartStop_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.richTextBox_View);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 55);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1010, 588);
            this.panel1.TabIndex = 35;
            // 
            // underLineTextBox_Find
            // 
            this.underLineTextBox_Find.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.underLineTextBox_Find.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.underLineTextBox_Find.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.underLineTextBox_Find.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.underLineTextBox_Find.Location = new System.Drawing.Point(353, 31);
            this.underLineTextBox_Find.MaxLength = 50;
            this.underLineTextBox_Find.Name = "underLineTextBox_Find";
            this.underLineTextBox_Find.Size = new System.Drawing.Size(100, 22);
            this.underLineTextBox_Find.TabIndex = 13;
            this.underLineTextBox_Find.KeyDown += new System.Windows.Forms.KeyEventHandler(this.bunifuMaterialTextbox_Find_KeyDown);
            // 
            // button_Find
            // 
            this.button_Find.BackColor = System.Drawing.Color.Gray;
            this.button_Find.BackgroundImage = global::SerialPortTerminal.Properties.Resources.search_96px;
            this.button_Find.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button_Find.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.button_Find.FlatAppearance.BorderSize = 0;
            this.button_Find.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Find.Location = new System.Drawing.Point(459, 3);
            this.button_Find.Name = "button_Find";
            this.button_Find.Size = new System.Drawing.Size(50, 50);
            this.button_Find.TabIndex = 12;
            this.button_Find.Tag = "";
            this.button_Find.UseVisualStyleBackColor = false;
            this.button_Find.Click += new System.EventHandler(this.bunifuImageButton_Find_Click);
            // 
            // button_Clear
            // 
            this.button_Clear.BackColor = System.Drawing.Color.Gray;
            this.button_Clear.BackgroundImage = global::SerialPortTerminal.Properties.Resources.broom_96px;
            this.button_Clear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button_Clear.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.button_Clear.FlatAppearance.BorderSize = 0;
            this.button_Clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Clear.Location = new System.Drawing.Point(515, 3);
            this.button_Clear.Name = "button_Clear";
            this.button_Clear.Size = new System.Drawing.Size(50, 50);
            this.button_Clear.TabIndex = 12;
            this.button_Clear.Tag = "";
            this.button_Clear.UseVisualStyleBackColor = false;
            this.button_Clear.Click += new System.EventHandler(this.bunifuImageButton_Clear_Click);
            // 
            // checkBox_ENdLine
            // 
            this.checkBox_ENdLine.AutoSize = true;
            this.checkBox_ENdLine.Checked = true;
            this.checkBox_ENdLine.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_ENdLine.Location = new System.Drawing.Point(571, 30);
            this.checkBox_ENdLine.Name = "checkBox_ENdLine";
            this.checkBox_ENdLine.Size = new System.Drawing.Size(81, 23);
            this.checkBox_ENdLine.TabIndex = 14;
            this.checkBox_ENdLine.Text = "ENdLine";
            this.checkBox_ENdLine.UseVisualStyleBackColor = true;
            // 
            // comboBox_PortNum
            // 
            this.comboBox_PortNum.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox_PortNum.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_PortNum.FormattingEnabled = true;
            this.comboBox_PortNum.Location = new System.Drawing.Point(3, 1);
            this.comboBox_PortNum.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.comboBox_PortNum.Name = "comboBox_PortNum";
            this.comboBox_PortNum.Size = new System.Drawing.Size(120, 27);
            this.comboBox_PortNum.TabIndex = 15;
            this.comboBox_PortNum.Tag = "SMBUS_Select";
            // 
            // comboBox_Speed
            // 
            this.comboBox_Speed.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox_Speed.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Speed.FormattingEnabled = true;
            this.comboBox_Speed.Items.AddRange(new object[] {
            "300",
            "2400",
            "4800",
            "9600",
            "19200",
            "38400",
            "57600",
            "115200"});
            this.comboBox_Speed.Location = new System.Drawing.Point(3, 28);
            this.comboBox_Speed.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.comboBox_Speed.Name = "comboBox_Speed";
            this.comboBox_Speed.Size = new System.Drawing.Size(120, 27);
            this.comboBox_Speed.TabIndex = 15;
            this.comboBox_Speed.Tag = "SMBUS_Select";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.ClientSize = new System.Drawing.Size(1010, 643);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel4);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Calibri Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Serial Port Terminal";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox_View;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button_StartStop;
        private System.Windows.Forms.Button button_ReFresh;
        private System.Windows.Forms.Button button_Save;
        private System.Windows.Forms.Button button_SaveLog;
        private UnderLineTextBox underLineTextBox_Find;
        private System.Windows.Forms.Button button_Find;
        private System.Windows.Forms.Button button_Clear;
        private System.Windows.Forms.CheckBox checkBox_ENdLine;
        private System.Windows.Forms.ComboBox comboBox_PortNum;
        private System.Windows.Forms.ComboBox comboBox_Speed;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}

