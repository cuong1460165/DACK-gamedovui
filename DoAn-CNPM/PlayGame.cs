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
using System.Drawing.Imaging;
using System.Runtime.InteropServices;

namespace DoAn_CNPM
{

    public partial class PlayGame : Form
    {
        public PlayGame()
        {
            InitializeComponent();
            lblCheck.Text = User.label.ToString();
            User.label = 0;
        }
        static Random rnd = new Random();
        static int sec = 30;
        static List<CauHoi> list = new List<CauHoi>();
        static List<CauHoi> ListQues = new List<CauHoi>();
        static int stt = 0;
        static int tien = 100;
        static int[] temprd = new int[16];
        static System.Media.SoundPlayer mbegin = new System.Media.SoundPlayer();
        static string HelperName = "";
        static int secCall = 0;
        static int Helper = 0;
        static int Audience = 0;
        static int fifty = 0;
        static string remberfifty = "";
        static int remberclick50 = 0;
        CustomListView cus = new CustomListView();
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
            Helper = 0;
            Audience = 0;
            fifty = 0;
            secCall = 0;
        }
        public void EqualAnswer(String answer, object sender,EventArgs e)
        {
            if (answer == ListQues[stt].DA)
            {
                mbegin.SoundLocation = "E:/Ima-Mus/Sounds/dap/dung.wav";
                pnlCall.Visible = false;
                pnlAu.Visible = false;
                //Helper = 0;
                //Audience = 0;
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
                    tmSec.Enabled = false;
                    pnlSave.Visible = true;
                    btnHighScore.Visible = true;
                    lblHighScore.Text = lblMoney.Text;
                    btnSave.Visible = false;
                    pnlSave.Show();
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
        private async void PlayGame_Load(object sender, EventArgs e)
        {
            tmSec.Enabled = true;
            if(lblCheck.Text == "1")
            {
                var user = new User();
                using (StreamReader sr = new StreamReader(@"E:\save.txt", Encoding.UTF8))
                {              
                    String line = await sr.ReadToEndAsync();
                    string[] tokens = line.Split(new string[] { ".", "\r\n" }, StringSplitOptions.None);
                    user.Name = tokens[0];
                    user.HighScore = tokens[1];
                    user.NumQues = Int32.Parse(tokens[2]);
                    user.Fifty = Int32.Parse(tokens[3]);
                    user.helper = Int32.Parse(tokens[4]);
                    user.audience = Int32.Parse(tokens[5]);
                    user.rememberclick50 = Int32.Parse(tokens[6]);
                }
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
                if(user.Fifty == 1)
                {
                    btn50.BackgroundImage = DoAn_CNPM.Properties.Resources.dauXE;
                    btn50.BackgroundImageLayout = ImageLayout.Stretch;
                    btn50.Enabled = false;
                    fifty = 1;
                }
                if(user.helper == 2)
                {
                    btnCall.BackgroundImage = DoAn_CNPM.Properties.Resources.dauXE;
                    btnCall.BackgroundImageLayout = ImageLayout.Stretch;
                    btnCall.Enabled = false;
                    Helper = 2;
                }
                if(user.audience == 2)
                {
                    btnAu.BackgroundImage = DoAn_CNPM.Properties.Resources.dauXE;
                    btnAu.BackgroundImageLayout = ImageLayout.Stretch;
                    btnAu.Enabled = false;
                    Audience = 2;
                }
                remberclick50 = user.rememberclick50;
                lblSTT.Text = "Câu " + (user.NumQues).ToString();
                lblMoney.Text = user.HighScore.ToString();
                stt = user.NumQues - 1;
                tien = Int32.Parse(user.HighScore.ToString());
                lblCheck.Text = "0";
            }
            else
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
                lblSTT.Text = "Câu " + (stt + 1).ToString();
                lblMoney.Text = tien.ToString();
            }
            string sec1 = Math.Floor(Double.Parse((sec / 10).ToString())).ToString();
            string sec2 = (sec % 10).ToString();
            lblTime.Text = sec1 + sec2;
            lblSTT.Text = "Câu " + (stt + 1).ToString();
            lblQues.Text = ListQues[stt].Des;
            //lblMoney.Text = tien.ToString();
            btndapanA.Text = ListQues[stt].A;
            btndapanB.Text = ListQues[stt].B;
            btndapanC.Text = ListQues[stt].C;
            btndapanD.Text = ListQues[stt].D;
            if(Helper == 1)
            {
                HelperName = listView1.SelectedItems[0].SubItems[0].Text;
                List<String> liststr = new List<String>();
                string str1 = HelperName + ":" + " Xin chào." + "\r\n";
                string str2 = "MC: Xin chào " + HelperName +
                        " bạn của bạn đang ở câu hỏi mức $" + tien.ToString() + " và đang cần sự giúp đỡ.\r\n";
                string str3 = "Bạn: " + HelperName + " .... Điền vào chỗ trống: " + ListQues[stt].Des + "\r\n";
                string str4 = HelperName + ": Câu trả lời là " + ListQues[stt].DA + "\r\n";
                string str5 = "Bạn: Cậu có chắc chắn chứ ?\r\n";
                string str6 = HelperName + ": Tôi chắc chắn 100%.";
                liststr.Add(str1);
                liststr.Add(str2);
                liststr.Add(str3);
                liststr.Add(str4);
                liststr.Add(str5);
                liststr.Add(str6);
                if (secCall <= 5)
                {
                    rtxtBoxCall.Text = rtxtBoxCall.Text + liststr[secCall];
                }
            }
        }

        private void btndapanA_Click(object sender, EventArgs e)
        {
            EqualAnswer(btndapanA.Text, sender, e);
        }
        private void btndapanB_Click(object sender, EventArgs e)
        {
            EqualAnswer(btndapanB.Text, sender, e);
        }
        private void btndapanC_Click(object sender, EventArgs e)
        {
            EqualAnswer(btndapanC.Text, sender, e);
        }
        private void btndapanD_Click(object sender, EventArgs e)
        {
            EqualAnswer(btndapanD.Text, sender, e);
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
            else if(Helper == 1 || Audience == 1)
            {
                tmSec.Enabled = false;
            }
            else
            {
                sec = sec - 1;
                PlayGame_Load(sender, e);
            }
        }

        private void btn50_Click(object sender, EventArgs e)
        {
            remberclick50 = 1;
            btn50.Enabled = false;
            fifty = 1;
            btn50.BackgroundImage = DoAn_CNPM.Properties.Resources.dauXE;
            btn50.BackgroundImageLayout = ImageLayout.Stretch;
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
                    {
                        btndapanC.Visible = false;
                        remberfifty = "d";
                    }
                    if (r2 == 2)
                    {
                        btndapanD.Visible = false;
                        remberfifty = "c";
                    }
                }
                if (r == 1)
                {
                    btndapanC.Visible = false;
                    if (r2 == 0)
                    {
                        btndapanB.Visible = false;
                        remberfifty = "d";
                    }
                    if (r2 == 2)
                    {
                        btndapanD.Visible = false;
                        remberfifty = "b";
                    }
                }
                if (r == 2)
                {
                    btndapanD.Visible = false;
                    if (r2 == 0)
                    {
                        btndapanB.Visible = false;
                        remberfifty = "c";
                    }
                    if (r2 == 1)
                    {
                        btndapanC.Visible = false;
                        remberfifty = "b";
                    }
                }
            }
            else if (btndapanB.Text == ListQues[stt].DA)
            {
                if (r == 0)
                {
                    btndapanA.Visible = false;
                    if (r2 == 1)
                    {
                        btndapanC.Visible = false;
                        remberfifty = "d";
                    }
                    if (r2 == 2)
                    {
                        btndapanD.Visible = false;
                        remberfifty = "c";
                    }
                }
                else if (r == 1)
                {
                    btndapanC.Visible = false;
                    if (r2 == 0)
                    {
                        btndapanA.Visible = false;
                        remberfifty = "d";
                    }
                    if (r2 == 2)
                    {
                        btndapanD.Visible = false;
                        remberfifty = "a";
                    }
                }
                else if (r == 2)
                {
                    btndapanD.Visible = false;
                    if (r2 == 0)
                    {
                        btndapanA.Visible = false;
                        remberfifty = "c";
                    }
                    if (r2 == 1)
                    {
                        btndapanC.Visible = false;
                        remberfifty = "a";
                    }
                }
            }
            else if (btndapanC.Text == ListQues[stt].DA)
            {
                if (r == 0)
                {
                    btndapanA.Visible = false;
                    if (r2 == 1)
                    {
                        btndapanB.Visible = false;
                        remberfifty = "d";
                    }
                    if (r2 == 2)
                    {
                        btndapanD.Visible = false;
                        remberfifty = "b";
                    }
                }
                else if (r == 1)
                {
                    btndapanB.Visible = false;
                    if (r2 == 0)
                    {
                        btndapanA.Visible = false;
                        remberfifty = "d";
                    }
                    if (r2 == 2)
                    {
                        btndapanD.Visible = false;
                        remberfifty = "a";
                    }
                }
                else if (r == 2)
                {

                    btndapanD.Visible = false;
                    if (r2 == 0)
                    {
                        btndapanA.Visible = false;
                        remberfifty = "b";
                    }
                    if (r2 == 1)
                    {
                        btndapanB.Visible = false;
                        remberfifty = "a";
                    }
                }
            }
            else if (btndapanD.Text == ListQues[stt].DA)
            {
                if (r == 0)
                {
                    btndapanA.Visible = false;
                    if (r2 == 1)
                    {
                        btndapanB.Visible = false;
                        remberfifty = "c";
                    }
                    if (r2 == 2)
                    {
                        btndapanC.Visible = false;
                        remberfifty = "b";
                    }
                }
                else if (r == 1)
                {
                    btndapanB.Visible = false;
                    if (r2 == 0)
                    {
                        btndapanA.Visible = false;
                        remberfifty = "c";
                    }
                    if (r2 == 2)
                    {
                        btndapanC.Visible = false;
                        remberfifty = "a";
                    }
                }
                else if (r == 2)
                {
                    btndapanC.Visible = false;
                    if (r2 == 0)
                    {
                        btndapanA.Visible = false;
                        remberfifty = "b";
                    }
                    if (r2 == 1)
                    {
                        btndapanB.Visible = false;
                        remberfifty = "a";
                    }
                }
            }
        }

        private void btnCall_Click(object sender, EventArgs e)
        {
            btnCall.BackgroundImage = DoAn_CNPM.Properties.Resources.dauXE;
            btnCall.BackgroundImageLayout = ImageLayout.Stretch;
            btnPause.Visible = false;
            btnCall.Enabled = false;
            pnlAu.Visible = false;
            string[] row = { "Cuong","Dam Tac"};
            var listViewItem = new ListViewItem(row); 
            listView1.Items.Add(listViewItem);
            string[] row1 = { "Cuong2", "Dam Tac2" };
            var listViewItem1 = new ListViewItem(row1);
            listView1.Items.Add(listViewItem1);
            this.pnlCall.Show();
            mbegin.SoundLocation = "E:/Ima-Mus/Sounds/trogiup/nt/nguoithan-goichoai-1.wav";
            mbegin.Play();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            pnlCall.Visible = false;
            btnPause.Visible = true;
            btnPause.Enabled = true;
            if(btnCall.Enabled == false)
            {
                Helper = 2;
            }
            if(btnAu.Enabled == false)
            {
                Audience = 2;
            }
            rtxtBoxCall.Visible = false;
            tmSec.Enabled = true;
        }
        private void listView1_MouseClick(object sender, MouseEventArgs e)
        {
            mbegin.SoundLocation = "E:/Ima-Mus/Sounds/trogiup/nt/nguoithan-tut-4,.wav";
            mbegin.Play();
            Helper = 1;
            tmCall.Enabled = true;
            HelperName = listView1.SelectedItems[0].SubItems[0].Text;
            listView1.Visible = false;
            rtxtBoxCall.Show();
        }
        private void tmCall_Tick(object sender, EventArgs e)
        {
            if(secCall<= 5)
            {
                PlayGame_Load(sender, e);
                secCall++;
            }
            else
            {
                tmCall.Enabled = false;
            }
        }

        private void btnAu_Click(object sender, EventArgs e)
        {
            btnAu.BackgroundImage = DoAn_CNPM.Properties.Resources.dauXE;
            btnAu.BackgroundImageLayout = ImageLayout.Stretch;
            btnPause.Visible = false;
            btnAu.Enabled = false;
            pnlAu.Visible = true;
            Audience = 1;
            rtxtBoxCall.Visible = false;
            pnlCall.Show();
            if(fifty == 1 && remberclick50 == 1) 
            {
                 if (btndapanA.Text == ListQues[stt].DA)
                 {
                     int r1 = rnd.Next(70, 80);
                     this.Percent.Series["Percent"].Points.AddXY("A", r1);
                     if(remberfifty == "b")
                     {
                         this.Percent.Series["Percent"].Points.AddXY("B", 100-r1);
                         this.Percent.Series["Percent"].Points.AddXY("C", 0);
                         this.Percent.Series["Percent"].Points.AddXY("D", 0);
                         rtxtBoxAu.Text = r1 + "% khán giả chọn câu trả lời là " + btndapanA.Text + "\r\n" +
                                    (100-r1) + "% khán giả chọn câu trả lời là " + btndapanB.Text + "\r\n" +
                                    0 + "% khán giả chọn câu trả lời là " + btndapanC.Text + "\r\n" +
                                    0 + "% khán giả chọn câu trả lời là " + btndapanD.Text + "\r\n";
                     }
                     if (remberfifty == "c")
                     {
                         this.Percent.Series["Percent"].Points.AddXY("B", 0);
                         this.Percent.Series["Percent"].Points.AddXY("C", 100-r1);
                         this.Percent.Series["Percent"].Points.AddXY("D", 0);
                         rtxtBoxAu.Text = r1 + "% khán giả chọn câu trả lời là " + btndapanA.Text + "\r\n" +
                                    0 + "% khán giả chọn câu trả lời là " + btndapanB.Text + "\r\n" +
                                    (100-r1) + "% khán giả chọn câu trả lời là " + btndapanC.Text + "\r\n" +
                                    0 + "% khán giả chọn câu trả lời là " + btndapanD.Text + "\r\n";
                     }
                     if(remberfifty == "d")
                     {
                         this.Percent.Series["Percent"].Points.AddXY("B", 0);
                         this.Percent.Series["Percent"].Points.AddXY("C", 0);
                         this.Percent.Series["Percent"].Points.AddXY("D", 100-r1);
                         rtxtBoxAu.Text = r1 + "% khán giả chọn câu trả lời là " + btndapanA.Text + "\r\n" +
                                    0 + "% khán giả chọn câu trả lời là " + btndapanB.Text + "\r\n" +
                                    0 + "% khán giả chọn câu trả lời là " + btndapanC.Text + "\r\n" +
                                    (100 - r1) + "% khán giả chọn câu trả lời là " + btndapanD.Text + "\r\n";
                     }
                 }
                 else if(btndapanB.Text == ListQues[stt].DA)
                 {
                     int r1 = rnd.Next(70, 80);
                     if(remberfifty == "a")
                     {
                         this.Percent.Series["Percent"].Points.AddXY("A", 100-r1);
                         this.Percent.Series["Percent"].Points.AddXY("B", r1);
                         this.Percent.Series["Percent"].Points.AddXY("C", 0);
                         this.Percent.Series["Percent"].Points.AddXY("D", 0);
                         rtxtBoxAu.Text = (100-r1) + "% khán giả chọn câu trả lời là " + btndapanA.Text + "\r\n" +
                                    r1 + "% khán giả chọn câu trả lời là " + btndapanB.Text + "\r\n" +
                                    0 + "% khán giả chọn câu trả lời là " + btndapanC.Text + "\r\n" +
                                    0 + "% khán giả chọn câu trả lời là " + btndapanD.Text + "\r\n";
                     }
                     if(remberfifty == "c")
                     {
                         this.Percent.Series["Percent"].Points.AddXY("A", 0);
                         this.Percent.Series["Percent"].Points.AddXY("B", r1);
                         this.Percent.Series["Percent"].Points.AddXY("C", 100-r1);
                         this.Percent.Series["Percent"].Points.AddXY("D", 0);
                         rtxtBoxAu.Text = 0 + "% khán giả chọn câu trả lời là " + btndapanA.Text + "\r\n" +
                                    r1 + "% khán giả chọn câu trả lời là " + btndapanB.Text + "\r\n" +
                                    (100-r1) + "% khán giả chọn câu trả lời là " + btndapanC.Text + "\r\n" +
                                    0 + "% khán giả chọn câu trả lời là " + btndapanD.Text + "\r\n";
                     }
                     if(remberfifty == "d")
                     {
                         this.Percent.Series["Percent"].Points.AddXY("A", 0);
                         this.Percent.Series["Percent"].Points.AddXY("B", r1);
                         this.Percent.Series["Percent"].Points.AddXY("C", 0);
                         this.Percent.Series["Percent"].Points.AddXY("D", 100-r1);
                         rtxtBoxAu.Text = 0 + "% khán giả chọn câu trả lời là " + btndapanA.Text + "\r\n" +
                                    r1 + "% khán giả chọn câu trả lời là " + btndapanB.Text + "\r\n" +
                                    (100-r1) + "% khán giả chọn câu trả lời là " + btndapanC.Text + "\r\n" +
                                    0 + "% khán giả chọn câu trả lời là " + btndapanD.Text + "\r\n";
                     }
                 }
                 else if(btndapanC.Text == ListQues[stt].DA)
                 {
                     int r1 = rnd.Next(70, 80);
                     if(remberfifty == "a")
                     {
                         this.Percent.Series["Percent"].Points.AddXY("A", 100-r1);
                         this.Percent.Series["Percent"].Points.AddXY("B", 0);
                         this.Percent.Series["Percent"].Points.AddXY("C", r1);
                         this.Percent.Series["Percent"].Points.AddXY("D", 0);
                         rtxtBoxAu.Text = (100-r1) + "% khán giả chọn câu trả lời là " + btndapanA.Text + "\r\n" +
                                    0 + "% khán giả chọn câu trả lời là " + btndapanB.Text + "\r\n" +
                                    (r1) + "% khán giả chọn câu trả lời là " + btndapanC.Text + "\r\n" +
                                    0 + "% khán giả chọn câu trả lời là " + btndapanD.Text + "\r\n";
                     }
                     else if(remberfifty == "b")
                     {
                         this.Percent.Series["Percent"].Points.AddXY("A", 0);
                         this.Percent.Series["Percent"].Points.AddXY("B", 100-r1);
                         this.Percent.Series["Percent"].Points.AddXY("C", r1);
                         this.Percent.Series["Percent"].Points.AddXY("D", 0);
                         rtxtBoxAu.Text = 0 + "% khán giả chọn câu trả lời là " + btndapanA.Text + "\r\n" +
                                    (100 - r1) + "% khán giả chọn câu trả lời là " + btndapanB.Text + "\r\n" +
                                    (r1) + "% khán giả chọn câu trả lời là " + btndapanC.Text + "\r\n" +
                                    0 + "% khán giả chọn câu trả lời là " + btndapanD.Text + "\r\n";
                     }
                     else if (remberfifty == "d")
                     {
                         this.Percent.Series["Percent"].Points.AddXY("A", 0);
                         this.Percent.Series["Percent"].Points.AddXY("B",0);
                         this.Percent.Series["Percent"].Points.AddXY("C", r1);
                         this.Percent.Series["Percent"].Points.AddXY("D", 100 - r1);
                         rtxtBoxAu.Text = 0 + "% khán giả chọn câu trả lời là " + btndapanA.Text + "\r\n" +
                                    0 + "% khán giả chọn câu trả lời là " + btndapanB.Text + "\r\n" +
                                    (r1) + "% khán giả chọn câu trả lời là " + btndapanC.Text + "\r\n" +
                                     (100 - r1) + "% khán giả chọn câu trả lời là " + btndapanD.Text + "\r\n";
                     }
                 }
                 else if(btndapanD.Text == ListQues[stt].DA)
                 {
                     int r1 = rnd.Next(70, 80);
                     if(remberfifty == "a")
                     {
                         this.Percent.Series["Percent"].Points.AddXY("A", 100-r1);
                         this.Percent.Series["Percent"].Points.AddXY("B", 0);
                         this.Percent.Series["Percent"].Points.AddXY("C", 0);
                         this.Percent.Series["Percent"].Points.AddXY("D", r1);
                         rtxtBoxAu.Text = (100 - r1) + "% khán giả chọn câu trả lời là " + btndapanA.Text + "\r\n" +
                                    0 + "% khán giả chọn câu trả lời là " + btndapanB.Text + "\r\n" +
                                    0 + "% khán giả chọn câu trả lời là " + btndapanC.Text + "\r\n" +
                                     (r1) + "% khán giả chọn câu trả lời là " + btndapanD.Text + "\r\n";
                     }
                     else if(remberfifty == "b")
                     {
                         this.Percent.Series["Percent"].Points.AddXY("A", 0);
                         this.Percent.Series["Percent"].Points.AddXY("B", 100 - r1);
                         this.Percent.Series["Percent"].Points.AddXY("C", 0);
                         this.Percent.Series["Percent"].Points.AddXY("D", r1);
                         rtxtBoxAu.Text = 0 + "% khán giả chọn câu trả lời là " + btndapanA.Text + "\r\n" +
                                    (100 - r1) + "% khán giả chọn câu trả lời là " + btndapanB.Text + "\r\n" +
                                    0 + "% khán giả chọn câu trả lời là " + btndapanC.Text + "\r\n" +
                                     (r1) + "% khán giả chọn câu trả lời là " + btndapanD.Text + "\r\n";
                     }
                     else if (remberfifty == "c")
                     {
                         this.Percent.Series["Percent"].Points.AddXY("A", 0);
                         this.Percent.Series["Percent"].Points.AddXY("B", 0);
                         this.Percent.Series["Percent"].Points.AddXY("C", 100 - r1);
                         this.Percent.Series["Percent"].Points.AddXY("D", r1);
                         rtxtBoxAu.Text = 0 + "% khán giả chọn câu trả lời là " + btndapanA.Text + "\r\n" +
                                    0 + "% khán giả chọn câu trả lời là " + btndapanB.Text + "\r\n" +
                                    (100 - r1) + "% khán giả chọn câu trả lời là " + btndapanC.Text + "\r\n" +
                                     (r1) + "% khán giả chọn câu trả lời là " + btndapanD.Text + "\r\n";
                     }
                 }

            }
            else
            {
                if (btndapanA.Text == ListQues[stt].DA)
                {
                    int r1 = rnd.Next(50, 60);
                    this.Percent.Series["Percent"].Points.AddXY("A", r1);
                    int r2 = rnd.Next(15, 20);
                    this.Percent.Series["Percent"].Points.AddXY("B", r2);
                    int r3 = rnd.Next(5, 10);
                    this.Percent.Series["Percent"].Points.AddXY("C", r3);
                    this.Percent.Series["Percent"].Points.AddXY("D", 100 - r1 - r2 - r3);
                    rtxtBoxAu.Text = r1 + "% khán giả chọn câu trả lời là " + btndapanA.Text + "\r\n" +
                                     r2 + "% khán giả chọn câu trả lời là " + btndapanB.Text + "\r\n" +
                                     r3 + "% khán giả chọn câu trả lời là " + btndapanC.Text + "\r\n" +
                                     (100 - r1 - r2 - r3) + "% khán giả chọn câu trả lời là " + btndapanD.Text + "\r\n";

                }
                if (btndapanB.Text == ListQues[stt].DA)
                {
                    int r2 = rnd.Next(50, 60);
                    int r1 = rnd.Next(15, 20);
                    this.Percent.Series["Percent"].Points.AddXY("A", r1);
                    this.Percent.Series["Percent"].Points.AddXY("B", r2);
                    int r3 = rnd.Next(5, 10);
                    this.Percent.Series["Percent"].Points.AddXY("C", r3);
                    this.Percent.Series["Percent"].Points.AddXY("D", 100 - r1 - r2 - r3);
                    rtxtBoxAu.Text = r1 + "% khán giả chọn câu trả lời là " + btndapanA.Text + "\r\n" +
                                   r2 + "% khán giả chọn câu trả lời là " + btndapanB.Text + "\r\n" +
                                   r3 + "% khán giả chọn câu trả lời là " + btndapanC.Text + "\r\n" +
                                   (100 - r1 - r2 - r3) + "% khán giả chọn câu trả lời là " + btndapanD.Text + "\r\n";
                }
                if (btndapanC.Text == ListQues[stt].DA)
                {
                    int r3 = rnd.Next(50, 60);
                    int r1 = rnd.Next(15, 20);
                    this.Percent.Series["Percent"].Points.AddXY("A", r1);
                    int r2 = rnd.Next(5, 10);
                    this.Percent.Series["Percent"].Points.AddXY("B", r2);
                    this.Percent.Series["Percent"].Points.AddXY("C", r3);
                    this.Percent.Series["Percent"].Points.AddXY("D", 100 - r1 - r2 - r3);
                    rtxtBoxAu.Text = r1 + "% khán giả chọn câu trả lời là " + btndapanA.Text + "\r\n" +
                                   r2 + "% khán giả chọn câu trả lời là " + btndapanB.Text + "\r\n" +
                                   r3 + "% khán giả chọn câu trả lời là " + btndapanC.Text + "\r\n" +
                                   (100 - r1 - r2 - r3) + "% khán giả chọn câu trả lời là " + btndapanD.Text + "\r\n";
                }
                if (btndapanD.Text == ListQues[stt].DA)
                {
                    int r4 = rnd.Next(50, 60);
                    int r1 = rnd.Next(15, 20);
                    this.Percent.Series["Percent"].Points.AddXY("A", r1);
                    int r2 = rnd.Next(5, 10);
                    this.Percent.Series["Percent"].Points.AddXY("B", r2);
                    this.Percent.Series["Percent"].Points.AddXY("C", 100 - r1 - r2 - r4);
                    this.Percent.Series["Percent"].Points.AddXY("D", r4);
                    rtxtBoxAu.Text = r1 + "% khán giả chọn câu trả lời là " + btndapanA.Text + "\r\n" +
                                   r2 + "% khán giả chọn câu trả lời là " + btndapanB.Text + "\r\n" +
                                   (100 - r1 - r2 - r4) + "% khán giả chọn câu trả lời là " + btndapanC.Text + "\r\n" +
                                   r4 + "% khán giả chọn câu trả lời là " + btndapanD.Text + "\r\n";
                }
            }
        }

        private void btnPause_Click(object sender, EventArgs e)
        {
            tmSec.Enabled = false;
            DialogResult dialogResult = MessageBox.Show("Bạn có muốn lưu lại không", "Thông Báo", MessageBoxButtons.YesNo);
            if(dialogResult == DialogResult.Yes)
            {
                pnlSave.Visible = true;
                btnSave.Visible = true;
                btnHighScore.Visible = false;
                lblHighScore.Text = lblMoney.Text;
                pnlSave.Show();
            }
            else
            {
                RenewAll();
                Application.Exit();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(txtUserName.Text == "")
            {
                MessageBox.Show("Điền đầy đủ thông tin");
            }
            else
            {
                if(fifty == 1 && Audience == 0)
                {
                    remberclick50 = 0;
                }
                TextWriter txt = new StreamWriter(@"E:\save.txt");
                String str = txtUserName.Text + "." + lblHighScore.Text + "." + (stt + 1) + "." + fifty + "." + Helper
                    + "." + Audience + "." + remberclick50;
                txt.Write(str);
                txt.Close();
                pnlSave.Visible = false;
                this.Close();
                RenewAll();
                var wd = new LoadGame();
                wd.Show();
            }
        }

        private void btnHighScore_Click(object sender, EventArgs e)
        {
            if (txtUserName.Text == "")
            {
                MessageBox.Show("Điền đầy đủ thông tin");
            }
            else
            {
                TextWriter txt = new StreamWriter(@"E:\highscore.txt");
                String str = txtUserName.Text + "." + lblHighScore.Text + "\r\n";
                txt.Write(str);
                txt.Close();
                pnlSave.Visible = false;
                this.Close();
                RenewAll();
                var wd = new LoadGame();
                wd.Show();
            }
        }
    }
}
