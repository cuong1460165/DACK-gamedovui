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

namespace DoAn_CNPM
{
    public partial class PlayGame : Form
    {
        public PlayGame()
        {
            InitializeComponent();
        }
        static Random rnd = new Random();
        static int sec = 30;
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
            tien = 100;
            stt = 0;
            sec = 30;
        }
        private async void PlayGame_Load(object sender, EventArgs e)
        {
            tmSec.Enabled = true;
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
            string sec1 = Math.Floor(Double.Parse((sec / 10).ToString())).ToString();
            string sec2 = (sec % 10).ToString();
            lblTime.Text = sec1 + sec2;
            lblSTT.Text = "Câu " + (stt + 1).ToString();
            lblQues.Text = ListQues[stt].Des;
            lblMoney.Text = tien.ToString();
            btndapanA.Text = ListQues[stt].A;
            btndapanB.Text = ListQues[stt].B;
            btndapanC.Text = ListQues[stt].C;
            btndapanD.Text = ListQues[stt].D;
        }

        private void btndapanA_Click(object sender, EventArgs e)
        {
            if (btndapanA.Text == ListQues[stt].DA)
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
                    sec = 30;
                    btndapanA.Visible = true;
                    btndapanB.Visible = true;
                    btndapanC.Visible = true;
                    btndapanD.Visible = true;
                    PlayGame_Load(sender, e);
                    mbegin.Stop();
                }
                if (dialogResult == DialogResult.No)
                {
                    RenewAll();
                    mbegin.Stop();
                    this.Close();
                    var wd2 = new Menu();
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
                RenewAll();
                this.Close();
                var wd2 = new Menu();
                wd2.Show();
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
                    sec = 30;
                    btndapanA.Visible = true;
                    btndapanB.Visible = true;
                    btndapanC.Visible = true;
                    btndapanD.Visible = true;
                    PlayGame_Load(sender, e);
                    mbegin.Stop();
                }

                if (dialogResult == DialogResult.No)
                {
                    RenewAll();
                    mbegin.Stop();
                    this.Close();
                    var wd2 = new Menu();
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
                RenewAll();
                this.Close();
                var wd2 = new Menu();
                wd2.Show();
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
                    sec = 30;
                    btndapanA.Visible = true;
                    btndapanB.Visible = true;
                    btndapanC.Visible = true;
                    btndapanD.Visible = true;
                    PlayGame_Load(sender, e);
                    mbegin.Stop();
                }
                if (dialogResult == DialogResult.No)
                {
                    RenewAll();
                    mbegin.Stop();
                    this.Close();
                    var wd2 = new Menu();
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
                RenewAll();
                this.Close();
                var wd2 = new Menu();
                wd2.Show();
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
                    sec = 30;
                    btndapanA.Visible = true;
                    btndapanB.Visible = true;
                    btndapanC.Visible = true;
                    btndapanD.Visible = true;
                    PlayGame_Load(sender, e);
                    mbegin.Stop();
                }
                if (dialogResult == DialogResult.No)
                {
                    RenewAll();
                    mbegin.Stop();
                    this.Close();
                    var wd2 = new Menu();
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
                RenewAll();
                this.Close();
                var wd2 = new Menu();
                wd2.Show();
            }
        }

        private void tmSec_Tick(object sender, EventArgs e)
        {
            if (sec == 0)
            {
                tmSec.Enabled = false;
                String temp = strResult();
                String link = "E:/Ima-Mus/Sounds/dap/" + temp + "sai.wav";
                mbegin.SoundLocation = link.ToString();
                mbegin.Play();
                MessageBox.Show("Chơi Lại Đi Bạn Ơiiiiii !!!!");
                mbegin.Stop();
                RenewAll();
                this.Close();
                var wd2 = new Menu();
                wd2.Show();
            }
            else
            {
                sec = sec - 1;
            }
            PlayGame_Load(sender, e);
        }

        private void btn50_Click(object sender, EventArgs e)
        {
            Random rnd50 = new Random();
            int r, r2;
            do
            {
                r = rnd50.Next(2);
                r2 = rnd50.Next(2);
            } while (r == r2);
            if (btndapanA.Text == ListQues[stt].DA)
            {
                if (r == 0)
                {
                    btndapanB.Visible = false;
                    if (r2 == 1)
                        btndapanC.Visible = false;
                    if (r2 == 2)
                        btndapanD.Visible = false;
                }
                if (r == 1)
                {
                    btndapanC.Visible = false;
                    if (r2 == 0)
                        btndapanB.Visible = false;
                    if (r2 == 2)
                        btndapanD.Visible = false;
                }
                if (r == 2)
                {
                    btndapanD.Visible = false;
                    if (r2 == 0)
                        btndapanB.Visible = false;
                    if (r2 == 1)
                        btndapanC.Visible = false;
                }
            }
            else if (btndapanB.Text == ListQues[stt].DA)
            {
                if (r == 0)
                {
                    btndapanA.Visible = false;
                    if (r2 == 1)
                        btndapanC.Visible = false;
                    if (r2 == 2)
                        btndapanD.Visible = false;
                }
                else if (r == 1)
                {
                    btndapanC.Visible = false;
                    if (r2 == 0)
                        btndapanA.Visible = false;
                    if (r2 == 2)
                        btndapanD.Visible = false;
                }
                else if (r == 2)
                {
                    btndapanD.Visible = false;
                    if (r2 == 0)
                        btndapanA.Visible = false;
                    if (r2 == 1)
                        btndapanC.Visible = false;
                }
            }
            else if (btndapanC.Text == ListQues[stt].DA)
            {
                if (r == 0)
                {
                    btndapanA.Visible = false;
                    if (r2 == 1)
                        btndapanB.Visible = false;
                    if (r2 == 2)
                        btndapanD.Visible = false;
                }
                else if (r == 1)
                {
                    btndapanB.Visible = false;
                    if (r2 == 0)
                        btndapanA.Visible = false;
                    if (r2 == 2)
                        btndapanD.Visible = false;
                }
                else if (r == 2)
                {

                    btndapanD.Visible = false;
                    if (r2 == 0)
                        btndapanA.Visible = false;
                    if (r2 == 1)
                        btndapanB.Visible = false;
                }
            }
            else if (btndapanD.Text == ListQues[stt].DA)
            {
                if (r == 0)
                {
                    btndapanA.Visible = false;
                    if (r2 == 1)
                        btndapanB.Visible = false;
                    if (r2 == 2)
                        btndapanC.Visible = false;
                }
                else if (r == 1)
                {
                    btndapanB.Visible = false;
                    if (r2 == 0)
                        btndapanA.Visible = false;
                    if (r2 == 2)
                        btndapanC.Visible = false;
                }
                else if (r == 2)
                {
                    btndapanC.Visible = false;
                    if (r2 == 0)
                        btndapanA.Visible = false;
                    if (r2 == 1)
                        btndapanB.Visible = false;
                }
            }
        }
    }
}
