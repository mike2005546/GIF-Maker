
namespace FFmpegGUI
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
            this.pnlNav = new System.Windows.Forms.Panel();
            this.pbIcon = new System.Windows.Forms.PictureBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.pnlButtonBar = new System.Windows.Forms.Panel();
            this.btnConvert = new System.Windows.Forms.Button();
            this.lblLine2 = new System.Windows.Forms.Label();
            this.btnPickVideo = new System.Windows.Forms.Button();
            this.lblSource = new System.Windows.Forms.Label();
            this.lblDirectory = new System.Windows.Forms.Label();
            this.gbSetting = new System.Windows.Forms.GroupBox();
            this.cbSkipSecond = new System.Windows.Forms.CheckBox();
            this.cbGiflength = new System.Windows.Forms.CheckBox();
            this.nudGIFlength = new System.Windows.Forms.NumericUpDown();
            this.lblGIFlength = new System.Windows.Forms.Label();
            this.cbLoopType = new System.Windows.Forms.ComboBox();
            this.lblLoopType = new System.Windows.Forms.Label();
            this.nudSkipSecond = new System.Windows.Forms.NumericUpDown();
            this.lblSkipSecond = new System.Windows.Forms.Label();
            this.nudFPS = new System.Windows.Forms.NumericUpDown();
            this.lblFPS = new System.Windows.Forms.Label();
            this.lblHeight = new System.Windows.Forms.Label();
            this.lblWidth = new System.Windows.Forms.Label();
            this.nudHeight = new System.Windows.Forms.NumericUpDown();
            this.nudWidth = new System.Windows.Forms.NumericUpDown();
            this.lblOutputName = new System.Windows.Forms.Label();
            this.tbOutputName = new System.Windows.Forms.TextBox();
            this.fileDialog = new System.Windows.Forms.OpenFileDialog();
            this.lblOutputDirectory = new System.Windows.Forms.Label();
            this.tbOutputDirectory = new System.Windows.Forms.TextBox();
            this.btnOutputDirectory = new System.Windows.Forms.Button();
            this.rtbCmdOutput = new System.Windows.Forms.RichTextBox();
            this.pnlNav.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbIcon)).BeginInit();
            this.pnlButtonBar.SuspendLayout();
            this.gbSetting.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudGIFlength)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSkipSecond)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudFPS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudHeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudWidth)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlNav
            // 
            this.pnlNav.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.pnlNav.Controls.Add(this.pbIcon);
            this.pnlNav.Controls.Add(this.lblTitle);
            this.pnlNav.Controls.Add(this.btnMinimize);
            this.pnlNav.Controls.Add(this.btnExit);
            this.pnlNav.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlNav.Location = new System.Drawing.Point(0, 0);
            this.pnlNav.Name = "pnlNav";
            this.pnlNav.Size = new System.Drawing.Size(600, 30);
            this.pnlNav.TabIndex = 0;
            // 
            // pbIcon
            // 
            this.pbIcon.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.icons8_gif_20px;
            this.pbIcon.Location = new System.Drawing.Point(8, 5);
            this.pbIcon.Name = "pbIcon";
            this.pbIcon.Size = new System.Drawing.Size(20, 20);
            this.pbIcon.TabIndex = 3;
            this.pbIcon.TabStop = false;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(34, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(50, 13);
            this.lblTitle.TabIndex = 2;
            this.lblTitle.Text = "GifMaker";
            // 
            // btnMinimize
            // 
            this.btnMinimize.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.icons8_subtract_15px_1;
            this.btnMinimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnMinimize.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnMinimize.FlatAppearance.BorderSize = 0;
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.Location = new System.Drawing.Point(510, 0);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(45, 30);
            this.btnMinimize.TabIndex = 1;
            this.btnMinimize.UseVisualStyleBackColor = true;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.icons8_multiply_15px;
            this.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnExit.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Location = new System.Drawing.Point(555, 0);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(45, 30);
            this.btnExit.TabIndex = 0;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // pnlButtonBar
            // 
            this.pnlButtonBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.pnlButtonBar.Controls.Add(this.btnConvert);
            this.pnlButtonBar.Controls.Add(this.lblLine2);
            this.pnlButtonBar.Controls.Add(this.btnPickVideo);
            this.pnlButtonBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlButtonBar.Location = new System.Drawing.Point(0, 30);
            this.pnlButtonBar.Name = "pnlButtonBar";
            this.pnlButtonBar.Size = new System.Drawing.Size(600, 40);
            this.pnlButtonBar.TabIndex = 2;
            // 
            // btnConvert
            // 
            this.btnConvert.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnConvert.FlatAppearance.BorderSize = 0;
            this.btnConvert.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConvert.Image = global::WindowsFormsApp1.Properties.Resources.convert2;
            this.btnConvert.Location = new System.Drawing.Point(101, 0);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(100, 40);
            this.btnConvert.TabIndex = 3;
            this.btnConvert.Text = "Convert";
            this.btnConvert.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnConvert.UseVisualStyleBackColor = true;
            this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);
            // 
            // lblLine2
            // 
            this.lblLine2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblLine2.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblLine2.Location = new System.Drawing.Point(100, 0);
            this.lblLine2.Name = "lblLine2";
            this.lblLine2.Size = new System.Drawing.Size(1, 40);
            this.lblLine2.TabIndex = 2;
            // 
            // btnPickVideo
            // 
            this.btnPickVideo.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnPickVideo.FlatAppearance.BorderSize = 0;
            this.btnPickVideo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPickVideo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btnPickVideo.Image = global::WindowsFormsApp1.Properties.Resources.folder;
            this.btnPickVideo.Location = new System.Drawing.Point(0, 0);
            this.btnPickVideo.Name = "btnPickVideo";
            this.btnPickVideo.Size = new System.Drawing.Size(100, 40);
            this.btnPickVideo.TabIndex = 1;
            this.btnPickVideo.Text = "Browse";
            this.btnPickVideo.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnPickVideo.UseVisualStyleBackColor = true;
            this.btnPickVideo.Click += new System.EventHandler(this.btnPickVideo_Click);
            // 
            // lblSource
            // 
            this.lblSource.AutoSize = true;
            this.lblSource.Location = new System.Drawing.Point(12, 88);
            this.lblSource.Name = "lblSource";
            this.lblSource.Size = new System.Drawing.Size(47, 13);
            this.lblSource.TabIndex = 3;
            this.lblSource.Text = "Source: ";
            // 
            // lblDirectory
            // 
            this.lblDirectory.AutoSize = true;
            this.lblDirectory.Location = new System.Drawing.Point(105, 88);
            this.lblDirectory.Name = "lblDirectory";
            this.lblDirectory.Size = new System.Drawing.Size(0, 13);
            this.lblDirectory.TabIndex = 4;
            // 
            // gbSetting
            // 
            this.gbSetting.Controls.Add(this.cbSkipSecond);
            this.gbSetting.Controls.Add(this.cbGiflength);
            this.gbSetting.Controls.Add(this.nudGIFlength);
            this.gbSetting.Controls.Add(this.lblGIFlength);
            this.gbSetting.Controls.Add(this.cbLoopType);
            this.gbSetting.Controls.Add(this.lblLoopType);
            this.gbSetting.Controls.Add(this.nudSkipSecond);
            this.gbSetting.Controls.Add(this.lblSkipSecond);
            this.gbSetting.Controls.Add(this.nudFPS);
            this.gbSetting.Controls.Add(this.lblFPS);
            this.gbSetting.Controls.Add(this.lblHeight);
            this.gbSetting.Controls.Add(this.lblWidth);
            this.gbSetting.Controls.Add(this.nudHeight);
            this.gbSetting.Controls.Add(this.nudWidth);
            this.gbSetting.ForeColor = System.Drawing.Color.White;
            this.gbSetting.Location = new System.Drawing.Point(15, 194);
            this.gbSetting.Name = "gbSetting";
            this.gbSetting.Size = new System.Drawing.Size(416, 161);
            this.gbSetting.TabIndex = 5;
            this.gbSetting.TabStop = false;
            this.gbSetting.Text = "Setting";
            // 
            // cbSkipSecond
            // 
            this.cbSkipSecond.AutoSize = true;
            this.cbSkipSecond.Location = new System.Drawing.Point(365, 114);
            this.cbSkipSecond.Name = "cbSkipSecond";
            this.cbSkipSecond.Size = new System.Drawing.Size(15, 14);
            this.cbSkipSecond.TabIndex = 15;
            this.cbSkipSecond.UseVisualStyleBackColor = true;
            // 
            // cbGiflength
            // 
            this.cbGiflength.AutoSize = true;
            this.cbGiflength.Location = new System.Drawing.Point(365, 76);
            this.cbGiflength.Name = "cbGiflength";
            this.cbGiflength.Size = new System.Drawing.Size(15, 14);
            this.cbGiflength.TabIndex = 14;
            this.cbGiflength.UseVisualStyleBackColor = true;
            // 
            // nudGIFlength
            // 
            this.nudGIFlength.Enabled = false;
            this.nudGIFlength.Location = new System.Drawing.Point(290, 74);
            this.nudGIFlength.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudGIFlength.Name = "nudGIFlength";
            this.nudGIFlength.Size = new System.Drawing.Size(65, 20);
            this.nudGIFlength.TabIndex = 13;
            this.nudGIFlength.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblGIFlength
            // 
            this.lblGIFlength.AutoSize = true;
            this.lblGIFlength.Location = new System.Drawing.Point(213, 76);
            this.lblGIFlength.Name = "lblGIFlength";
            this.lblGIFlength.Size = new System.Drawing.Size(59, 13);
            this.lblGIFlength.TabIndex = 12;
            this.lblGIFlength.Text = "GIF length:";
            // 
            // cbLoopType
            // 
            this.cbLoopType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLoopType.FormattingEnabled = true;
            this.cbLoopType.Items.AddRange(new object[] {
            "Infinite Loop",
            "Loop Once",
            "No Loop"});
            this.cbLoopType.Location = new System.Drawing.Point(280, 35);
            this.cbLoopType.Name = "cbLoopType";
            this.cbLoopType.Size = new System.Drawing.Size(100, 21);
            this.cbLoopType.TabIndex = 11;
            // 
            // lblLoopType
            // 
            this.lblLoopType.AutoSize = true;
            this.lblLoopType.Location = new System.Drawing.Point(213, 38);
            this.lblLoopType.Name = "lblLoopType";
            this.lblLoopType.Size = new System.Drawing.Size(61, 13);
            this.lblLoopType.TabIndex = 10;
            this.lblLoopType.Text = "Loop Type:";
            // 
            // nudSkipSecond
            // 
            this.nudSkipSecond.Enabled = false;
            this.nudSkipSecond.Location = new System.Drawing.Point(290, 112);
            this.nudSkipSecond.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudSkipSecond.Name = "nudSkipSecond";
            this.nudSkipSecond.Size = new System.Drawing.Size(65, 20);
            this.nudSkipSecond.TabIndex = 9;
            this.nudSkipSecond.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblSkipSecond
            // 
            this.lblSkipSecond.AutoSize = true;
            this.lblSkipSecond.Location = new System.Drawing.Point(213, 114);
            this.lblSkipSecond.Name = "lblSkipSecond";
            this.lblSkipSecond.Size = new System.Drawing.Size(71, 13);
            this.lblSkipSecond.TabIndex = 8;
            this.lblSkipSecond.Text = "Skip Second:";
            // 
            // nudFPS
            // 
            this.nudFPS.Location = new System.Drawing.Point(96, 112);
            this.nudFPS.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.nudFPS.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudFPS.Name = "nudFPS";
            this.nudFPS.Size = new System.Drawing.Size(65, 20);
            this.nudFPS.TabIndex = 7;
            this.nudFPS.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            // 
            // lblFPS
            // 
            this.lblFPS.AutoSize = true;
            this.lblFPS.Location = new System.Drawing.Point(19, 114);
            this.lblFPS.Name = "lblFPS";
            this.lblFPS.Size = new System.Drawing.Size(30, 13);
            this.lblFPS.TabIndex = 6;
            this.lblFPS.Text = "FPS:";
            // 
            // lblHeight
            // 
            this.lblHeight.AutoSize = true;
            this.lblHeight.Location = new System.Drawing.Point(19, 76);
            this.lblHeight.Name = "lblHeight";
            this.lblHeight.Size = new System.Drawing.Size(41, 13);
            this.lblHeight.TabIndex = 5;
            this.lblHeight.Text = "Height:";
            // 
            // lblWidth
            // 
            this.lblWidth.AutoSize = true;
            this.lblWidth.Location = new System.Drawing.Point(19, 38);
            this.lblWidth.Name = "lblWidth";
            this.lblWidth.Size = new System.Drawing.Size(38, 13);
            this.lblWidth.TabIndex = 4;
            this.lblWidth.Text = "Width:";
            // 
            // nudHeight
            // 
            this.nudHeight.Location = new System.Drawing.Point(96, 74);
            this.nudHeight.Maximum = new decimal(new int[] {
            1080,
            0,
            0,
            0});
            this.nudHeight.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.nudHeight.Name = "nudHeight";
            this.nudHeight.Size = new System.Drawing.Size(65, 20);
            this.nudHeight.TabIndex = 3;
            this.nudHeight.Value = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            // 
            // nudWidth
            // 
            this.nudWidth.Location = new System.Drawing.Point(96, 36);
            this.nudWidth.Maximum = new decimal(new int[] {
            1920,
            0,
            0,
            0});
            this.nudWidth.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.nudWidth.Name = "nudWidth";
            this.nudWidth.Size = new System.Drawing.Size(65, 20);
            this.nudWidth.TabIndex = 2;
            this.nudWidth.Value = new decimal(new int[] {
            300,
            0,
            0,
            0});
            // 
            // lblOutputName
            // 
            this.lblOutputName.AutoSize = true;
            this.lblOutputName.Location = new System.Drawing.Point(12, 123);
            this.lblOutputName.Name = "lblOutputName";
            this.lblOutputName.Size = new System.Drawing.Size(73, 13);
            this.lblOutputName.TabIndex = 6;
            this.lblOutputName.Text = "Output Name:";
            // 
            // tbOutputName
            // 
            this.tbOutputName.Location = new System.Drawing.Point(105, 120);
            this.tbOutputName.Name = "tbOutputName";
            this.tbOutputName.Size = new System.Drawing.Size(399, 20);
            this.tbOutputName.TabIndex = 7;
            // 
            // fileDialog
            // 
            this.fileDialog.FileName = "openFileDialog";
            // 
            // lblOutputDirectory
            // 
            this.lblOutputDirectory.AutoSize = true;
            this.lblOutputDirectory.Location = new System.Drawing.Point(12, 159);
            this.lblOutputDirectory.Name = "lblOutputDirectory";
            this.lblOutputDirectory.Size = new System.Drawing.Size(87, 13);
            this.lblOutputDirectory.TabIndex = 9;
            this.lblOutputDirectory.Text = "Output Directory:";
            // 
            // tbOutputDirectory
            // 
            this.tbOutputDirectory.Location = new System.Drawing.Point(105, 156);
            this.tbOutputDirectory.Name = "tbOutputDirectory";
            this.tbOutputDirectory.ReadOnly = true;
            this.tbOutputDirectory.Size = new System.Drawing.Size(399, 20);
            this.tbOutputDirectory.TabIndex = 10;
            // 
            // btnOutputDirectory
            // 
            this.btnOutputDirectory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.btnOutputDirectory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOutputDirectory.Location = new System.Drawing.Point(515, 154);
            this.btnOutputDirectory.Name = "btnOutputDirectory";
            this.btnOutputDirectory.Size = new System.Drawing.Size(70, 23);
            this.btnOutputDirectory.TabIndex = 11;
            this.btnOutputDirectory.Text = "Browse";
            this.btnOutputDirectory.UseVisualStyleBackColor = false;
            this.btnOutputDirectory.Click += new System.EventHandler(this.btnOutputDirectory_Click);
            // 
            // rtbCmdOutput
            // 
            this.rtbCmdOutput.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.rtbCmdOutput.ForeColor = System.Drawing.SystemColors.Control;
            this.rtbCmdOutput.Location = new System.Drawing.Point(15, 374);
            this.rtbCmdOutput.Name = "rtbCmdOutput";
            this.rtbCmdOutput.ReadOnly = true;
            this.rtbCmdOutput.Size = new System.Drawing.Size(570, 184);
            this.rtbCmdOutput.TabIndex = 13;
            this.rtbCmdOutput.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(41)))), ((int)(((byte)(60)))));
            this.ClientSize = new System.Drawing.Size(600, 570);
            this.Controls.Add(this.rtbCmdOutput);
            this.Controls.Add(this.btnOutputDirectory);
            this.Controls.Add(this.tbOutputDirectory);
            this.Controls.Add(this.lblOutputDirectory);
            this.Controls.Add(this.tbOutputName);
            this.Controls.Add(this.lblOutputName);
            this.Controls.Add(this.gbSetting);
            this.Controls.Add(this.lblDirectory);
            this.Controls.Add(this.lblSource);
            this.Controls.Add(this.pnlButtonBar);
            this.Controls.Add(this.pnlNav);
            this.ForeColor = System.Drawing.Color.Transparent;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.pnlNav.ResumeLayout(false);
            this.pnlNav.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbIcon)).EndInit();
            this.pnlButtonBar.ResumeLayout(false);
            this.gbSetting.ResumeLayout(false);
            this.gbSetting.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudGIFlength)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSkipSecond)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudFPS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudHeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudWidth)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlNav;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Panel pnlButtonBar;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnPickVideo;
        private System.Windows.Forms.PictureBox pbIcon;
        private System.Windows.Forms.Label lblSource;
        private System.Windows.Forms.Label lblDirectory;
        private System.Windows.Forms.Label lblLine2;
        private System.Windows.Forms.GroupBox gbSetting;
        private System.Windows.Forms.Label lblOutputName;
        private System.Windows.Forms.TextBox tbOutputName;
        private System.Windows.Forms.Label lblFPS;
        private System.Windows.Forms.Label lblHeight;
        private System.Windows.Forms.Label lblWidth;
        private System.Windows.Forms.NumericUpDown nudHeight;
        private System.Windows.Forms.NumericUpDown nudWidth;
        private System.Windows.Forms.NumericUpDown nudFPS;
        private System.Windows.Forms.OpenFileDialog fileDialog;
        private System.Windows.Forms.Button btnConvert;
        private System.Windows.Forms.Label lblOutputDirectory;
        private System.Windows.Forms.TextBox tbOutputDirectory;
        private System.Windows.Forms.Button btnOutputDirectory;
        private System.Windows.Forms.NumericUpDown nudSkipSecond;
        private System.Windows.Forms.Label lblSkipSecond;
        private System.Windows.Forms.RichTextBox rtbCmdOutput;
        private System.Windows.Forms.ComboBox cbLoopType;
        private System.Windows.Forms.Label lblLoopType;
        private System.Windows.Forms.CheckBox cbSkipSecond;
        private System.Windows.Forms.CheckBox cbGiflength;
        private System.Windows.Forms.NumericUpDown nudGIFlength;
        private System.Windows.Forms.Label lblGIFlength;
    }
}

