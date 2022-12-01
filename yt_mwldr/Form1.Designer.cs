
namespace yt_mwldr
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panelTop = new System.Windows.Forms.Panel();
            this.controlPanel = new System.Windows.Forms.Panel();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.exitButton = new FontAwesome.Sharp.IconButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelShadow = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.downloadButton = new yt_mwldr.Custom.customButton();
            this.filepathComboBox = new yt_mwldr.Custom.customComboBox();
            this.qualityComboBox = new yt_mwldr.Custom.customComboBox();
            this.processButton = new yt_mwldr.Custom.customButton();
            this.customProgressbar1 = new CustomControls.RJControls.customProgressbar();
            this.fileLabel = new System.Windows.Forms.Label();
            this.qualityLabel = new System.Windows.Forms.Label();
            this.urlLabel = new System.Windows.Forms.Label();
            this.urlTextBox = new yt_mwldr.Custom.CustomTextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panelTop.SuspendLayout();
            this.controlPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.panelTop.Controls.Add(this.controlPanel);
            this.panelTop.Controls.Add(this.pictureBox1);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(784, 112);
            this.panelTop.TabIndex = 0;
            // 
            // controlPanel
            // 
            this.controlPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.controlPanel.Controls.Add(this.iconButton1);
            this.controlPanel.Controls.Add(this.exitButton);
            this.controlPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.controlPanel.Location = new System.Drawing.Point(0, 0);
            this.controlPanel.Name = "controlPanel";
            this.controlPanel.Size = new System.Drawing.Size(784, 35);
            this.controlPanel.TabIndex = 3;
            this.controlPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.controlPanel_MouseDown);
            this.controlPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.controlPanel_MouseMove);
            this.controlPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.controlPanel_MouseUp);
            // 
            // iconButton1
            // 
            this.iconButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.iconButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.iconButton1.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.iconButton1.FlatAppearance.BorderSize = 0;
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.ForeColor = System.Drawing.Color.Transparent;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.Minus;
            this.iconButton1.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(105)))), ((int)(((byte)(255)))));
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.IconSize = 30;
            this.iconButton1.Location = new System.Drawing.Point(715, 3);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(30, 30);
            this.iconButton1.TabIndex = 6;
            this.iconButton1.UseCompatibleTextRendering = true;
            this.iconButton1.UseVisualStyleBackColor = false;
            this.iconButton1.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.exitButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.exitButton.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.exitButton.FlatAppearance.BorderSize = 0;
            this.exitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitButton.ForeColor = System.Drawing.Color.Transparent;
            this.exitButton.IconChar = FontAwesome.Sharp.IconChar.XmarkCircle;
            this.exitButton.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(105)))), ((int)(((byte)(255)))));
            this.exitButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.exitButton.IconSize = 30;
            this.exitButton.Location = new System.Drawing.Point(751, 3);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(30, 30);
            this.exitButton.TabIndex = 5;
            this.exitButton.UseCompatibleTextRendering = true;
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(305, 41);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(152, 65);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // panelShadow
            // 
            this.panelShadow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(24)))), ((int)(((byte)(58)))));
            this.panelShadow.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelShadow.Location = new System.Drawing.Point(0, 112);
            this.panelShadow.Name = "panelShadow";
            this.panelShadow.Size = new System.Drawing.Size(784, 9);
            this.panelShadow.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.panel1.Controls.Add(this.downloadButton);
            this.panel1.Controls.Add(this.filepathComboBox);
            this.panel1.Controls.Add(this.qualityComboBox);
            this.panel1.Controls.Add(this.processButton);
            this.panel1.Controls.Add(this.customProgressbar1);
            this.panel1.Controls.Add(this.fileLabel);
            this.panel1.Controls.Add(this.qualityLabel);
            this.panel1.Controls.Add(this.urlLabel);
            this.panel1.Controls.Add(this.urlTextBox);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 121);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(784, 440);
            this.panel1.TabIndex = 2;
            // 
            // downloadButton
            // 
            this.downloadButton.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.downloadButton.Backgroundcolor = System.Drawing.Color.MediumSlateBlue;
            this.downloadButton.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.downloadButton.BorderRadius = 40;
            this.downloadButton.BorderSize = 0;
            this.downloadButton.FlatAppearance.BorderSize = 0;
            this.downloadButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.downloadButton.ForeColor = System.Drawing.Color.White;
            this.downloadButton.Location = new System.Drawing.Point(329, 281);
            this.downloadButton.Name = "downloadButton";
            this.downloadButton.Size = new System.Drawing.Size(150, 40);
            this.downloadButton.TabIndex = 8;
            this.downloadButton.Text = "Dowload";
            this.downloadButton.Textcolor = System.Drawing.Color.White;
            this.downloadButton.UseVisualStyleBackColor = false;
            // 
            // filepathComboBox
            // 
            this.filepathComboBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.filepathComboBox.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.filepathComboBox.BorderSize = 1;
            this.filepathComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.filepathComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.filepathComboBox.ForeColor = System.Drawing.Color.DimGray;
            this.filepathComboBox.IconColor = System.Drawing.Color.MediumSlateBlue;
            this.filepathComboBox.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.filepathComboBox.ListTextColor = System.Drawing.Color.DimGray;
            this.filepathComboBox.Location = new System.Drawing.Point(509, 216);
            this.filepathComboBox.MinimumSize = new System.Drawing.Size(200, 30);
            this.filepathComboBox.Name = "filepathComboBox";
            this.filepathComboBox.Padding = new System.Windows.Forms.Padding(1);
            this.filepathComboBox.Size = new System.Drawing.Size(200, 30);
            this.filepathComboBox.TabIndex = 7;
            this.filepathComboBox.Texts = "";
            // 
            // qualityComboBox
            // 
            this.qualityComboBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.qualityComboBox.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.qualityComboBox.BorderSize = 1;
            this.qualityComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.qualityComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.qualityComboBox.ForeColor = System.Drawing.Color.DimGray;
            this.qualityComboBox.IconColor = System.Drawing.Color.MediumSlateBlue;
            this.qualityComboBox.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.qualityComboBox.ListTextColor = System.Drawing.Color.DimGray;
            this.qualityComboBox.Location = new System.Drawing.Point(165, 216);
            this.qualityComboBox.MinimumSize = new System.Drawing.Size(200, 30);
            this.qualityComboBox.Name = "qualityComboBox";
            this.qualityComboBox.Padding = new System.Windows.Forms.Padding(1);
            this.qualityComboBox.Size = new System.Drawing.Size(200, 30);
            this.qualityComboBox.TabIndex = 6;
            this.qualityComboBox.Texts = "";
            // 
            // processButton
            // 
            this.processButton.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.processButton.Backgroundcolor = System.Drawing.Color.MediumSlateBlue;
            this.processButton.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.processButton.BorderRadius = 40;
            this.processButton.BorderSize = 0;
            this.processButton.FlatAppearance.BorderSize = 0;
            this.processButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.processButton.ForeColor = System.Drawing.Color.White;
            this.processButton.Location = new System.Drawing.Point(329, 93);
            this.processButton.Name = "processButton";
            this.processButton.Size = new System.Drawing.Size(150, 40);
            this.processButton.TabIndex = 5;
            this.processButton.Text = "Process";
            this.processButton.Textcolor = System.Drawing.Color.White;
            this.processButton.UseVisualStyleBackColor = false;
            this.processButton.Click += new System.EventHandler(this.customButton1_Click_1);
            // 
            // customProgressbar1
            // 
            this.customProgressbar1.ChannelColor = System.Drawing.Color.LightSteelBlue;
            this.customProgressbar1.ChannelHeight = 6;
            this.customProgressbar1.ForeBackColor = System.Drawing.Color.RoyalBlue;
            this.customProgressbar1.ForeColor = System.Drawing.Color.White;
            this.customProgressbar1.Location = new System.Drawing.Point(165, 360);
            this.customProgressbar1.Name = "customProgressbar1";
            this.customProgressbar1.ShowMaximun = false;
            this.customProgressbar1.ShowValue = CustomControls.RJControls.TextPosition.Right;
            this.customProgressbar1.Size = new System.Drawing.Size(100, 23);
            this.customProgressbar1.SliderColor = System.Drawing.Color.RoyalBlue;
            this.customProgressbar1.SliderHeight = 6;
            this.customProgressbar1.SymbolAfter = "";
            this.customProgressbar1.SymbolBefore = "";
            this.customProgressbar1.TabIndex = 4;
            // 
            // fileLabel
            // 
            this.fileLabel.AutoSize = true;
            this.fileLabel.Font = new System.Drawing.Font("Microsoft Tai Le", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fileLabel.ForeColor = System.Drawing.Color.Lavender;
            this.fileLabel.Location = new System.Drawing.Point(506, 164);
            this.fileLabel.Name = "fileLabel";
            this.fileLabel.Size = new System.Drawing.Size(109, 18);
            this.fileLabel.TabIndex = 3;
            this.fileLabel.Text = "File destination";
            this.fileLabel.Click += new System.EventHandler(this.fileLabel_Click);
            // 
            // qualityLabel
            // 
            this.qualityLabel.AutoSize = true;
            this.qualityLabel.Font = new System.Drawing.Font("Microsoft Tai Le", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.qualityLabel.ForeColor = System.Drawing.Color.Lavender;
            this.qualityLabel.Location = new System.Drawing.Point(162, 164);
            this.qualityLabel.Name = "qualityLabel";
            this.qualityLabel.Size = new System.Drawing.Size(56, 18);
            this.qualityLabel.TabIndex = 2;
            this.qualityLabel.Text = "Quality";
            // 
            // urlLabel
            // 
            this.urlLabel.AutoSize = true;
            this.urlLabel.Font = new System.Drawing.Font("Microsoft Tai Le", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.urlLabel.ForeColor = System.Drawing.Color.Lavender;
            this.urlLabel.Location = new System.Drawing.Point(162, 23);
            this.urlLabel.Name = "urlLabel";
            this.urlLabel.Size = new System.Drawing.Size(38, 18);
            this.urlLabel.TabIndex = 1;
            this.urlLabel.Text = "URL:";
            // 
            // urlTextBox
            // 
            this.urlTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.urlTextBox.BorderColor = System.Drawing.Color.Lavender;
            this.urlTextBox.BorderSize = 2;
            this.urlTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.urlTextBox.ForeColor = System.Drawing.Color.DimGray;
            this.urlTextBox.Location = new System.Drawing.Point(165, 45);
            this.urlTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.urlTextBox.Multiline = false;
            this.urlTextBox.Name = "urlTextBox";
            this.urlTextBox.Padding = new System.Windows.Forms.Padding(7);
            this.urlTextBox.PasswordChar = false;
            this.urlTextBox.Size = new System.Drawing.Size(450, 31);
            this.urlTextBox.TabIndex = 0;
            this.urlTextBox.Texts = "";
            this.urlTextBox.UnderlinedStyle = true;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelShadow);
            this.Controls.Add(this.panelTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelTop.ResumeLayout(false);
            this.controlPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panelShadow;
        private System.Windows.Forms.Panel panel1;
        private Custom.CustomTextBox urlTextBox;
        private System.Windows.Forms.Label fileLabel;
        private System.Windows.Forms.Label qualityLabel;
        private System.Windows.Forms.Label urlLabel;
        private System.Windows.Forms.Panel controlPanel;
        private FontAwesome.Sharp.IconButton exitButton;
        private FontAwesome.Sharp.IconButton iconButton1;
        private Custom.customButton processButton;
        private CustomControls.RJControls.customProgressbar customProgressbar1;
        private System.Windows.Forms.Timer timer1;
        private Custom.customButton downloadButton;
        private Custom.customComboBox filepathComboBox;
        private Custom.customComboBox qualityComboBox;
    }
}

