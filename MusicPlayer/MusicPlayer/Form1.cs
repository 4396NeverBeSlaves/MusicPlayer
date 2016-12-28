using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace MusicPlayer
{
    public partial class Form1 : Form
    {
        PathForm pathforms = new PathForm();
        
        string MusicNamestr;

        public Form1()
        {
            InitializeComponent();
        }

        private void close_up(object sender, MouseEventArgs e)
        {
            close.Image =(Image) Resource1.close_down;
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            close.Image = (Image)Resource1.close_up;
        }

        private void appclose(object sender, MouseEventArgs e)
        {
            this.Close();
        }


        private void pictureBox3_MouseMove(object sender, MouseEventArgs e)
        {
            previousbutton.Image = (Image)Resource1.previous_down;
        }

        private void pictureBox3_MouseLeave(object sender, EventArgs e)
        {
            previousbutton.Image = (Image)Resource1.previous_up;
        }

        private void pictureBox5_MouseMove(object sender, MouseEventArgs e)
        {
            nextbutton.Image = (Image)Resource1.next_down;
        }

        private void pictureBox5_MouseLeave(object sender, EventArgs e)
        {
            nextbutton.Image = (Image)Resource1.next_up;
        }

        private void pictureBox4_MouseMove(object sender, MouseEventArgs e)
        {
            if (playmusic == false)
            {
                playbutton.Image = Resource1.play_down;
            }
            else
            {
                playbutton.Image = Resource1.pause_down;
            }
        }

        private void pictureBox4_MouseLeave(object sender, EventArgs e)
        {
            if (playmusic == false)
            {
                playbutton.Image = Resource1.play_up;
            }
            else
            {
                playbutton.Image = Resource1.pause_up;
            }
        }

        private void pictureBox7_MouseDown(object sender, MouseEventArgs e)
        {
           
        }

        private void pictureBox7_MouseMove(object sender, MouseEventArgs e)
        {

        }

        private void pictureBox7_MouseUp(object sender, MouseEventArgs e)
        {
            
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {

        }

        private const int WM_NCHITTEST = 0x84;
        private const int HTCLIENT = 0x1;
        private const int HTCAPTION = 0x2;
        protected override void WndProc(ref Message id)
        {
            // 引用消息ID(ref Message ID)
            switch (id.Msg)
            {
                case WM_NCHITTEST:
                    base.WndProc(ref id);
                    if ((int)id.Result == HTCLIENT)
                        id.Result = (IntPtr)HTCAPTION;
                    return;
            }
            base.WndProc(ref id);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void sound_Click(object sender, EventArgs e)
        {
            
        }

        private void min_MouseLeave(object sender, EventArgs e)
        {
            min.Image = Resource1.min_up;
        }

        private void min_MouseMove(object sender, MouseEventArgs e)
        {
            min.Image = Resource1.min_down;
        }
        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            pathforms.ShowDialog();
        }

        //播放运行函数
        Boolean playmusic = false;
        public void play(string namepath)
        {
            this.axWindowsMediaPlayer1.URL = namepath;
            musicname_label.Text = this.axWindowsMediaPlayer1.currentMedia.name;
            playmusic = true;
            if (playmusic == true)
            {
                playbutton.Image = Resource1.pause_up;
            }
            else
            {
                playbutton.Image = Resource1.play_up;
            }

        }

        //音量控制
        public int voice;
        public void setVoice(int voice)
        {
            this.axWindowsMediaPlayer1.settings.volume = voice;
        }


        //播放与暂停音乐
        private void playbutton_Click(object sender, EventArgs e)
        {
            try{
            if (playmusic == false)
            {
                    if (axWindowsMediaPlayer1.URL.ToString() == "")
                    {
                        //如果没有选中歌曲的话点击播放默认为第一首
                        axWindowsMediaPlayer1.URL = pathforms.PathListbox.Items[0].ToString();
                        playmusic = true;
                        musicname_label.Text = transParentListBox1.Items[0].ToString();
                        transParentListBox1.SetSelected(0, true);
                    }
                    this.axWindowsMediaPlayer1.Ctlcontrols.play();
                    //playbutton.Image = Resource1.pause_up;
                    playmusic = true;
                }
            else
            {
                this.axWindowsMediaPlayer1.Ctlcontrols.pause();
                playbutton.Image = Resource1.pause_up;
                playmusic = false;
            }
            }
            catch(Exception ) { MessageBox.Show("请在下方右键添加歌曲！","提示", MessageBoxButtons.OK); }
        }


        //添加音乐
        private void 添加音乐ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string[] filepath = openFileDialog1.FileNames;
                for (int i = 0; i < filepath.Length; i++)
                {
                    //playlist.Items.Add(Path.GetFileNameWithoutExtension(filepath[i]));
                    transParentListBox1.Items.Add(Path.GetFileNameWithoutExtension(filepath[i]));
                    pathforms.PathListbox.Items.Add(filepath[i]);
                }
            }
        }
        //表里面双击播放音乐
        private void playlist_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            
            //MusicNamestr = playlist.SelectedItem.ToString();
            MusicNamestr = transParentListBox1.SelectedItem.ToString();
            musicname_label.Text = MusicNamestr;
            foreach (object songPath in pathforms.PathListbox.Items)
            {
                string lujing = songPath.ToString();
                string str1 = Path.GetFileNameWithoutExtension(lujing);
                if (str1 == MusicNamestr)
                {
                    axWindowsMediaPlayer1.URL = lujing;
                    playmusic = true;
                    playbutton.Image = Resource1.pause_up;
                    break;
                }
            }
            /*axWindowsMediaPlayer1.URL = ;
            axWindowsMediaPlayer1.Ctlcontrols.play();
            /*string str1 = ob.ToString();
            string str2 = Path.GetFileNameWithoutExtension(str1); */
        }

        //上一曲
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            string str = musicname_label.Text;
            int flag = 0;
            for (int i = 0; i < transParentListBox1.Items.Count; i++)
            {
                if (str == transParentListBox1.Items[i].ToString())
                    flag = i;
            }
            if (flag == 0)
                return;
            axWindowsMediaPlayer1.URL =pathforms.PathListbox.Items[flag - 1].ToString();
            musicname_label.Text = transParentListBox1.Items[flag - 1].ToString();
            transParentListBox1.SelectedIndex = flag - 1;
            playbutton.Image = Resource1.pause_up;
            playmusic = true;
        }

        //下一曲
        private void next_Click(object sender, EventArgs e)
        {
            string str = musicname_label.Text;
            int flag = 0;
            for (int i = 0; i < transParentListBox1.Items.Count; i++)
            {
                if (str == transParentListBox1.Items[i].ToString())
                    flag = i;
            }
            if (flag == transParentListBox1.Items.Count-1)
                return;
            axWindowsMediaPlayer1.URL = pathforms.PathListbox.Items[flag +1].ToString();
            musicname_label.Text = transParentListBox1.Items[flag + 1].ToString();
            transParentListBox1.SelectedIndex = flag + 1;
            playbutton.Image = Resource1.pause_up;
            playmusic = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //play(MusicFilePath[MusicNum]);
        }

        private void viocepanel2_MouseDown(object sender, MouseEventArgs e)
        {
            voice = e.Location.X;
            viocepanel2.Size = new Size(e.Location.X, 20);
            setVoice(voice);
        }

        private void panelbackvioce1_MouseDown(object sender, MouseEventArgs e)
        {
            voice = e.Location.X;
            setVoice(voice);
            viocepanel2.Size = new Size(e.Location.X, 20);
        }


    }
}
