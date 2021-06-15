using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace FFmpegApp
{
    public partial class Form1 : Form
    {
        Process FProcess;
        public Form1()
        {
            InitializeComponent();
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void buttonOpenPath_Click(object sender, EventArgs e)
        {
            OpenFileDialog f = new OpenFileDialog();
            f.Filter = "视频文件|*.mp4;*.avi;*.flv";
            f.FilterIndex = 1;
            DialogResult re = f.ShowDialog();
            string FileOpenPath = f.FileName;
            if (re == DialogResult.OK)
            {
                textBox1.Text = f.FileName;
            }
        }

        private void buttonSavePath_Click(object sender, EventArgs e)
        {
            SaveFileDialog s = new SaveFileDialog();
            s.Filter= "视频文件|*.mp4;*.flv;*.avi|音频文件|*.mp3|图片文件|*.png;*.jpg;*.gif";
            s.FilterIndex = 1;
            DialogResult re = s.ShowDialog();
            string FileSavePath = s.FileName;
            if (re == DialogResult.OK)
            {
                textBox2.Text = s.FileName;
            }
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            string Fpath = "ffmpeg.exe";
            if (File.Exists(Fpath))
            {
                FProcess = new Process();
                FProcess.StartInfo.FileName = "ffmpeg.exe";
                FProcess.StartInfo.Arguments = $"-i {textBox1.Text} {textBox2.Text}";
                FProcess.Start();
            }
            else
            {
                MessageBox.Show("出现错误！不能开始！因为当前目录下缺少ffmpeg.exe文件！");
            }
        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
