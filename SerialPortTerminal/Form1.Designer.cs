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
            Bunifu.ToggleSwitch.ToggleState toggleState16 = new Bunifu.ToggleSwitch.ToggleState();
            Bunifu.ToggleSwitch.ToggleState toggleState17 = new Bunifu.ToggleSwitch.ToggleState();
            Bunifu.ToggleSwitch.ToggleState toggleState18 = new Bunifu.ToggleSwitch.ToggleState();
            this.richTextBox_View = new System.Windows.Forms.RichTextBox();
            this.bunifuDropdown__Speed = new Bunifu.UI.WinForms.BunifuDropdown();
            this.bunifuDropdown__PortNum = new Bunifu.UI.WinForms.BunifuDropdown();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuImageButton_Find = new Bunifu.UI.WinForms.BunifuImageButton();
            this.bunifuImageButton_SaveLog = new Bunifu.UI.WinForms.BunifuImageButton();
            this.bunifuImageButton_Save = new Bunifu.UI.WinForms.BunifuImageButton();
            this.bunifuImageButton_Clear = new Bunifu.UI.WinForms.BunifuImageButton();
            this.bunifuImageButton_ReFresh = new Bunifu.UI.WinForms.BunifuImageButton();
            this.bunifuImageButton_StartStop = new Bunifu.UI.WinForms.BunifuImageButton();
            this.bunifuMaterialTextbox_Find = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.bunifuTileButton__MinSize = new Bunifu.Framework.UI.BunifuTileButton();
            this.bunifuTileButton_MaxSize = new Bunifu.Framework.UI.BunifuTileButton();
            this.bunifuTileButton_Close = new Bunifu.Framework.UI.BunifuTileButton();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuFormDock1 = new Bunifu.UI.WinForms.BunifuFormDock();
            this.bunifuToggleSwitch_ENdLine = new Bunifu.ToggleSwitch.BunifuToggleSwitch();
            this.panel2.SuspendLayout();
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
            this.richTextBox_View.Size = new System.Drawing.Size(1010, 517);
            this.richTextBox_View.TabIndex = 0;
            this.richTextBox_View.Text = "";
            this.richTextBox_View.WordWrap = false;
            this.richTextBox_View.VScroll += new System.EventHandler(this.richTextBox_View_VScroll);
            // 
            // bunifuDropdown__Speed
            // 
            this.bunifuDropdown__Speed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.bunifuDropdown__Speed.BorderRadius = 1;
            this.bunifuDropdown__Speed.Direction = Bunifu.UI.WinForms.BunifuDropdown.Directions.Down;
            this.bunifuDropdown__Speed.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuDropdown__Speed.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.bunifuDropdown__Speed.DropdownBorderThickness = Bunifu.UI.WinForms.BunifuDropdown.BorderThickness.Thick;
            this.bunifuDropdown__Speed.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.bunifuDropdown__Speed.DropDownTextAlign = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.bunifuDropdown__Speed.FillDropDown = false;
            this.bunifuDropdown__Speed.FillIndicator = false;
            this.bunifuDropdown__Speed.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bunifuDropdown__Speed.ForeColor = System.Drawing.Color.Purple;
            this.bunifuDropdown__Speed.FormattingEnabled = true;
            this.bunifuDropdown__Speed.Icon = null;
            this.bunifuDropdown__Speed.IndicatorColor = System.Drawing.Color.Purple;
            this.bunifuDropdown__Speed.IndicatorLocation = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            this.bunifuDropdown__Speed.ItemBackColor = System.Drawing.Color.White;
            this.bunifuDropdown__Speed.ItemBorderColor = System.Drawing.Color.White;
            this.bunifuDropdown__Speed.ItemForeColor = System.Drawing.Color.Purple;
            this.bunifuDropdown__Speed.ItemHeight = 26;
            this.bunifuDropdown__Speed.ItemHighLightColor = System.Drawing.Color.Thistle;
            this.bunifuDropdown__Speed.Items.AddRange(new object[] {
            "300",
            "2400",
            "4800",
            "9600",
            "19200",
            "38400",
            "57600",
            "115200"});
            this.bunifuDropdown__Speed.Location = new System.Drawing.Point(2, 38);
            this.bunifuDropdown__Speed.Name = "bunifuDropdown__Speed";
            this.bunifuDropdown__Speed.Size = new System.Drawing.Size(121, 32);
            this.bunifuDropdown__Speed.TabIndex = 5;
            this.bunifuDropdown__Speed.Text = "57600";
            // 
            // bunifuDropdown__PortNum
            // 
            this.bunifuDropdown__PortNum.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.bunifuDropdown__PortNum.BorderRadius = 1;
            this.bunifuDropdown__PortNum.Direction = Bunifu.UI.WinForms.BunifuDropdown.Directions.Down;
            this.bunifuDropdown__PortNum.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuDropdown__PortNum.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.bunifuDropdown__PortNum.DropdownBorderThickness = Bunifu.UI.WinForms.BunifuDropdown.BorderThickness.Thick;
            this.bunifuDropdown__PortNum.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.bunifuDropdown__PortNum.DropDownTextAlign = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.bunifuDropdown__PortNum.FillDropDown = false;
            this.bunifuDropdown__PortNum.FillIndicator = false;
            this.bunifuDropdown__PortNum.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bunifuDropdown__PortNum.ForeColor = System.Drawing.Color.Purple;
            this.bunifuDropdown__PortNum.FormattingEnabled = true;
            this.bunifuDropdown__PortNum.Icon = null;
            this.bunifuDropdown__PortNum.IndicatorColor = System.Drawing.Color.Purple;
            this.bunifuDropdown__PortNum.IndicatorLocation = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            this.bunifuDropdown__PortNum.ItemBackColor = System.Drawing.Color.White;
            this.bunifuDropdown__PortNum.ItemBorderColor = System.Drawing.Color.White;
            this.bunifuDropdown__PortNum.ItemForeColor = System.Drawing.Color.Purple;
            this.bunifuDropdown__PortNum.ItemHeight = 26;
            this.bunifuDropdown__PortNum.ItemHighLightColor = System.Drawing.Color.Thistle;
            this.bunifuDropdown__PortNum.Location = new System.Drawing.Point(2, 2);
            this.bunifuDropdown__PortNum.Name = "bunifuDropdown__PortNum";
            this.bunifuDropdown__PortNum.Size = new System.Drawing.Size(121, 32);
            this.bunifuDropdown__PortNum.TabIndex = 6;
            this.bunifuDropdown__PortNum.Text = null;
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(946, 49);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(64, 19);
            this.bunifuCustomLabel1.TabIndex = 8;
            this.bunifuCustomLabel1.Text = "End Line";
            // 
            // bunifuImageButton_Find
            // 
            this.bunifuImageButton_Find.ActiveImage = null;
            this.bunifuImageButton_Find.AllowAnimations = true;
            this.bunifuImageButton_Find.AllowBuffering = false;
            this.bunifuImageButton_Find.AllowZooming = true;
            this.bunifuImageButton_Find.BackColor = System.Drawing.Color.Gray;
            this.bunifuImageButton_Find.ErrorImage = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton_Find.ErrorImage")));
            this.bunifuImageButton_Find.FadeWhenInactive = false;
            this.bunifuImageButton_Find.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.bunifuImageButton_Find.Image = global::SerialPortTerminal.Properties.Resources.search_96px;
            this.bunifuImageButton_Find.ImageActive = null;
            this.bunifuImageButton_Find.ImageLocation = null;
            this.bunifuImageButton_Find.ImageMargin = 0;
            this.bunifuImageButton_Find.ImageSize = new System.Drawing.Size(51, 51);
            this.bunifuImageButton_Find.ImageZoomSize = new System.Drawing.Size(51, 51);
            this.bunifuImageButton_Find.InitialImage = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton_Find.InitialImage")));
            this.bunifuImageButton_Find.Location = new System.Drawing.Point(648, 22);
            this.bunifuImageButton_Find.Margin = new System.Windows.Forms.Padding(0);
            this.bunifuImageButton_Find.Name = "bunifuImageButton_Find";
            this.bunifuImageButton_Find.Rotation = 0;
            this.bunifuImageButton_Find.ShowActiveImage = true;
            this.bunifuImageButton_Find.ShowCursorChanges = true;
            this.bunifuImageButton_Find.ShowImageBorders = true;
            this.bunifuImageButton_Find.ShowSizeMarkers = false;
            this.bunifuImageButton_Find.Size = new System.Drawing.Size(51, 51);
            this.bunifuImageButton_Find.TabIndex = 4;
            this.bunifuImageButton_Find.ToolTipText = "Search";
            this.bunifuImageButton_Find.WaitOnLoad = false;
            this.bunifuImageButton_Find.Zoom = 0;
            this.bunifuImageButton_Find.ZoomSpeed = 10;
            this.bunifuImageButton_Find.Click += new System.EventHandler(this.bunifuImageButton_Find_Click);
            // 
            // bunifuImageButton_SaveLog
            // 
            this.bunifuImageButton_SaveLog.ActiveImage = null;
            this.bunifuImageButton_SaveLog.AllowAnimations = true;
            this.bunifuImageButton_SaveLog.AllowBuffering = false;
            this.bunifuImageButton_SaveLog.AllowZooming = true;
            this.bunifuImageButton_SaveLog.BackColor = System.Drawing.Color.Gray;
            this.bunifuImageButton_SaveLog.ErrorImage = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton_SaveLog.ErrorImage")));
            this.bunifuImageButton_SaveLog.FadeWhenInactive = false;
            this.bunifuImageButton_SaveLog.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.bunifuImageButton_SaveLog.Image = global::SerialPortTerminal.Properties.Resources.save_as_96px;
            this.bunifuImageButton_SaveLog.ImageActive = null;
            this.bunifuImageButton_SaveLog.ImageLocation = null;
            this.bunifuImageButton_SaveLog.ImageMargin = 0;
            this.bunifuImageButton_SaveLog.ImageSize = new System.Drawing.Size(51, 51);
            this.bunifuImageButton_SaveLog.ImageZoomSize = new System.Drawing.Size(51, 51);
            this.bunifuImageButton_SaveLog.InitialImage = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton_SaveLog.InitialImage")));
            this.bunifuImageButton_SaveLog.Location = new System.Drawing.Point(324, 19);
            this.bunifuImageButton_SaveLog.Margin = new System.Windows.Forms.Padding(0);
            this.bunifuImageButton_SaveLog.Name = "bunifuImageButton_SaveLog";
            this.bunifuImageButton_SaveLog.Rotation = 0;
            this.bunifuImageButton_SaveLog.ShowActiveImage = true;
            this.bunifuImageButton_SaveLog.ShowCursorChanges = true;
            this.bunifuImageButton_SaveLog.ShowImageBorders = true;
            this.bunifuImageButton_SaveLog.ShowSizeMarkers = false;
            this.bunifuImageButton_SaveLog.Size = new System.Drawing.Size(51, 51);
            this.bunifuImageButton_SaveLog.TabIndex = 4;
            this.bunifuImageButton_SaveLog.Tag = "SaveStart";
            this.bunifuImageButton_SaveLog.ToolTipText = "Save Log Start";
            this.bunifuImageButton_SaveLog.WaitOnLoad = false;
            this.bunifuImageButton_SaveLog.Zoom = 0;
            this.bunifuImageButton_SaveLog.ZoomSpeed = 10;
            this.bunifuImageButton_SaveLog.Click += new System.EventHandler(this.bunifuImageButton_SaveLog_Click);
            // 
            // bunifuImageButton_Save
            // 
            this.bunifuImageButton_Save.ActiveImage = null;
            this.bunifuImageButton_Save.AllowAnimations = true;
            this.bunifuImageButton_Save.AllowBuffering = false;
            this.bunifuImageButton_Save.AllowZooming = true;
            this.bunifuImageButton_Save.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.bunifuImageButton_Save.BackColor = System.Drawing.Color.Gray;
            this.bunifuImageButton_Save.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.bunifuImageButton_Save.ErrorImage = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton_Save.ErrorImage")));
            this.bunifuImageButton_Save.FadeWhenInactive = false;
            this.bunifuImageButton_Save.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.bunifuImageButton_Save.Image = global::SerialPortTerminal.Properties.Resources.save_96px;
            this.bunifuImageButton_Save.ImageActive = null;
            this.bunifuImageButton_Save.ImageLocation = null;
            this.bunifuImageButton_Save.ImageMargin = 0;
            this.bunifuImageButton_Save.ImageSize = new System.Drawing.Size(51, 51);
            this.bunifuImageButton_Save.ImageZoomSize = new System.Drawing.Size(51, 51);
            this.bunifuImageButton_Save.InitialImage = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton_Save.InitialImage")));
            this.bunifuImageButton_Save.Location = new System.Drawing.Point(257, 19);
            this.bunifuImageButton_Save.Margin = new System.Windows.Forms.Padding(0);
            this.bunifuImageButton_Save.Name = "bunifuImageButton_Save";
            this.bunifuImageButton_Save.Rotation = 0;
            this.bunifuImageButton_Save.ShowActiveImage = true;
            this.bunifuImageButton_Save.ShowCursorChanges = true;
            this.bunifuImageButton_Save.ShowImageBorders = true;
            this.bunifuImageButton_Save.ShowSizeMarkers = false;
            this.bunifuImageButton_Save.Size = new System.Drawing.Size(51, 51);
            this.bunifuImageButton_Save.TabIndex = 4;
            this.bunifuImageButton_Save.ToolTipText = "Save Log for View";
            this.bunifuImageButton_Save.WaitOnLoad = false;
            this.bunifuImageButton_Save.Zoom = 0;
            this.bunifuImageButton_Save.ZoomSpeed = 10;
            this.bunifuImageButton_Save.Click += new System.EventHandler(this.bunifuImageButton_Save_Click);
            // 
            // bunifuImageButton_Clear
            // 
            this.bunifuImageButton_Clear.ActiveImage = null;
            this.bunifuImageButton_Clear.AllowAnimations = true;
            this.bunifuImageButton_Clear.AllowBuffering = false;
            this.bunifuImageButton_Clear.AllowZooming = true;
            this.bunifuImageButton_Clear.BackColor = System.Drawing.Color.Gray;
            this.bunifuImageButton_Clear.ErrorImage = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton_Clear.ErrorImage")));
            this.bunifuImageButton_Clear.FadeWhenInactive = false;
            this.bunifuImageButton_Clear.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.bunifuImageButton_Clear.Image = global::SerialPortTerminal.Properties.Resources.broom_96px;
            this.bunifuImageButton_Clear.ImageActive = null;
            this.bunifuImageButton_Clear.ImageLocation = null;
            this.bunifuImageButton_Clear.ImageMargin = 0;
            this.bunifuImageButton_Clear.ImageSize = new System.Drawing.Size(51, 51);
            this.bunifuImageButton_Clear.ImageZoomSize = new System.Drawing.Size(51, 51);
            this.bunifuImageButton_Clear.InitialImage = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton_Clear.InitialImage")));
            this.bunifuImageButton_Clear.Location = new System.Drawing.Point(725, 19);
            this.bunifuImageButton_Clear.Margin = new System.Windows.Forms.Padding(0);
            this.bunifuImageButton_Clear.Name = "bunifuImageButton_Clear";
            this.bunifuImageButton_Clear.Rotation = 0;
            this.bunifuImageButton_Clear.ShowActiveImage = true;
            this.bunifuImageButton_Clear.ShowCursorChanges = true;
            this.bunifuImageButton_Clear.ShowImageBorders = true;
            this.bunifuImageButton_Clear.ShowSizeMarkers = false;
            this.bunifuImageButton_Clear.Size = new System.Drawing.Size(51, 51);
            this.bunifuImageButton_Clear.TabIndex = 4;
            this.bunifuImageButton_Clear.ToolTipText = "Clear View";
            this.bunifuImageButton_Clear.WaitOnLoad = false;
            this.bunifuImageButton_Clear.Zoom = 0;
            this.bunifuImageButton_Clear.ZoomSpeed = 10;
            this.bunifuImageButton_Clear.Click += new System.EventHandler(this.bunifuImageButton_Clear_Click);
            // 
            // bunifuImageButton_ReFresh
            // 
            this.bunifuImageButton_ReFresh.ActiveImage = null;
            this.bunifuImageButton_ReFresh.AllowAnimations = true;
            this.bunifuImageButton_ReFresh.AllowBuffering = false;
            this.bunifuImageButton_ReFresh.AllowZooming = true;
            this.bunifuImageButton_ReFresh.BackColor = System.Drawing.Color.Gray;
            this.bunifuImageButton_ReFresh.ErrorImage = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton_ReFresh.ErrorImage")));
            this.bunifuImageButton_ReFresh.FadeWhenInactive = false;
            this.bunifuImageButton_ReFresh.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.bunifuImageButton_ReFresh.Image = global::SerialPortTerminal.Properties.Resources.refresh_96px;
            this.bunifuImageButton_ReFresh.ImageActive = null;
            this.bunifuImageButton_ReFresh.ImageLocation = null;
            this.bunifuImageButton_ReFresh.ImageMargin = 0;
            this.bunifuImageButton_ReFresh.ImageSize = new System.Drawing.Size(51, 51);
            this.bunifuImageButton_ReFresh.ImageZoomSize = new System.Drawing.Size(51, 51);
            this.bunifuImageButton_ReFresh.InitialImage = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton_ReFresh.InitialImage")));
            this.bunifuImageButton_ReFresh.Location = new System.Drawing.Point(197, 19);
            this.bunifuImageButton_ReFresh.Margin = new System.Windows.Forms.Padding(0);
            this.bunifuImageButton_ReFresh.Name = "bunifuImageButton_ReFresh";
            this.bunifuImageButton_ReFresh.Rotation = 0;
            this.bunifuImageButton_ReFresh.ShowActiveImage = true;
            this.bunifuImageButton_ReFresh.ShowCursorChanges = true;
            this.bunifuImageButton_ReFresh.ShowImageBorders = true;
            this.bunifuImageButton_ReFresh.ShowSizeMarkers = false;
            this.bunifuImageButton_ReFresh.Size = new System.Drawing.Size(51, 51);
            this.bunifuImageButton_ReFresh.TabIndex = 4;
            this.bunifuImageButton_ReFresh.ToolTipText = "refresh serial port";
            this.bunifuImageButton_ReFresh.WaitOnLoad = false;
            this.bunifuImageButton_ReFresh.Zoom = 0;
            this.bunifuImageButton_ReFresh.ZoomSpeed = 10;
            this.bunifuImageButton_ReFresh.Click += new System.EventHandler(this.bunifuImageButton_ReFresh_Click);
            // 
            // bunifuImageButton_StartStop
            // 
            this.bunifuImageButton_StartStop.ActiveImage = null;
            this.bunifuImageButton_StartStop.AllowAnimations = true;
            this.bunifuImageButton_StartStop.AllowBuffering = false;
            this.bunifuImageButton_StartStop.AllowZooming = true;
            this.bunifuImageButton_StartStop.BackColor = System.Drawing.Color.Gray;
            this.bunifuImageButton_StartStop.ErrorImage = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton_StartStop.ErrorImage")));
            this.bunifuImageButton_StartStop.FadeWhenInactive = false;
            this.bunifuImageButton_StartStop.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.bunifuImageButton_StartStop.Image = global::SerialPortTerminal.Properties.Resources.play_96px;
            this.bunifuImageButton_StartStop.ImageActive = null;
            this.bunifuImageButton_StartStop.ImageLocation = null;
            this.bunifuImageButton_StartStop.ImageMargin = 0;
            this.bunifuImageButton_StartStop.ImageSize = new System.Drawing.Size(51, 51);
            this.bunifuImageButton_StartStop.ImageZoomSize = new System.Drawing.Size(51, 51);
            this.bunifuImageButton_StartStop.InitialImage = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton_StartStop.InitialImage")));
            this.bunifuImageButton_StartStop.Location = new System.Drawing.Point(133, 19);
            this.bunifuImageButton_StartStop.Margin = new System.Windows.Forms.Padding(0);
            this.bunifuImageButton_StartStop.Name = "bunifuImageButton_StartStop";
            this.bunifuImageButton_StartStop.Rotation = 0;
            this.bunifuImageButton_StartStop.ShowActiveImage = true;
            this.bunifuImageButton_StartStop.ShowCursorChanges = true;
            this.bunifuImageButton_StartStop.ShowImageBorders = true;
            this.bunifuImageButton_StartStop.ShowSizeMarkers = false;
            this.bunifuImageButton_StartStop.Size = new System.Drawing.Size(51, 51);
            this.bunifuImageButton_StartStop.TabIndex = 4;
            this.bunifuImageButton_StartStop.Tag = "Start";
            this.bunifuImageButton_StartStop.ToolTipText = "Start Serial";
            this.bunifuImageButton_StartStop.WaitOnLoad = false;
            this.bunifuImageButton_StartStop.Zoom = 0;
            this.bunifuImageButton_StartStop.ZoomSpeed = 10;
            this.bunifuImageButton_StartStop.Click += new System.EventHandler(this.bunifuImageButton_StartStop_Click);
            // 
            // bunifuMaterialTextbox_Find
            // 
            this.bunifuMaterialTextbox_Find.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.bunifuMaterialTextbox_Find.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.bunifuMaterialTextbox_Find.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.bunifuMaterialTextbox_Find.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bunifuMaterialTextbox_Find.Font = new System.Drawing.Font("Calibri Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuMaterialTextbox_Find.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuMaterialTextbox_Find.HintForeColor = System.Drawing.Color.Empty;
            this.bunifuMaterialTextbox_Find.HintText = "";
            this.bunifuMaterialTextbox_Find.isPassword = false;
            this.bunifuMaterialTextbox_Find.LineFocusedColor = System.Drawing.Color.Blue;
            this.bunifuMaterialTextbox_Find.LineIdleColor = System.Drawing.Color.Gray;
            this.bunifuMaterialTextbox_Find.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.bunifuMaterialTextbox_Find.LineThickness = 3;
            this.bunifuMaterialTextbox_Find.Location = new System.Drawing.Point(435, 29);
            this.bunifuMaterialTextbox_Find.Margin = new System.Windows.Forms.Padding(4);
            this.bunifuMaterialTextbox_Find.MaxLength = 32767;
            this.bunifuMaterialTextbox_Find.Name = "bunifuMaterialTextbox_Find";
            this.bunifuMaterialTextbox_Find.Size = new System.Drawing.Size(209, 39);
            this.bunifuMaterialTextbox_Find.TabIndex = 10;
            this.bunifuMaterialTextbox_Find.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.bunifuMaterialTextbox_Find.OnValueChanged += new System.EventHandler(this.bunifuMaterialTextbox_Find_OnValueChanged);
            this.bunifuMaterialTextbox_Find.KeyDown += new System.Windows.Forms.KeyEventHandler(this.bunifuMaterialTextbox_Find_KeyDown);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.panel2.Controls.Add(this.bunifuTileButton__MinSize);
            this.panel2.Controls.Add(this.bunifuTileButton_MaxSize);
            this.panel2.Controls.Add(this.bunifuTileButton_Close);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1010, 30);
            this.panel2.TabIndex = 30;
            // 
            // bunifuTileButton__MinSize
            // 
            this.bunifuTileButton__MinSize.BackColor = System.Drawing.Color.Transparent;
            this.bunifuTileButton__MinSize.color = System.Drawing.Color.Transparent;
            this.bunifuTileButton__MinSize.colorActive = System.Drawing.Color.DimGray;
            this.bunifuTileButton__MinSize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTileButton__MinSize.Dock = System.Windows.Forms.DockStyle.Right;
            this.bunifuTileButton__MinSize.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuTileButton__MinSize.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bunifuTileButton__MinSize.Image = global::SerialPortTerminal.Properties.Resources.subtract_96px;
            this.bunifuTileButton__MinSize.ImagePosition = 3;
            this.bunifuTileButton__MinSize.ImageZoom = 80;
            this.bunifuTileButton__MinSize.LabelPosition = 0;
            this.bunifuTileButton__MinSize.LabelText = "";
            this.bunifuTileButton__MinSize.Location = new System.Drawing.Point(920, 0);
            this.bunifuTileButton__MinSize.Margin = new System.Windows.Forms.Padding(0);
            this.bunifuTileButton__MinSize.Name = "bunifuTileButton__MinSize";
            this.bunifuTileButton__MinSize.Size = new System.Drawing.Size(30, 30);
            this.bunifuTileButton__MinSize.TabIndex = 12;
            this.bunifuTileButton__MinSize.Tag = "open";
            this.bunifuTileButton__MinSize.Click += new System.EventHandler(this.bunifuTileButton__MinSize_Click);
            // 
            // bunifuTileButton_MaxSize
            // 
            this.bunifuTileButton_MaxSize.BackColor = System.Drawing.Color.Transparent;
            this.bunifuTileButton_MaxSize.color = System.Drawing.Color.Transparent;
            this.bunifuTileButton_MaxSize.colorActive = System.Drawing.Color.DimGray;
            this.bunifuTileButton_MaxSize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTileButton_MaxSize.Dock = System.Windows.Forms.DockStyle.Right;
            this.bunifuTileButton_MaxSize.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuTileButton_MaxSize.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bunifuTileButton_MaxSize.Image = global::SerialPortTerminal.Properties.Resources.maximize_button_96px;
            this.bunifuTileButton_MaxSize.ImagePosition = 3;
            this.bunifuTileButton_MaxSize.ImageZoom = 80;
            this.bunifuTileButton_MaxSize.LabelPosition = 0;
            this.bunifuTileButton_MaxSize.LabelText = "";
            this.bunifuTileButton_MaxSize.Location = new System.Drawing.Point(950, 0);
            this.bunifuTileButton_MaxSize.Margin = new System.Windows.Forms.Padding(0);
            this.bunifuTileButton_MaxSize.Name = "bunifuTileButton_MaxSize";
            this.bunifuTileButton_MaxSize.Size = new System.Drawing.Size(30, 30);
            this.bunifuTileButton_MaxSize.TabIndex = 12;
            this.bunifuTileButton_MaxSize.Tag = "open";
            this.bunifuTileButton_MaxSize.Click += new System.EventHandler(this.bunifuTileButton_MaxSize_Click);
            // 
            // bunifuTileButton_Close
            // 
            this.bunifuTileButton_Close.BackColor = System.Drawing.Color.Transparent;
            this.bunifuTileButton_Close.color = System.Drawing.Color.Transparent;
            this.bunifuTileButton_Close.colorActive = System.Drawing.Color.DimGray;
            this.bunifuTileButton_Close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTileButton_Close.Dock = System.Windows.Forms.DockStyle.Right;
            this.bunifuTileButton_Close.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuTileButton_Close.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bunifuTileButton_Close.Image = global::SerialPortTerminal.Properties.Resources.multiply_96px;
            this.bunifuTileButton_Close.ImagePosition = 3;
            this.bunifuTileButton_Close.ImageZoom = 80;
            this.bunifuTileButton_Close.LabelPosition = 0;
            this.bunifuTileButton_Close.LabelText = "";
            this.bunifuTileButton_Close.Location = new System.Drawing.Point(980, 0);
            this.bunifuTileButton_Close.Margin = new System.Windows.Forms.Padding(0);
            this.bunifuTileButton_Close.Name = "bunifuTileButton_Close";
            this.bunifuTileButton_Close.Size = new System.Drawing.Size(30, 30);
            this.bunifuTileButton_Close.TabIndex = 12;
            this.bunifuTileButton_Close.Tag = "open";
            this.bunifuTileButton_Close.Click += new System.EventHandler(this.bunifuTileButton_Close_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.panel4.Controls.Add(this.bunifuToggleSwitch_ENdLine);
            this.panel4.Controls.Add(this.bunifuImageButton_SaveLog);
            this.panel4.Controls.Add(this.bunifuDropdown__PortNum);
            this.panel4.Controls.Add(this.bunifuImageButton_Save);
            this.panel4.Controls.Add(this.bunifuDropdown__Speed);
            this.panel4.Controls.Add(this.bunifuImageButton_ReFresh);
            this.panel4.Controls.Add(this.bunifuImageButton_Find);
            this.panel4.Controls.Add(this.bunifuImageButton_StartStop);
            this.panel4.Controls.Add(this.bunifuMaterialTextbox_Find);
            this.panel4.Controls.Add(this.bunifuImageButton_Clear);
            this.panel4.Controls.Add(this.bunifuCustomLabel1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 30);
            this.panel4.Margin = new System.Windows.Forms.Padding(0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1010, 70);
            this.panel4.TabIndex = 33;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 617);
            this.panel3.Margin = new System.Windows.Forms.Padding(0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1010, 26);
            this.panel3.TabIndex = 34;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.richTextBox_View);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 100);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1010, 517);
            this.panel1.TabIndex = 35;
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // bunifuFormDock1
            // 
            this.bunifuFormDock1.AllowFormDragging = true;
            this.bunifuFormDock1.AllowFormDropShadow = true;
            this.bunifuFormDock1.AllowFormResizing = true;
            this.bunifuFormDock1.AllowHidingBottomRegion = true;
            this.bunifuFormDock1.AllowOpacityChangesWhileDragging = false;
            this.bunifuFormDock1.BorderOptions.BottomBorder.BorderColor = System.Drawing.Color.Silver;
            this.bunifuFormDock1.BorderOptions.BottomBorder.BorderThickness = 1;
            this.bunifuFormDock1.BorderOptions.BottomBorder.ShowBorder = true;
            this.bunifuFormDock1.BorderOptions.LeftBorder.BorderColor = System.Drawing.Color.Silver;
            this.bunifuFormDock1.BorderOptions.LeftBorder.BorderThickness = 1;
            this.bunifuFormDock1.BorderOptions.LeftBorder.ShowBorder = true;
            this.bunifuFormDock1.BorderOptions.RightBorder.BorderColor = System.Drawing.Color.Silver;
            this.bunifuFormDock1.BorderOptions.RightBorder.BorderThickness = 1;
            this.bunifuFormDock1.BorderOptions.RightBorder.ShowBorder = true;
            this.bunifuFormDock1.BorderOptions.TopBorder.BorderColor = System.Drawing.Color.Silver;
            this.bunifuFormDock1.BorderOptions.TopBorder.BorderThickness = 1;
            this.bunifuFormDock1.BorderOptions.TopBorder.ShowBorder = true;
            this.bunifuFormDock1.ContainerControl = this;
            this.bunifuFormDock1.DockingIndicatorsColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(215)))), ((int)(((byte)(233)))));
            this.bunifuFormDock1.DockingIndicatorsOpacity = 0.5D;
            this.bunifuFormDock1.DockingOptions.DockAll = true;
            this.bunifuFormDock1.DockingOptions.DockBottomLeft = true;
            this.bunifuFormDock1.DockingOptions.DockBottomRight = true;
            this.bunifuFormDock1.DockingOptions.DockFullScreen = true;
            this.bunifuFormDock1.DockingOptions.DockLeft = true;
            this.bunifuFormDock1.DockingOptions.DockRight = true;
            this.bunifuFormDock1.DockingOptions.DockTopLeft = true;
            this.bunifuFormDock1.DockingOptions.DockTopRight = true;
            this.bunifuFormDock1.FormDraggingOpacity = 0.9D;
            this.bunifuFormDock1.ParentForm = this;
            this.bunifuFormDock1.ShowCursorChanges = true;
            this.bunifuFormDock1.ShowDockingIndicators = true;
            this.bunifuFormDock1.TitleBarOptions.AllowFormDragging = true;
            this.bunifuFormDock1.TitleBarOptions.BunifuFormDock = this.bunifuFormDock1;
            this.bunifuFormDock1.TitleBarOptions.DoubleClickToExpandWindow = true;
            this.bunifuFormDock1.TitleBarOptions.TitleBarControl = this.panel2;
            this.bunifuFormDock1.TitleBarOptions.UseBackColorOnDockingIndicators = false;
            // 
            // bunifuToggleSwitch_ENdLine
            // 
            this.bunifuToggleSwitch_ENdLine.Animation = 5;
            this.bunifuToggleSwitch_ENdLine.BackColor = System.Drawing.Color.Transparent;
            this.bunifuToggleSwitch_ENdLine.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuToggleSwitch_ENdLine.BackgroundImage")));
            this.bunifuToggleSwitch_ENdLine.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuToggleSwitch_ENdLine.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuToggleSwitch_ENdLine.Location = new System.Drawing.Point(910, 47);
            this.bunifuToggleSwitch_ENdLine.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bunifuToggleSwitch_ENdLine.Name = "bunifuToggleSwitch_ENdLine";
            this.bunifuToggleSwitch_ENdLine.Size = new System.Drawing.Size(35, 19);
            this.bunifuToggleSwitch_ENdLine.TabIndex = 11;
            toggleState16.BackColor = System.Drawing.Color.Empty;
            toggleState16.BackColorInner = System.Drawing.Color.Empty;
            toggleState16.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(0)))), ((int)(((byte)(140)))));
            toggleState16.BorderColorInner = System.Drawing.Color.Empty;
            toggleState16.BorderRadius = 1;
            toggleState16.BorderRadiusInner = 1;
            toggleState16.BorderThickness = 1;
            toggleState16.BorderThicknessInner = 1;
            this.bunifuToggleSwitch_ENdLine.ToggleStateDisabled = toggleState16;
            toggleState17.BackColor = System.Drawing.Color.Empty;
            toggleState17.BackColorInner = System.Drawing.Color.Empty;
            toggleState17.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(0)))), ((int)(((byte)(140)))));
            toggleState17.BorderColorInner = System.Drawing.Color.Empty;
            toggleState17.BorderRadius = 1;
            toggleState17.BorderRadiusInner = 1;
            toggleState17.BorderThickness = 1;
            toggleState17.BorderThicknessInner = 1;
            this.bunifuToggleSwitch_ENdLine.ToggleStateOff = toggleState17;
            toggleState18.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(45)))), ((int)(((byte)(145)))));
            toggleState18.BackColorInner = System.Drawing.Color.White;
            toggleState18.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(45)))), ((int)(((byte)(145)))));
            toggleState18.BorderColorInner = System.Drawing.Color.White;
            toggleState18.BorderRadius = 17;
            toggleState18.BorderRadiusInner = 15;
            toggleState18.BorderThickness = 1;
            toggleState18.BorderThicknessInner = 1;
            this.bunifuToggleSwitch_ENdLine.ToggleStateOn = toggleState18;
            this.bunifuToggleSwitch_ENdLine.Value = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1010, 643);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Font = new System.Drawing.Font("Calibri Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Serial Port Terminal";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox_View;
        private Bunifu.UI.WinForms.BunifuImageButton bunifuImageButton_StartStop;
        private Bunifu.UI.WinForms.BunifuImageButton bunifuImageButton_ReFresh;
        private Bunifu.UI.WinForms.BunifuImageButton bunifuImageButton_Clear;
        private Bunifu.UI.WinForms.BunifuImageButton bunifuImageButton_Save;
        private Bunifu.UI.WinForms.BunifuImageButton bunifuImageButton_Find;
        private Bunifu.UI.WinForms.BunifuDropdown bunifuDropdown__Speed;
        private Bunifu.UI.WinForms.BunifuDropdown bunifuDropdown__PortNum;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.UI.WinForms.BunifuImageButton bunifuImageButton_SaveLog;
        private Bunifu.Framework.UI.BunifuMaterialTextbox bunifuMaterialTextbox_Find;
        private System.Windows.Forms.Panel panel2;
        private Bunifu.Framework.UI.BunifuTileButton bunifuTileButton__MinSize;
        private Bunifu.Framework.UI.BunifuTileButton bunifuTileButton_MaxSize;
        private Bunifu.Framework.UI.BunifuTileButton bunifuTileButton_Close;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        public Bunifu.UI.WinForms.BunifuFormDock bunifuFormDock1;
        private Bunifu.ToggleSwitch.BunifuToggleSwitch bunifuToggleSwitch_ENdLine;
    }
}

