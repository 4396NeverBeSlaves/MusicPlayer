namespace MusicPlayer
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.sound = new System.Windows.Forms.PictureBox();
            this.close = new System.Windows.Forms.PictureBox();
            this.min = new System.Windows.Forms.PictureBox();
            this.nextbutton = new System.Windows.Forms.PictureBox();
            this.playbutton = new System.Windows.Forms.PictureBox();
            this.previousbutton = new System.Windows.Forms.PictureBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.添加音乐ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.MusicNamePanel = new System.Windows.Forms.Panel();
            this.musicname_label = new System.Windows.Forms.Label();
            this.playlist = new System.Windows.Forms.ListBox();
            this.panelbackvioce1 = new System.Windows.Forms.Panel();
            this.viocepanel2 = new System.Windows.Forms.Panel();
            this.transParentListBox1 = new MusicPlayer.TransParentListBox();
            ((System.ComponentModel.ISupportInitialize)(this.sound)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.close)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.min)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nextbutton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playbutton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.previousbutton)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            this.MusicNamePanel.SuspendLayout();
            this.panelbackvioce1.SuspendLayout();
            this.SuspendLayout();
            // 
            // sound
            // 
            this.sound.BackColor = System.Drawing.Color.Transparent;
            this.sound.BackgroundImage = global::MusicPlayer.Resource1.sound;
            this.sound.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.sound.Location = new System.Drawing.Point(323, 165);
            this.sound.Name = "sound";
            this.sound.Size = new System.Drawing.Size(30, 30);
            this.sound.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.sound.TabIndex = 11;
            this.sound.TabStop = false;
            this.sound.Click += new System.EventHandler(this.sound_Click);
            // 
            // close
            // 
            this.close.BackColor = System.Drawing.Color.Transparent;
            this.close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.close.Image = global::MusicPlayer.Resource1.close_up;
            this.close.Location = new System.Drawing.Point(455, 0);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(45, 30);
            this.close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.close.TabIndex = 0;
            this.close.TabStop = false;
            this.close.MouseClick += new System.Windows.Forms.MouseEventHandler(this.appclose);
            this.close.MouseLeave += new System.EventHandler(this.pictureBox1_MouseLeave);
            this.close.MouseMove += new System.Windows.Forms.MouseEventHandler(this.close_up);
            // 
            // min
            // 
            this.min.BackColor = System.Drawing.Color.Transparent;
            this.min.Cursor = System.Windows.Forms.Cursors.Hand;
            this.min.Image = global::MusicPlayer.Resource1.min_up;
            this.min.Location = new System.Drawing.Point(410, 0);
            this.min.Name = "min";
            this.min.Size = new System.Drawing.Size(45, 30);
            this.min.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.min.TabIndex = 1;
            this.min.TabStop = false;
            this.min.Click += new System.EventHandler(this.pictureBox2_Click);
            this.min.MouseLeave += new System.EventHandler(this.min_MouseLeave);
            this.min.MouseMove += new System.Windows.Forms.MouseEventHandler(this.min_MouseMove);
            // 
            // nextbutton
            // 
            this.nextbutton.BackColor = System.Drawing.Color.Transparent;
            this.nextbutton.BackgroundImage = global::MusicPlayer.Resource1.next_up;
            this.nextbutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.nextbutton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.nextbutton.Location = new System.Drawing.Point(222, 160);
            this.nextbutton.Name = "nextbutton";
            this.nextbutton.Size = new System.Drawing.Size(40, 40);
            this.nextbutton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.nextbutton.TabIndex = 4;
            this.nextbutton.TabStop = false;
            this.nextbutton.Click += new System.EventHandler(this.next_Click);
            this.nextbutton.MouseLeave += new System.EventHandler(this.pictureBox5_MouseLeave);
            this.nextbutton.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox5_MouseMove);
            // 
            // playbutton
            // 
            this.playbutton.BackColor = System.Drawing.Color.Transparent;
            this.playbutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.playbutton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.playbutton.Image = global::MusicPlayer.Resource1.play_up;
            this.playbutton.Location = new System.Drawing.Point(130, 160);
            this.playbutton.Name = "playbutton";
            this.playbutton.Size = new System.Drawing.Size(40, 40);
            this.playbutton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.playbutton.TabIndex = 3;
            this.playbutton.TabStop = false;
            this.playbutton.Click += new System.EventHandler(this.playbutton_Click);
            this.playbutton.MouseLeave += new System.EventHandler(this.pictureBox4_MouseLeave);
            this.playbutton.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox4_MouseMove);
            // 
            // previousbutton
            // 
            this.previousbutton.BackColor = System.Drawing.Color.Transparent;
            this.previousbutton.BackgroundImage = global::MusicPlayer.Resource1.previous_up;
            this.previousbutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.previousbutton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.previousbutton.Location = new System.Drawing.Point(41, 160);
            this.previousbutton.Name = "previousbutton";
            this.previousbutton.Size = new System.Drawing.Size(40, 40);
            this.previousbutton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.previousbutton.TabIndex = 2;
            this.previousbutton.TabStop = false;
            this.previousbutton.Click += new System.EventHandler(this.pictureBox3_Click);
            this.previousbutton.MouseLeave += new System.EventHandler(this.pictureBox3_MouseLeave);
            this.previousbutton.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox3_MouseMove);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.添加音乐ToolStripMenuItem,
            this.toolStripMenuItem1});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(153, 70);
            // 
            // 添加音乐ToolStripMenuItem
            // 
            this.添加音乐ToolStripMenuItem.Name = "添加音乐ToolStripMenuItem";
            this.添加音乐ToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.添加音乐ToolStripMenuItem.Text = "添加音乐";
            this.添加音乐ToolStripMenuItem.Click += new System.EventHandler(this.添加音乐ToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(148, 22);
            this.toolStripMenuItem1.Text = "查看文件位置";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.Filter = "mp3|*.mp3|wav|*.wav";
            this.openFileDialog1.Multiselect = true;
            this.openFileDialog1.RestoreDirectory = true;
            this.openFileDialog1.Title = "添加音乐";
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(6, 469);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(75, 23);
            this.axWindowsMediaPlayer1.TabIndex = 13;
            this.axWindowsMediaPlayer1.Visible = false;
            // 
            // MusicNamePanel
            // 
            this.MusicNamePanel.BackColor = System.Drawing.Color.Transparent;
            this.MusicNamePanel.Controls.Add(this.musicname_label);
            this.MusicNamePanel.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.MusicNamePanel.ForeColor = System.Drawing.Color.Snow;
            this.MusicNamePanel.Location = new System.Drawing.Point(80, 41);
            this.MusicNamePanel.Name = "MusicNamePanel";
            this.MusicNamePanel.Size = new System.Drawing.Size(348, 94);
            this.MusicNamePanel.TabIndex = 14;
            // 
            // musicname_label
            // 
            this.musicname_label.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.musicname_label.ForeColor = System.Drawing.Color.Snow;
            this.musicname_label.Location = new System.Drawing.Point(24, 12);
            this.musicname_label.Name = "musicname_label";
            this.musicname_label.Size = new System.Drawing.Size(298, 70);
            this.musicname_label.TabIndex = 0;
            this.musicname_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // playlist
            // 
            this.playlist.BackColor = System.Drawing.SystemColors.Control;
            this.playlist.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.playlist.ContextMenuStrip = this.contextMenuStrip1;
            this.playlist.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.playlist.ForeColor = System.Drawing.Color.White;
            this.playlist.FormattingEnabled = true;
            this.playlist.ItemHeight = 16;
            this.playlist.Location = new System.Drawing.Point(41, 223);
            this.playlist.Name = "playlist";
            this.playlist.Size = new System.Drawing.Size(420, 240);
            this.playlist.TabIndex = 6;
            this.playlist.Visible = false;
            this.playlist.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.playlist_MouseDoubleClick);
            // 
            // panelbackvioce1
            // 
            this.panelbackvioce1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelbackvioce1.Controls.Add(this.viocepanel2);
            this.panelbackvioce1.Cursor = System.Windows.Forms.Cursors.Default;
            this.panelbackvioce1.Location = new System.Drawing.Point(368, 177);
            this.panelbackvioce1.Name = "panelbackvioce1";
            this.panelbackvioce1.Size = new System.Drawing.Size(120, 5);
            this.panelbackvioce1.TabIndex = 16;
            this.panelbackvioce1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelbackvioce1_MouseDown);
            // 
            // viocepanel2
            // 
            this.viocepanel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.viocepanel2.Location = new System.Drawing.Point(0, 0);
            this.viocepanel2.Name = "viocepanel2";
            this.viocepanel2.Size = new System.Drawing.Size(70, 6);
            this.viocepanel2.TabIndex = 17;
            this.viocepanel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.viocepanel2_MouseDown);
            // 
            // transParentListBox1
            // 
            this.transParentListBox1.BackColor = System.Drawing.Color.Transparent;
            this.transParentListBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.transParentListBox1.ContextMenuStrip = this.contextMenuStrip1;
            this.transParentListBox1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.transParentListBox1.ForeColor = System.Drawing.Color.White;
            this.transParentListBox1.FormattingEnabled = true;
            this.transParentListBox1.ItemHeight = 16;
            this.transParentListBox1.Location = new System.Drawing.Point(41, 223);
            this.transParentListBox1.Name = "transParentListBox1";
            this.transParentListBox1.Size = new System.Drawing.Size(420, 240);
            this.transParentListBox1.TabIndex = 15;
            this.transParentListBox1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.playlist_MouseDoubleClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::MusicPlayer.Resource1.backgroundimage;
            this.ClientSize = new System.Drawing.Size(500, 500);
            this.Controls.Add(this.panelbackvioce1);
            this.Controls.Add(this.transParentListBox1);
            this.Controls.Add(this.playlist);
            this.Controls.Add(this.axWindowsMediaPlayer1);
            this.Controls.Add(this.sound);
            this.Controls.Add(this.close);
            this.Controls.Add(this.min);
            this.Controls.Add(this.nextbutton);
            this.Controls.Add(this.playbutton);
            this.Controls.Add(this.previousbutton);
            this.Controls.Add(this.MusicNamePanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MusicPlayer";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.sound)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.close)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.min)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nextbutton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playbutton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.previousbutton)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            this.MusicNamePanel.ResumeLayout(false);
            this.panelbackvioce1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox close;
        private System.Windows.Forms.PictureBox min;
        private System.Windows.Forms.PictureBox previousbutton;
        private System.Windows.Forms.PictureBox playbutton;
        private System.Windows.Forms.PictureBox nextbutton;
        private System.Windows.Forms.PictureBox sound;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 添加音乐ToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        private System.Windows.Forms.Panel MusicNamePanel;
        private System.Windows.Forms.Label musicname_label;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        public System.Windows.Forms.ListBox playlist;
        private TransParentListBox transParentListBox1;
        private System.Windows.Forms.Panel panelbackvioce1;
        private System.Windows.Forms.Panel viocepanel2;
    }
}

