using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnCNPM
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        static System.Media.SoundPlayer mbegin = new System.Media.SoundPlayer();
        private void Form1_Load(object sender, EventArgs e)
        {
            mbegin.SoundLocation = "E:/Ima-Mus/Sounds/nhacnen/begin.wav";
            mbegin.Play();
            var worker = new BackgroundWorker();
            worker.WorkerReportsProgress = true;
            worker.ProgressChanged += backgroundWorker_ProgressChanged;
            worker.RunWorkerCompleted += backgroundWorker_RunWorkerCompleted;
            worker.DoWork += backgroundWorker_DoWork;
            worker.RunWorkerAsync();
        }

        private void backgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            for(int i =0; i<60 ; i++)
            {
                (sender as BackgroundWorker).ReportProgress(i);
                Thread.Sleep(60);
            }
        }

        private void backgroundWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            var window = new Form2();
            mbegin.Stop();
            this.Hide();
            window.Show();
        }

        private void backgroundWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBar1.Value = e.ProgressPercentage;
        }
    }
}
