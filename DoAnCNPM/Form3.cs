using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows;
namespace DoAnCNPM
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        static Random rnd = new Random();
        static int sec = 20;
        static List<CauHoi> list = new List<CauHoi>();
        static List<CauHoi> ListQues = new List<CauHoi>();
        static int stt = 0;
        static int tien = 100;
        static int[] temprd = new int[16];
        static System.Media.SoundPlayer mbegin = new System.Media.SoundPlayer();
       public String strResult()
        {
            String temp = "";
            if (ListQues[stt].A == ListQues[stt].DA)
            {
                temp = "a";
            }
            else if (ListQues[stt].B == ListQues[stt].DA)
            {
                temp = "b";
            }
            else if (ListQues[stt].C == ListQues[stt].DA)
            {
                temp = "c";
            }
            else if (ListQues[stt].D == ListQues[stt].DA)
            {
                temp = "d";
            }
            return temp;
        }
        public void RenewAll()
        {
            list = new List<CauHoi>();
            ListQues = new List<CauHoi>();
            tien = 0;
            stt = 0;
        }
        private async void Form3_Load(object sender, EventArgs e)
        {

            if (list.Count == 0)
            {
                using (StreamReader sr = new StreamReader(@"E:\file.txt", Encoding.UTF8))
                {
                    String line = await sr.ReadToEndAsync();

                    string[] tokens = line.Split(new string[] { ".", "\r\n" }, StringSplitOptions.None);

                    for (int i = 0; i < tokens.Length - i * 7; i++)
                    {
                        var a = new CauHoi();
                        a.STT = tokens[i * 7].ToString();
                        a.Des = tokens[i * 7 + 1].ToString();
                        a.A = tokens[i * 7 + 2].ToString();
                        a.B = tokens[i * 7 + 3].ToString();
                        a.C = tokens[i * 7 + 4].ToString();
                        a.D = tokens[i * 7 + 5].ToString();
                        a.DA = tokens[i * 7 + 6].ToString();
                        list.Add(a);
                    }
                }
                if (ListQues.Count == 0)
                {
                    int r = 0, j = 0;
                    int count = 0;
                    for (int k = 0; ListQues.Count <= 5; k++)
                    {
                        r = rnd.Next(list.Count);
                        if (r == 0)
                        {
                            r = rnd.Next(list.Count);
                        }
                        for (int i = 0; i < 15; i++)
                        {
                            if (temprd[i] != r)
                            {
                                count++;
                            }
                        }
                        if (count == 15)
                        {
                            temprd[j] = r;
                            j++;
                            ListQues.Add(list[r - 1]);
                        }
                        count = 0;
                    }
                }
            }
            lbcauHoi.Text = "Câu " + (stt + 1).ToString();
            lblQues.Text = ListQues[stt].Des;
            lbmucTien.Text = tien.ToString();
            btndapanA.Text = ListQues[stt].A;
            btndapanB.Text = ListQues[stt].B;
            btndapanC.Text = ListQues[stt].C;
            btndapanD.Text = ListQues[stt].D;
        }
        private void btndapanA_Click(object sender, EventArgs e)
        {
            if(btndapanA.Text == ListQues[stt].DA)
            {
                mbegin.SoundLocation = "E:/Ima-Mus/Sounds/dap/dung.wav";
                mbegin.Play();
                DialogResult dialogResult = MessageBox.Show("Chơi Tiếp", "Thông Báo", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    tien = tien * 2;
                    stt++;
                    if(stt > 5)
                    {
                        MessageBox.Show("You are win");
                        this.Close();
                    }
                    Form3_Load(sender, e);
                    mbegin.Stop();
                }
                if(dialogResult == DialogResult.No)
                {
                    RenewAll();
                    this.Close();
                    var wd2 = new Form2();
                    wd2.Show();
                }
            }
            else
            {
                String temp = strResult();
                String link = "E:/Ima-Mus/Sounds/dap/" + temp + "sai.wav";
                mbegin.SoundLocation = link;
                mbegin.Play();
                MessageBox.Show("Lose");
                mbegin.Stop();
            }
        }

        private void btndapanB_Click(object sender, EventArgs e)
        {
            if (btndapanB.Text == ListQues[stt].DA)
            {
                mbegin.SoundLocation = "E:/Ima-Mus/Sounds/dap/dung.wav";
                mbegin.Play();
                DialogResult dialogResult = MessageBox.Show("Chơi Tiếp", "Thông Báo", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    tien = tien * 2;
                    stt++;
                    if (stt > 5)
                    {
                        MessageBox.Show("You are win");
                        this.Close();
                    }
                    Form3_Load(sender, e);
                    mbegin.Stop();
                }

                if (dialogResult == DialogResult.No)
                {
                    RenewAll();
                    this.Close();
                    var wd2 = new Form2();
                    wd2.Show();
                }
            }
            else
            {
                String temp = strResult();
                String link = "E:/Ima-Mus/Sounds/dap/" + temp + "sai.wav";
                mbegin.SoundLocation = link;
                mbegin.Play();
                MessageBox.Show("Lose");
                mbegin.Stop();
            }
        }

        private void btndapanC_Click(object sender, EventArgs e)
        {
            if (btndapanC.Text == ListQues[stt].DA)
            {
                mbegin.SoundLocation = "E:/Ima-Mus/Sounds/dap/dung.wav";
                mbegin.Play();
                DialogResult dialogResult = MessageBox.Show("Chơi Tiếp", "Thông Báo", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    tien = tien * 2;
                    stt++;
                    if (stt > 5)
                    {
                        MessageBox.Show("You are win");
                        this.Close();
                    }
                    Form3_Load(sender, e);
                    mbegin.Stop();
                }
                if (dialogResult == DialogResult.No)
                {
                    RenewAll();
                    this.Close();
                    var wd2 = new Form2();
                    wd2.Show();
                }
            }
            else
            {
                String temp = strResult();
                String link = "E:/Ima-Mus/Sounds/dap/" + temp + "sai.wav";
                mbegin.SoundLocation = link;
                mbegin.Play();
                MessageBox.Show("Lose");
                mbegin.Stop();
            }
        }

        private void btndapanD_Click(object sender, EventArgs e)
        {           
            if (btndapanD.Text == ListQues[stt].DA)
            {
                mbegin.SoundLocation = "E:/Ima-Mus/Sounds/dap/dung.wav";
                mbegin.Play();
                DialogResult dialogResult = MessageBox.Show("Chơi Tiếp", "Thông Báo", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    tien = tien * 2;
                    stt++;
                    if (stt > 5)
                    {
                        MessageBox.Show("You are win");
                        this.Close();
                    }
                    Form3_Load(sender, e);
                    mbegin.Stop();
                }
                if (dialogResult == DialogResult.No)
                {
                    RenewAll();
                    this.Close();
                    var wd2 = new Form2();
                    wd2.Show();
                }
            }
            else
            {
                String temp = strResult();
                String link = "E:/Ima-Mus/Sounds/dap/" + temp + "sai.wav";
                mbegin.SoundLocation = link.ToString();
                mbegin.Play();
                MessageBox.Show("Lose");
                mbegin.Stop();
            }
        }
    }
}
