
namespace MusicPlayer
{
    partial class MusicPlayer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MusicPlayer));
            this.TopPanel = new System.Windows.Forms.Panel();
            this.lblLogo = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnClose = new System.Windows.Forms.Button();
            this.tracks = new System.Windows.Forms.ListBox();
            this.btnSelectSongs = new System.Windows.Forms.Button();
            this.WindowsMediaPlayer = new AxWMPLib.AxWindowsMediaPlayer();
            this.lblFooter = new System.Windows.Forms.Label();
            this.toggleNight = new System.Windows.Forms.Button();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.TopPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.WindowsMediaPlayer)).BeginInit();
            this.SuspendLayout();
            // 
            // TopPanel
            // 
            this.TopPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(28)))));
            this.TopPanel.Controls.Add(this.btnMinimize);
            this.TopPanel.Controls.Add(this.toggleNight);
            this.TopPanel.Controls.Add(this.lblLogo);
            this.TopPanel.Controls.Add(this.flowLayoutPanel1);
            this.TopPanel.Controls.Add(this.btnClose);
            this.TopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopPanel.ForeColor = System.Drawing.Color.White;
            this.TopPanel.Location = new System.Drawing.Point(0, 0);
            this.TopPanel.Name = "TopPanel";
            this.TopPanel.Size = new System.Drawing.Size(849, 76);
            this.TopPanel.TabIndex = 0;
            // 
            // lblLogo
            // 
            this.lblLogo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblLogo.AutoSize = true;
            this.lblLogo.Font = new System.Drawing.Font("Trajan Pro", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogo.ForeColor = System.Drawing.Color.White;
            this.lblLogo.Location = new System.Drawing.Point(7, 10);
            this.lblLogo.Name = "lblLogo";
            this.lblLogo.Size = new System.Drawing.Size(379, 61);
            this.lblLogo.TabIndex = 0;
            this.lblLogo.Text = "Music Player";
            this.lblLogo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblLogo.Click += new System.EventHandler(this.label1_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.flowLayoutPanel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flowLayoutPanel1.Location = new System.Drawing.Point(-160, 5);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(334, 66);
            this.flowLayoutPanel1.TabIndex = 2;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Black;
            this.btnClose.Font = new System.Drawing.Font("Adobe Gothic Std B", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.SystemColors.Control;
            this.btnClose.Location = new System.Drawing.Point(783, 12);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(50, 50);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // tracks
            // 
            this.tracks.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(28)))));
            this.tracks.Font = new System.Drawing.Font("Trajan Pro", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tracks.ForeColor = System.Drawing.SystemColors.Window;
            this.tracks.FormattingEnabled = true;
            this.tracks.ItemHeight = 28;
            this.tracks.Location = new System.Drawing.Point(480, 91);
            this.tracks.Name = "tracks";
            this.tracks.Size = new System.Drawing.Size(348, 312);
            this.tracks.TabIndex = 1;
            this.tracks.SelectedIndexChanged += new System.EventHandler(this.tracks_SelectedIndexChanged);
            // 
            // btnSelectSongs
            // 
            this.btnSelectSongs.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSelectSongs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(28)))));
            this.btnSelectSongs.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSelectSongs.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnSelectSongs.FlatAppearance.BorderSize = 2;
            this.btnSelectSongs.Font = new System.Drawing.Font("Trajan Pro", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelectSongs.ForeColor = System.Drawing.Color.Snow;
            this.btnSelectSongs.Location = new System.Drawing.Point(480, 419);
            this.btnSelectSongs.Name = "btnSelectSongs";
            this.btnSelectSongs.Size = new System.Drawing.Size(348, 63);
            this.btnSelectSongs.TabIndex = 2;
            this.btnSelectSongs.Text = "Add Songs";
            this.btnSelectSongs.UseVisualStyleBackColor = false;
            this.btnSelectSongs.Click += new System.EventHandler(this.button1_Click);
            // 
            // WindowsMediaPlayer
            // 
            this.WindowsMediaPlayer.Enabled = true;
            this.WindowsMediaPlayer.Location = new System.Drawing.Point(18, 91);
            this.WindowsMediaPlayer.Name = "WindowsMediaPlayer";
            this.WindowsMediaPlayer.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("WindowsMediaPlayer.OcxState")));
            this.WindowsMediaPlayer.Size = new System.Drawing.Size(431, 369);
            this.WindowsMediaPlayer.TabIndex = 3;
            this.WindowsMediaPlayer.Enter += new System.EventHandler(this.WindowsMediaPlayer_Enter);
            // 
            // lblFooter
            // 
            this.lblFooter.AutoSize = true;
            this.lblFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblFooter.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lblFooter.Location = new System.Drawing.Point(0, 483);
            this.lblFooter.Name = "lblFooter";
            this.lblFooter.Size = new System.Drawing.Size(168, 20);
            this.lblFooter.TabIndex = 4;
            this.lblFooter.Text = "developed by Arlithrien";
            this.lblFooter.Click += new System.EventHandler(this.lblFooter_Click);
            // 
            // toggleNight
            // 
            this.toggleNight.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.toggleNight.BackColor = System.Drawing.Color.White;
            this.toggleNight.BackgroundImage = global::MusicPlayer.Properties.Resources.dark_mode;
            this.toggleNight.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.toggleNight.ForeColor = System.Drawing.Color.White;
            this.toggleNight.Location = new System.Drawing.Point(650, 12);
            this.toggleNight.Name = "toggleNight";
            this.toggleNight.Size = new System.Drawing.Size(50, 50);
            this.toggleNight.TabIndex = 3;
            this.toggleNight.UseVisualStyleBackColor = false;
            this.toggleNight.Click += new System.EventHandler(this.toggleNight_Click);
            // 
            // btnMinimize
            // 
            this.btnMinimize.BackColor = System.Drawing.Color.Black;
            this.btnMinimize.Font = new System.Drawing.Font("Adobe Gothic Std B", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinimize.ForeColor = System.Drawing.SystemColors.Control;
            this.btnMinimize.Location = new System.Drawing.Point(718, 12);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(50, 50);
            this.btnMinimize.TabIndex = 4;
            this.btnMinimize.Text = "-";
            this.btnMinimize.UseVisualStyleBackColor = false;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // MusicPlayer
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(55)))), ((int)(((byte)(74)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(849, 503);
            this.Controls.Add(this.lblFooter);
            this.Controls.Add(this.WindowsMediaPlayer);
            this.Controls.Add(this.btnSelectSongs);
            this.Controls.Add(this.tracks);
            this.Controls.Add(this.TopPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MusicPlayer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Music Player";
            this.Load += new System.EventHandler(this.MusicPlayer_Load);
            this.TopPanel.ResumeLayout(false);
            this.TopPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.WindowsMediaPlayer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel TopPanel;
        private System.Windows.Forms.Label lblLogo;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.ListBox tracks;
        private System.Windows.Forms.Button btnSelectSongs;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private AxWMPLib.AxWindowsMediaPlayer WindowsMediaPlayer;
        private System.Windows.Forms.Label lblFooter;
        private System.Windows.Forms.Button toggleNight;
        private System.Windows.Forms.Button btnMinimize;
    }
}

