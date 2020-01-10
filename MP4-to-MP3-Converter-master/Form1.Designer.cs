namespace MP4_to_MP3_Converter
{
    partial class Form1 : MetroFramework.Forms.MetroForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Visual Studio Generated Code

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.aboutLabel = new MetroFramework.Controls.MetroLabel();
            this.btnConvert = new MetroFramework.Controls.MetroButton();
            this.completedTasksLabel = new System.Windows.Forms.Label();
            this.convertTab = new MetroFramework.Controls.MetroTabPage();
            this.previewCheckBox = new System.Windows.Forms.CheckBox();
            this.listBoxPaths = new System.Windows.Forms.ListBox();
            this.savePathBox = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.btnSave = new MetroFramework.Controls.MetroButton();
            this.btnOpen = new MetroFramework.Controls.MetroButton();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.tabControl = new MetroFramework.Controls.MetroTabControl();
            this.downloaderTab = new MetroFramework.Controls.MetroTabPage();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroProgressSpinner1 = new MetroFramework.Controls.MetroProgressSpinner();
            this.downloadProgressBar = new MetroFramework.Controls.MetroProgressBar();
            this.downloadButton = new MetroFramework.Controls.MetroButton();
            this.youtubePathTextbox = new MetroFramework.Controls.MetroTextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.nextFrameButton = new System.Windows.Forms.Button();
            this.previousFrameButton = new System.Windows.Forms.Button();
            this.resolutionCombobox = new MetroFramework.Controls.MetroComboBox();
            this.downloadProgressLabel = new MetroFramework.Controls.MetroLabel();
            this.convertTab.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.downloaderTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // aboutLabel
            // 
            this.aboutLabel.Location = new System.Drawing.Point(0, 0);
            this.aboutLabel.Name = "aboutLabel";
            this.aboutLabel.Size = new System.Drawing.Size(100, 23);
            this.aboutLabel.TabIndex = 0;
            // 
            // btnConvert
            // 
            this.btnConvert.Location = new System.Drawing.Point(0, 169);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(378, 29);
            this.btnConvert.TabIndex = 8;
            this.btnConvert.Text = "Convert";
            this.btnConvert.UseSelectable = true;
            this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);
            // 
            // completedTasksLabel
            // 
            this.completedTasksLabel.AutoSize = true;
            this.completedTasksLabel.Location = new System.Drawing.Point(194, 210);
            this.completedTasksLabel.Name = "completedTasksLabel";
            this.completedTasksLabel.Size = new System.Drawing.Size(116, 13);
            this.completedTasksLabel.TabIndex = 11;
            this.completedTasksLabel.Text = "There is no task added";
            // 
            // convertTab
            // 
            this.convertTab.Controls.Add(this.previewCheckBox);
            this.convertTab.Controls.Add(this.completedTasksLabel);
            this.convertTab.Controls.Add(this.listBoxPaths);
            this.convertTab.Controls.Add(this.savePathBox);
            this.convertTab.Controls.Add(this.btnConvert);
            this.convertTab.Controls.Add(this.metroLabel2);
            this.convertTab.Controls.Add(this.btnSave);
            this.convertTab.Controls.Add(this.btnOpen);
            this.convertTab.Controls.Add(this.metroLabel1);
            this.convertTab.HorizontalScrollbarBarColor = true;
            this.convertTab.HorizontalScrollbarHighlightOnWheel = false;
            this.convertTab.HorizontalScrollbarSize = 10;
            this.convertTab.Location = new System.Drawing.Point(4, 38);
            this.convertTab.Name = "convertTab";
            this.convertTab.Size = new System.Drawing.Size(490, 223);
            this.convertTab.TabIndex = 0;
            this.convertTab.Text = "Convert";
            this.convertTab.VerticalScrollbarBarColor = true;
            this.convertTab.VerticalScrollbarHighlightOnWheel = false;
            this.convertTab.VerticalScrollbarSize = 10;
            // 
            // previewCheckBox
            // 
            this.previewCheckBox.AutoSize = true;
            this.previewCheckBox.CausesValidation = false;
            this.previewCheckBox.Enabled = false;
            this.previewCheckBox.Location = new System.Drawing.Point(393, 181);
            this.previewCheckBox.Name = "previewCheckBox";
            this.previewCheckBox.Size = new System.Drawing.Size(94, 17);
            this.previewCheckBox.TabIndex = 13;
            this.previewCheckBox.Text = "Show Preview";
            this.previewCheckBox.UseVisualStyleBackColor = true;
            this.previewCheckBox.CheckedChanged += new System.EventHandler(this.previewCheckBox_CheckedChanged);
            // 
            // listBoxPaths
            // 
            this.listBoxPaths.FormattingEnabled = true;
            this.listBoxPaths.HorizontalScrollbar = true;
            this.listBoxPaths.Location = new System.Drawing.Point(93, 15);
            this.listBoxPaths.Name = "listBoxPaths";
            this.listBoxPaths.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.listBoxPaths.Size = new System.Drawing.Size(293, 95);
            this.listBoxPaths.TabIndex = 8;
            this.listBoxPaths.SelectedValueChanged += new System.EventHandler(this.listBoxPaths_SelectedValueChanged);
            this.listBoxPaths.KeyDown += new System.Windows.Forms.KeyEventHandler(this.listBoxPaths_KeyDown);
            // 
            // savePathBox
            // 
            // 
            // 
            // 
            this.savePathBox.CustomButton.Image = null;
            this.savePathBox.CustomButton.Location = new System.Drawing.Point(275, 1);
            this.savePathBox.CustomButton.Name = "";
            this.savePathBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.savePathBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.savePathBox.CustomButton.TabIndex = 1;
            this.savePathBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.savePathBox.CustomButton.UseSelectable = true;
            this.savePathBox.CustomButton.Visible = false;
            this.savePathBox.Lines = new string[0];
            this.savePathBox.Location = new System.Drawing.Point(89, 123);
            this.savePathBox.MaxLength = 32767;
            this.savePathBox.Name = "savePathBox";
            this.savePathBox.PasswordChar = '\0';
            this.savePathBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.savePathBox.SelectedText = "";
            this.savePathBox.SelectionLength = 0;
            this.savePathBox.SelectionStart = 0;
            this.savePathBox.ShortcutsEnabled = true;
            this.savePathBox.Size = new System.Drawing.Size(297, 23);
            this.savePathBox.TabIndex = 6;
            this.savePathBox.UseSelectable = true;
            this.savePathBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.savePathBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(0, 123);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(55, 19);
            this.metroLabel2.TabIndex = 5;
            this.metroLabel2.Text = "Save to:";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(392, 123);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(90, 23);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "Save";
            this.btnSave.UseSelectable = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(392, 15);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(90, 23);
            this.btnOpen.TabIndex = 4;
            this.btnOpen.Text = "Open";
            this.btnOpen.UseSelectable = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(-4, 15);
            this.metroLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(86, 19);
            this.metroLabel1.TabIndex = 2;
            this.metroLabel1.Text = "Videos paths:";
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.convertTab);
            this.tabControl.Controls.Add(this.downloaderTab);
            this.tabControl.Location = new System.Drawing.Point(10, 63);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 1;
            this.tabControl.Size = new System.Drawing.Size(498, 265);
            this.tabControl.TabIndex = 0;
            this.tabControl.UseSelectable = true;
            // 
            // downloaderTab
            // 
            this.downloaderTab.Controls.Add(this.downloadProgressLabel);
            this.downloaderTab.Controls.Add(this.resolutionCombobox);
            this.downloaderTab.Controls.Add(this.metroLabel3);
            this.downloaderTab.Controls.Add(this.metroProgressSpinner1);
            this.downloaderTab.Controls.Add(this.downloadProgressBar);
            this.downloaderTab.Controls.Add(this.downloadButton);
            this.downloaderTab.Controls.Add(this.youtubePathTextbox);
            this.downloaderTab.HorizontalScrollbarBarColor = true;
            this.downloaderTab.HorizontalScrollbarHighlightOnWheel = false;
            this.downloaderTab.HorizontalScrollbarSize = 10;
            this.downloaderTab.Location = new System.Drawing.Point(4, 38);
            this.downloaderTab.Name = "downloaderTab";
            this.downloaderTab.Size = new System.Drawing.Size(490, 223);
            this.downloaderTab.TabIndex = 1;
            this.downloaderTab.Text = "Downloader";
            this.downloaderTab.ToolTipText = "Download video from youtube";
            this.downloaderTab.VerticalScrollbarBarColor = true;
            this.downloaderTab.VerticalScrollbarHighlightOnWheel = false;
            this.downloaderTab.VerticalScrollbarSize = 10;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(43, 40);
            this.metroLabel3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(74, 19);
            this.metroLabel3.TabIndex = 6;
            this.metroLabel3.Text = "Videos link:";
            // 
            // metroProgressSpinner1
            // 
            this.metroProgressSpinner1.Location = new System.Drawing.Point(396, 43);
            this.metroProgressSpinner1.Maximum = 100;
            this.metroProgressSpinner1.Name = "metroProgressSpinner1";
            this.metroProgressSpinner1.Size = new System.Drawing.Size(16, 16);
            this.metroProgressSpinner1.TabIndex = 5;
            this.metroProgressSpinner1.UseSelectable = true;
            // 
            // downloadProgressBar
            // 
            this.downloadProgressBar.Location = new System.Drawing.Point(149, 152);
            this.downloadProgressBar.Name = "downloadProgressBar";
            this.downloadProgressBar.Size = new System.Drawing.Size(220, 23);
            this.downloadProgressBar.TabIndex = 4;
            // 
            // downloadButton
            // 
            this.downloadButton.Location = new System.Drawing.Point(286, 97);
            this.downloadButton.Name = "downloadButton";
            this.downloadButton.Size = new System.Drawing.Size(75, 23);
            this.downloadButton.TabIndex = 3;
            this.downloadButton.Text = "Download";
            this.downloadButton.UseSelectable = true;
            this.downloadButton.Click += new System.EventHandler(this.downloadButton_Click);
            // 
            // youtubePathTextbox
            // 
            // 
            // 
            // 
            this.youtubePathTextbox.CustomButton.Image = null;
            this.youtubePathTextbox.CustomButton.Location = new System.Drawing.Point(190, 1);
            this.youtubePathTextbox.CustomButton.Name = "";
            this.youtubePathTextbox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.youtubePathTextbox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.youtubePathTextbox.CustomButton.TabIndex = 1;
            this.youtubePathTextbox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.youtubePathTextbox.CustomButton.UseSelectable = true;
            this.youtubePathTextbox.CustomButton.Visible = false;
            this.youtubePathTextbox.Lines = new string[0];
            this.youtubePathTextbox.Location = new System.Drawing.Point(149, 40);
            this.youtubePathTextbox.MaxLength = 32767;
            this.youtubePathTextbox.Name = "youtubePathTextbox";
            this.youtubePathTextbox.PasswordChar = '\0';
            this.youtubePathTextbox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.youtubePathTextbox.SelectedText = "";
            this.youtubePathTextbox.SelectionLength = 0;
            this.youtubePathTextbox.SelectionStart = 0;
            this.youtubePathTextbox.ShortcutsEnabled = true;
            this.youtubePathTextbox.Size = new System.Drawing.Size(212, 23);
            this.youtubePathTextbox.TabIndex = 2;
            this.youtubePathTextbox.UseSelectable = true;
            this.youtubePathTextbox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.youtubePathTextbox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(23, 305);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1, 1);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // nextFrameButton
            // 
            this.nextFrameButton.Location = new System.Drawing.Point(731, 301);
            this.nextFrameButton.Name = "nextFrameButton";
            this.nextFrameButton.Size = new System.Drawing.Size(75, 23);
            this.nextFrameButton.TabIndex = 10;
            this.nextFrameButton.Text = "->>";
            this.nextFrameButton.UseVisualStyleBackColor = true;
            this.nextFrameButton.Visible = false;
            this.nextFrameButton.Click += new System.EventHandler(this.nextFrameButton_Click);
            // 
            // previousFrameButton
            // 
            this.previousFrameButton.Location = new System.Drawing.Point(625, 301);
            this.previousFrameButton.Name = "previousFrameButton";
            this.previousFrameButton.Size = new System.Drawing.Size(68, 23);
            this.previousFrameButton.TabIndex = 11;
            this.previousFrameButton.Text = "<<-";
            this.previousFrameButton.UseVisualStyleBackColor = true;
            this.previousFrameButton.Visible = false;
            this.previousFrameButton.Click += new System.EventHandler(this.previousFrameButton_Click);
            // 
            // resolutionCombobox
            // 
            this.resolutionCombobox.FormattingEnabled = true;
            this.resolutionCombobox.ItemHeight = 23;
            this.resolutionCombobox.Items.AddRange(new object[] {
            "360",
            "480",
            "720",
            "1080"});
            this.resolutionCombobox.Location = new System.Drawing.Point(149, 91);
            this.resolutionCombobox.Name = "resolutionCombobox";
            this.resolutionCombobox.Size = new System.Drawing.Size(121, 29);
            this.resolutionCombobox.TabIndex = 7;
            this.resolutionCombobox.UseSelectable = true;
            // 
            // downloadProgressLabel
            // 
            this.downloadProgressLabel.AutoSize = true;
            this.downloadProgressLabel.Location = new System.Drawing.Point(376, 152);
            this.downloadProgressLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.downloadProgressLabel.Name = "downloadProgressLabel";
            this.downloadProgressLabel.Size = new System.Drawing.Size(27, 19);
            this.downloadProgressLabel.TabIndex = 8;
            this.downloadProgressLabel.Text = "%0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(517, 340);
            this.Controls.Add(this.previousFrameButton);
            this.Controls.Add(this.nextFrameButton);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.tabControl);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Resizable = false;
            this.Text = "MP4 to MP3 Converter";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.convertTab.ResumeLayout(false);
            this.convertTab.PerformLayout();
            this.tabControl.ResumeLayout(false);
            this.downloaderTab.ResumeLayout(false);
            this.downloaderTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private MetroFramework.Controls.MetroLabel aboutLabel;
        private MetroFramework.Controls.MetroButton btnConvert;
        private System.Windows.Forms.Label completedTasksLabel;
        private MetroFramework.Controls.MetroTabPage convertTab;
        private System.Windows.Forms.ListBox listBoxPaths;
        private MetroFramework.Controls.MetroTextBox savePathBox;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroButton btnSave;
        private MetroFramework.Controls.MetroButton btnOpen;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTabControl tabControl;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.CheckBox previewCheckBox;
        private System.Windows.Forms.Button nextFrameButton;
        private System.Windows.Forms.Button previousFrameButton;
        private MetroFramework.Controls.MetroTabPage downloaderTab;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroProgressSpinner metroProgressSpinner1;
        private MetroFramework.Controls.MetroProgressBar downloadProgressBar;
        private MetroFramework.Controls.MetroButton downloadButton;
        private MetroFramework.Controls.MetroTextBox youtubePathTextbox;
        private MetroFramework.Controls.MetroComboBox resolutionCombobox;
        private MetroFramework.Controls.MetroLabel downloadProgressLabel;
    }
}

