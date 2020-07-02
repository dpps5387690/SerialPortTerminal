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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.richTextBox_View = new System.Windows.Forms.RichTextBox();
            this.bunifuDropdown__Speed = new Bunifu.UI.WinForms.BunifuDropdown();
            this.bunifuDropdown__PortNum = new Bunifu.UI.WinForms.BunifuDropdown();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCheckBox_ENdLine = new Bunifu.UI.WinForms.BunifuCheckBox();
            this.bunifuImageButto_Find = new Bunifu.UI.WinForms.BunifuImageButton();
            this.bunifuImageButton_SaveLog = new Bunifu.UI.WinForms.BunifuImageButton();
            this.bunifuImageButton_Save = new Bunifu.UI.WinForms.BunifuImageButton();
            this.bunifuImageButton_Clear = new Bunifu.UI.WinForms.BunifuImageButton();
            this.bunifuImageButton_ReFresh = new Bunifu.UI.WinForms.BunifuImageButton();
            this.bunifuImageButton_StartStop = new Bunifu.UI.WinForms.BunifuImageButton();
            this.bunifuMaterialTextbox_Find = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.SuspendLayout();
            // 
            // richTextBox_View
            // 
            this.richTextBox_View.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBox_View.Location = new System.Drawing.Point(4, 98);
            this.richTextBox_View.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.richTextBox_View.Name = "richTextBox_View";
            this.richTextBox_View.ReadOnly = true;
            this.richTextBox_View.Size = new System.Drawing.Size(1005, 543);
            this.richTextBox_View.TabIndex = 0;
            this.richTextBox_View.Text = "";
            // 
            // bunifuDropdown__Speed
            // 
            this.bunifuDropdown__Speed.BackColor = System.Drawing.SystemColors.Control;
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
            this.bunifuDropdown__Speed.Location = new System.Drawing.Point(4, 54);
            this.bunifuDropdown__Speed.Name = "bunifuDropdown__Speed";
            this.bunifuDropdown__Speed.Size = new System.Drawing.Size(121, 32);
            this.bunifuDropdown__Speed.TabIndex = 5;
            this.bunifuDropdown__Speed.Text = "57600";
            // 
            // bunifuDropdown__PortNum
            // 
            this.bunifuDropdown__PortNum.BackColor = System.Drawing.SystemColors.Control;
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
            this.bunifuDropdown__PortNum.Location = new System.Drawing.Point(4, 12);
            this.bunifuDropdown__PortNum.Name = "bunifuDropdown__PortNum";
            this.bunifuDropdown__PortNum.Size = new System.Drawing.Size(121, 32);
            this.bunifuDropdown__PortNum.TabIndex = 6;
            this.bunifuDropdown__PortNum.Text = null;
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(945, 57);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(64, 19);
            this.bunifuCustomLabel1.TabIndex = 8;
            this.bunifuCustomLabel1.Text = "End Line";
            // 
            // bunifuCheckBox_ENdLine
            // 
            this.bunifuCheckBox_ENdLine.AllowBindingControlAnimation = true;
            this.bunifuCheckBox_ENdLine.AllowBindingControlColorChanges = false;
            this.bunifuCheckBox_ENdLine.AllowBindingControlLocation = true;
            this.bunifuCheckBox_ENdLine.AllowCheckBoxAnimation = false;
            this.bunifuCheckBox_ENdLine.AllowCheckmarkAnimation = true;
            this.bunifuCheckBox_ENdLine.AllowOnHoverStates = true;
            this.bunifuCheckBox_ENdLine.AutoCheck = true;
            this.bunifuCheckBox_ENdLine.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCheckBox_ENdLine.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuCheckBox_ENdLine.BackgroundImage")));
            this.bunifuCheckBox_ENdLine.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bunifuCheckBox_ENdLine.BindingControl = null;
            this.bunifuCheckBox_ENdLine.BindingControlPosition = Bunifu.UI.WinForms.BunifuCheckBox.BindingControlPositions.Right;
            this.bunifuCheckBox_ENdLine.Checked = true;
            this.bunifuCheckBox_ENdLine.CheckState = Bunifu.UI.WinForms.BunifuCheckBox.CheckStates.Checked;
            this.bunifuCheckBox_ENdLine.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuCheckBox_ENdLine.CustomCheckmarkImage = null;
            this.bunifuCheckBox_ENdLine.Location = new System.Drawing.Point(918, 55);
            this.bunifuCheckBox_ENdLine.MinimumSize = new System.Drawing.Size(17, 17);
            this.bunifuCheckBox_ENdLine.Name = "bunifuCheckBox_ENdLine";
            this.bunifuCheckBox_ENdLine.OnCheck.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(69)))), ((int)(((byte)(155)))));
            this.bunifuCheckBox_ENdLine.OnCheck.BorderRadius = 2;
            this.bunifuCheckBox_ENdLine.OnCheck.BorderThickness = 2;
            this.bunifuCheckBox_ENdLine.OnCheck.CheckBoxColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(69)))), ((int)(((byte)(155)))));
            this.bunifuCheckBox_ENdLine.OnCheck.CheckmarkColor = System.Drawing.Color.White;
            this.bunifuCheckBox_ENdLine.OnCheck.CheckmarkThickness = 2;
            this.bunifuCheckBox_ENdLine.OnDisable.BorderColor = System.Drawing.Color.LightGray;
            this.bunifuCheckBox_ENdLine.OnDisable.BorderRadius = 2;
            this.bunifuCheckBox_ENdLine.OnDisable.BorderThickness = 2;
            this.bunifuCheckBox_ENdLine.OnDisable.CheckBoxColor = System.Drawing.Color.Transparent;
            this.bunifuCheckBox_ENdLine.OnDisable.CheckmarkColor = System.Drawing.Color.LightGray;
            this.bunifuCheckBox_ENdLine.OnDisable.CheckmarkThickness = 2;
            this.bunifuCheckBox_ENdLine.OnHoverChecked.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(131)))), ((int)(((byte)(188)))));
            this.bunifuCheckBox_ENdLine.OnHoverChecked.BorderRadius = 2;
            this.bunifuCheckBox_ENdLine.OnHoverChecked.BorderThickness = 2;
            this.bunifuCheckBox_ENdLine.OnHoverChecked.CheckBoxColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(131)))), ((int)(((byte)(188)))));
            this.bunifuCheckBox_ENdLine.OnHoverChecked.CheckmarkColor = System.Drawing.Color.White;
            this.bunifuCheckBox_ENdLine.OnHoverChecked.CheckmarkThickness = 2;
            this.bunifuCheckBox_ENdLine.OnHoverUnchecked.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(131)))), ((int)(((byte)(188)))));
            this.bunifuCheckBox_ENdLine.OnHoverUnchecked.BorderRadius = 2;
            this.bunifuCheckBox_ENdLine.OnHoverUnchecked.BorderThickness = 2;
            this.bunifuCheckBox_ENdLine.OnHoverUnchecked.CheckBoxColor = System.Drawing.Color.Transparent;
            this.bunifuCheckBox_ENdLine.OnUncheck.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(69)))), ((int)(((byte)(155)))));
            this.bunifuCheckBox_ENdLine.OnUncheck.BorderRadius = 2;
            this.bunifuCheckBox_ENdLine.OnUncheck.BorderThickness = 2;
            this.bunifuCheckBox_ENdLine.OnUncheck.CheckBoxColor = System.Drawing.Color.Transparent;
            this.bunifuCheckBox_ENdLine.Size = new System.Drawing.Size(21, 21);
            this.bunifuCheckBox_ENdLine.Style = Bunifu.UI.WinForms.BunifuCheckBox.CheckBoxStyles.Bunifu;
            this.bunifuCheckBox_ENdLine.TabIndex = 9;
            this.bunifuCheckBox_ENdLine.ThreeState = false;
            this.bunifuCheckBox_ENdLine.ToolTipText = null;
            // 
            // bunifuImageButto_Find
            // 
            this.bunifuImageButto_Find.ActiveImage = null;
            this.bunifuImageButto_Find.AllowAnimations = true;
            this.bunifuImageButto_Find.AllowBuffering = false;
            this.bunifuImageButto_Find.AllowZooming = true;
            this.bunifuImageButto_Find.BackColor = System.Drawing.Color.Gray;
            this.bunifuImageButto_Find.ErrorImage = ((System.Drawing.Image)(resources.GetObject("bunifuImageButto_Find.ErrorImage")));
            this.bunifuImageButto_Find.FadeWhenInactive = false;
            this.bunifuImageButto_Find.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.bunifuImageButto_Find.Image = global::SerialPortTerminal.Properties.Resources.search_96px;
            this.bunifuImageButto_Find.ImageActive = null;
            this.bunifuImageButto_Find.ImageLocation = null;
            this.bunifuImageButto_Find.ImageMargin = 0;
            this.bunifuImageButto_Find.ImageSize = new System.Drawing.Size(51, 51);
            this.bunifuImageButto_Find.ImageZoomSize = new System.Drawing.Size(51, 51);
            this.bunifuImageButto_Find.InitialImage = ((System.Drawing.Image)(resources.GetObject("bunifuImageButto_Find.InitialImage")));
            this.bunifuImageButto_Find.Location = new System.Drawing.Point(692, 21);
            this.bunifuImageButto_Find.Margin = new System.Windows.Forms.Padding(0);
            this.bunifuImageButto_Find.Name = "bunifuImageButto_Find";
            this.bunifuImageButto_Find.Rotation = 0;
            this.bunifuImageButto_Find.ShowActiveImage = true;
            this.bunifuImageButto_Find.ShowCursorChanges = true;
            this.bunifuImageButto_Find.ShowImageBorders = true;
            this.bunifuImageButto_Find.ShowSizeMarkers = false;
            this.bunifuImageButto_Find.Size = new System.Drawing.Size(51, 51);
            this.bunifuImageButto_Find.TabIndex = 4;
            this.bunifuImageButto_Find.ToolTipText = "";
            this.bunifuImageButto_Find.WaitOnLoad = false;
            this.bunifuImageButto_Find.Zoom = 0;
            this.bunifuImageButto_Find.ZoomSpeed = 10;
            this.bunifuImageButto_Find.Click += new System.EventHandler(this.bunifuImageButto_Find_Click);
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
            this.bunifuImageButton_SaveLog.ImageSize = new System.Drawing.Size(50, 50);
            this.bunifuImageButton_SaveLog.ImageZoomSize = new System.Drawing.Size(50, 50);
            this.bunifuImageButton_SaveLog.InitialImage = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton_SaveLog.InitialImage")));
            this.bunifuImageButton_SaveLog.Location = new System.Drawing.Point(348, 22);
            this.bunifuImageButton_SaveLog.Margin = new System.Windows.Forms.Padding(0);
            this.bunifuImageButton_SaveLog.Name = "bunifuImageButton_SaveLog";
            this.bunifuImageButton_SaveLog.Rotation = 0;
            this.bunifuImageButton_SaveLog.ShowActiveImage = true;
            this.bunifuImageButton_SaveLog.ShowCursorChanges = true;
            this.bunifuImageButton_SaveLog.ShowImageBorders = true;
            this.bunifuImageButton_SaveLog.ShowSizeMarkers = false;
            this.bunifuImageButton_SaveLog.Size = new System.Drawing.Size(50, 50);
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
            this.bunifuImageButton_Save.Location = new System.Drawing.Point(283, 21);
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
            this.bunifuImageButton_Clear.Location = new System.Drawing.Point(847, 21);
            this.bunifuImageButton_Clear.Margin = new System.Windows.Forms.Padding(0);
            this.bunifuImageButton_Clear.Name = "bunifuImageButton_Clear";
            this.bunifuImageButton_Clear.Rotation = 0;
            this.bunifuImageButton_Clear.ShowActiveImage = true;
            this.bunifuImageButton_Clear.ShowCursorChanges = true;
            this.bunifuImageButton_Clear.ShowImageBorders = true;
            this.bunifuImageButton_Clear.ShowSizeMarkers = false;
            this.bunifuImageButton_Clear.Size = new System.Drawing.Size(51, 51);
            this.bunifuImageButton_Clear.TabIndex = 4;
            this.bunifuImageButton_Clear.ToolTipText = "refresh serial port";
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
            this.bunifuImageButton_ReFresh.Location = new System.Drawing.Point(216, 21);
            this.bunifuImageButton_ReFresh.Margin = new System.Windows.Forms.Padding(0);
            this.bunifuImageButton_ReFresh.Name = "bunifuImageButton_ReFresh";
            this.bunifuImageButton_ReFresh.Rotation = 0;
            this.bunifuImageButton_ReFresh.ShowActiveImage = true;
            this.bunifuImageButton_ReFresh.ShowCursorChanges = true;
            this.bunifuImageButton_ReFresh.ShowImageBorders = true;
            this.bunifuImageButton_ReFresh.ShowSizeMarkers = false;
            this.bunifuImageButton_ReFresh.Size = new System.Drawing.Size(51, 51);
            this.bunifuImageButton_ReFresh.TabIndex = 4;
            this.bunifuImageButton_ReFresh.ToolTipText = "";
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
            this.bunifuImageButton_StartStop.Location = new System.Drawing.Point(152, 21);
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
            this.bunifuMaterialTextbox_Find.Location = new System.Drawing.Point(479, 33);
            this.bunifuMaterialTextbox_Find.Margin = new System.Windows.Forms.Padding(4);
            this.bunifuMaterialTextbox_Find.MaxLength = 32767;
            this.bunifuMaterialTextbox_Find.Name = "bunifuMaterialTextbox_Find";
            this.bunifuMaterialTextbox_Find.Size = new System.Drawing.Size(209, 39);
            this.bunifuMaterialTextbox_Find.TabIndex = 10;
            this.bunifuMaterialTextbox_Find.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.bunifuMaterialTextbox_Find.OnValueChanged += new System.EventHandler(this.bunifuMaterialTextbox_Find_OnValueChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1010, 643);
            this.Controls.Add(this.bunifuMaterialTextbox_Find);
            this.Controls.Add(this.bunifuCheckBox_ENdLine);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.Controls.Add(this.bunifuDropdown__PortNum);
            this.Controls.Add(this.bunifuDropdown__Speed);
            this.Controls.Add(this.bunifuImageButto_Find);
            this.Controls.Add(this.bunifuImageButton_SaveLog);
            this.Controls.Add(this.bunifuImageButton_Save);
            this.Controls.Add(this.bunifuImageButton_Clear);
            this.Controls.Add(this.bunifuImageButton_ReFresh);
            this.Controls.Add(this.bunifuImageButton_StartStop);
            this.Controls.Add(this.richTextBox_View);
            this.Font = new System.Drawing.Font("Calibri Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Serial Port Terminal";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox_View;
        private Bunifu.UI.WinForms.BunifuImageButton bunifuImageButton_StartStop;
        private Bunifu.UI.WinForms.BunifuImageButton bunifuImageButton_ReFresh;
        private Bunifu.UI.WinForms.BunifuImageButton bunifuImageButton_Clear;
        private Bunifu.UI.WinForms.BunifuImageButton bunifuImageButton_Save;
        private Bunifu.UI.WinForms.BunifuImageButton bunifuImageButto_Find;
        private Bunifu.UI.WinForms.BunifuDropdown bunifuDropdown__Speed;
        private Bunifu.UI.WinForms.BunifuDropdown bunifuDropdown__PortNum;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.UI.WinForms.BunifuCheckBox bunifuCheckBox_ENdLine;
        private Bunifu.UI.WinForms.BunifuImageButton bunifuImageButton_SaveLog;
        private Bunifu.Framework.UI.BunifuMaterialTextbox bunifuMaterialTextbox_Find;
    }
}

