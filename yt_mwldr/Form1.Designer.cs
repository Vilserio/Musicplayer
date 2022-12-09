
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
            this.labelTrackEnd = new System.Windows.Forms.Label();
            this.labelTrackStart = new System.Windows.Forms.Label();
            this.labelVolume = new System.Windows.Forms.Label();
            this.trackVolume = new System.Windows.Forms.TrackBar();
            this.player = new AxWMPLib.AxWindowsMediaPlayer();
            this.trackList = new System.Windows.Forms.ListBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.customProgressbar1 = new CustomControls.RJControls.customProgressbar();
            this.openButton = new yt_mwldr.Custom.customButton();
            this.stopButton = new yt_mwldr.Custom.customButton();
            this.pauseButton = new yt_mwldr.Custom.customButton();
            this.playButton = new yt_mwldr.Custom.customButton();
            this.nextButton = new yt_mwldr.Custom.customButton();
            this.panelTop.SuspendLayout();
            this.controlPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackVolume)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
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
            this.controlPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.controlPanel_MouseMove);
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
            this.pictureBox1.Location = new System.Drawing.Point(325, 41);
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
            this.panel1.Controls.Add(this.customProgressbar1);
            this.panel1.Controls.Add(this.labelTrackEnd);
            this.panel1.Controls.Add(this.labelTrackStart);
            this.panel1.Controls.Add(this.labelVolume);
            this.panel1.Controls.Add(this.trackVolume);
            this.panel1.Controls.Add(this.player);
            this.panel1.Controls.Add(this.trackList);
            this.panel1.Controls.Add(this.openButton);
            this.panel1.Controls.Add(this.stopButton);
            this.panel1.Controls.Add(this.pauseButton);
            this.panel1.Controls.Add(this.playButton);
            this.panel1.Controls.Add(this.nextButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 121);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(784, 440);
            this.panel1.TabIndex = 2;
            // 
            // labelTrackEnd
            // 
            this.labelTrackEnd.AutoSize = true;
            this.labelTrackEnd.BackColor = System.Drawing.Color.Black;
            this.labelTrackEnd.Font = new System.Drawing.Font("Microsoft Tai Le", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTrackEnd.ForeColor = System.Drawing.Color.White;
            this.labelTrackEnd.Location = new System.Drawing.Point(620, 15);
            this.labelTrackEnd.Name = "labelTrackEnd";
            this.labelTrackEnd.Size = new System.Drawing.Size(99, 41);
            this.labelTrackEnd.TabIndex = 17;
            this.labelTrackEnd.Text = "00:00";
            // 
            // labelTrackStart
            // 
            this.labelTrackStart.AutoSize = true;
            this.labelTrackStart.BackColor = System.Drawing.Color.Black;
            this.labelTrackStart.Font = new System.Drawing.Font("Microsoft Tai Le", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTrackStart.ForeColor = System.Drawing.Color.White;
            this.labelTrackStart.Location = new System.Drawing.Point(70, 15);
            this.labelTrackStart.Name = "labelTrackStart";
            this.labelTrackStart.Size = new System.Drawing.Size(99, 41);
            this.labelTrackStart.TabIndex = 16;
            this.labelTrackStart.Text = "00:00";
            this.labelTrackStart.Click += new System.EventHandler(this.labelTrackStart_Click);
            // 
            // labelVolume
            // 
            this.labelVolume.AutoSize = true;
            this.labelVolume.Font = new System.Drawing.Font("Microsoft Tai Le", 10F, System.Drawing.FontStyle.Bold);
            this.labelVolume.ForeColor = System.Drawing.Color.White;
            this.labelVolume.Location = new System.Drawing.Point(661, 90);
            this.labelVolume.Name = "labelVolume";
            this.labelVolume.Size = new System.Drawing.Size(59, 18);
            this.labelVolume.TabIndex = 15;
            this.labelVolume.Text = "Volume";
            // 
            // trackVolume
            // 
            this.trackVolume.Location = new System.Drawing.Point(675, 111);
            this.trackVolume.Maximum = 100;
            this.trackVolume.Name = "trackVolume";
            this.trackVolume.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackVolume.Size = new System.Drawing.Size(45, 156);
            this.trackVolume.TabIndex = 14;
            this.trackVolume.TickFrequency = 10;
            this.trackVolume.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.trackVolume.Scroll += new System.EventHandler(this.trackVolume_Scroll);
            // 
            // player
            // 
            this.player.Dock = System.Windows.Forms.DockStyle.Top;
            this.player.Enabled = true;
            this.player.Location = new System.Drawing.Point(0, 0);
            this.player.Name = "player";
            this.player.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("player.OcxState")));
            this.player.Size = new System.Drawing.Size(784, 75);
            this.player.TabIndex = 13;
            // 
            // trackList
            // 
            this.trackList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.trackList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.trackList.ForeColor = System.Drawing.Color.White;
            this.trackList.FormattingEnabled = true;
            this.trackList.Location = new System.Drawing.Point(70, 111);
            this.trackList.Name = "trackList";
            this.trackList.Size = new System.Drawing.Size(600, 156);
            this.trackList.TabIndex = 12;
            this.trackList.SelectedIndexChanged += new System.EventHandler(this.trackList_SelectedIndexChanged);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // customProgressbar1
            // 
            this.customProgressbar1.ChannelColor = System.Drawing.Color.LightSteelBlue;
            this.customProgressbar1.ChannelHeight = 6;
            this.customProgressbar1.ForeBackColor = System.Drawing.Color.Transparent;
            this.customProgressbar1.ForeColor = System.Drawing.Color.Transparent;
            this.customProgressbar1.Location = new System.Drawing.Point(45, 295);
            this.customProgressbar1.Name = "customProgressbar1";
            this.customProgressbar1.ShowMaximun = false;
            this.customProgressbar1.ShowValue = CustomControls.RJControls.TextPosition.Right;
            this.customProgressbar1.Size = new System.Drawing.Size(700, 30);
            this.customProgressbar1.SliderColor = System.Drawing.Color.RoyalBlue;
            this.customProgressbar1.SliderHeight = 6;
            this.customProgressbar1.SymbolAfter = "";
            this.customProgressbar1.SymbolBefore = "";
            this.customProgressbar1.TabIndex = 18;
            this.customProgressbar1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.customProgressbar1_MouseDown);
            // 
            // openButton
            // 
            this.openButton.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.openButton.Backgroundcolor = System.Drawing.Color.MediumSlateBlue;
            this.openButton.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.openButton.BorderRadius = 40;
            this.openButton.BorderSize = 0;
            this.openButton.FlatAppearance.BorderSize = 0;
            this.openButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.openButton.Font = new System.Drawing.Font("Microsoft Tai Le", 10F, System.Drawing.FontStyle.Bold);
            this.openButton.ForeColor = System.Drawing.Color.White;
            this.openButton.Location = new System.Drawing.Point(580, 350);
            this.openButton.Name = "openButton";
            this.openButton.Size = new System.Drawing.Size(120, 40);
            this.openButton.TabIndex = 10;
            this.openButton.Text = "Open";
            this.openButton.Textcolor = System.Drawing.Color.White;
            this.openButton.UseVisualStyleBackColor = false;
            this.openButton.Click += new System.EventHandler(this.openButton_Click);
            // 
            // stopButton
            // 
            this.stopButton.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.stopButton.Backgroundcolor = System.Drawing.Color.MediumSlateBlue;
            this.stopButton.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.stopButton.BorderRadius = 40;
            this.stopButton.BorderSize = 0;
            this.stopButton.FlatAppearance.BorderSize = 0;
            this.stopButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.stopButton.Font = new System.Drawing.Font("Microsoft Tai Le", 10F, System.Drawing.FontStyle.Bold);
            this.stopButton.ForeColor = System.Drawing.Color.White;
            this.stopButton.Location = new System.Drawing.Point(455, 350);
            this.stopButton.Name = "stopButton";
            this.stopButton.Size = new System.Drawing.Size(120, 40);
            this.stopButton.TabIndex = 9;
            this.stopButton.Text = "Stop";
            this.stopButton.Textcolor = System.Drawing.Color.White;
            this.stopButton.UseVisualStyleBackColor = false;
            this.stopButton.Click += new System.EventHandler(this.stopButton_Click);
            // 
            // pauseButton
            // 
            this.pauseButton.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.pauseButton.Backgroundcolor = System.Drawing.Color.MediumSlateBlue;
            this.pauseButton.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.pauseButton.BorderRadius = 40;
            this.pauseButton.BorderSize = 0;
            this.pauseButton.FlatAppearance.BorderSize = 0;
            this.pauseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pauseButton.Font = new System.Drawing.Font("Microsoft Tai Le", 10F, System.Drawing.FontStyle.Bold);
            this.pauseButton.ForeColor = System.Drawing.Color.White;
            this.pauseButton.Location = new System.Drawing.Point(330, 350);
            this.pauseButton.Name = "pauseButton";
            this.pauseButton.Size = new System.Drawing.Size(120, 40);
            this.pauseButton.TabIndex = 8;
            this.pauseButton.Text = "Pause";
            this.pauseButton.Textcolor = System.Drawing.Color.White;
            this.pauseButton.UseVisualStyleBackColor = false;
            this.pauseButton.Click += new System.EventHandler(this.pauseButton_Click);
            // 
            // playButton
            // 
            this.playButton.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.playButton.Backgroundcolor = System.Drawing.Color.MediumSlateBlue;
            this.playButton.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.playButton.BorderRadius = 40;
            this.playButton.BorderSize = 0;
            this.playButton.FlatAppearance.BorderSize = 0;
            this.playButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.playButton.Font = new System.Drawing.Font("Microsoft Tai Le", 10F, System.Drawing.FontStyle.Bold);
            this.playButton.ForeColor = System.Drawing.Color.White;
            this.playButton.Location = new System.Drawing.Point(205, 350);
            this.playButton.Name = "playButton";
            this.playButton.Size = new System.Drawing.Size(120, 40);
            this.playButton.TabIndex = 7;
            this.playButton.Text = "Play";
            this.playButton.Textcolor = System.Drawing.Color.White;
            this.playButton.UseVisualStyleBackColor = false;
            this.playButton.Click += new System.EventHandler(this.playButton_Click);
            // 
            // nextButton
            // 
            this.nextButton.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.nextButton.Backgroundcolor = System.Drawing.Color.MediumSlateBlue;
            this.nextButton.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.nextButton.BorderRadius = 40;
            this.nextButton.BorderSize = 0;
            this.nextButton.FlatAppearance.BorderSize = 0;
            this.nextButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.nextButton.Font = new System.Drawing.Font("Microsoft Tai Le", 10F, System.Drawing.FontStyle.Bold);
            this.nextButton.ForeColor = System.Drawing.Color.White;
            this.nextButton.Location = new System.Drawing.Point(80, 350);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(120, 40);
            this.nextButton.TabIndex = 6;
            this.nextButton.Text = "Next";
            this.nextButton.Textcolor = System.Drawing.Color.White;
            this.nextButton.UseVisualStyleBackColor = false;
            this.nextButton.Click += new System.EventHandler(this.nextButton_Click);
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
            this.panelTop.ResumeLayout(false);
            this.controlPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackVolume)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panelShadow;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel controlPanel;
        private FontAwesome.Sharp.IconButton exitButton;
        private FontAwesome.Sharp.IconButton iconButton1;
        private AxWMPLib.AxWindowsMediaPlayer player;
        private System.Windows.Forms.ListBox trackList;
        private Custom.customButton openButton;
        private Custom.customButton stopButton;
        private Custom.customButton pauseButton;
        private Custom.customButton playButton;
        private Custom.customButton nextButton;
        private System.Windows.Forms.TrackBar trackVolume;
        private System.Windows.Forms.Label labelVolume;
        private System.Windows.Forms.Label labelTrackEnd;
        private System.Windows.Forms.Label labelTrackStart;
        private System.Windows.Forms.Timer timer1;
        private CustomControls.RJControls.customProgressbar customProgressbar1;
    }
}

