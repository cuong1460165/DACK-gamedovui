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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private async void btnStart_Click(object sender, EventArgs e)
        {
            String line;
            using (StreamReader sr = new StreamReader(@"E:\save.txt", Encoding.UTF8))
            {
                line = await sr.ReadToEndAsync();
            }
            if (line == "")
            {
                PlayGame window3 = new PlayGame();
                this.Hide();
                window3.Show();
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("Tiếp tục thì save bị xóa nha", "Thông Báo", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    TextWriter txt = new StreamWriter(@"E:\save.txt");
                    string str = null;
                    txt.Write(str);
                    txt.Close();
                    PlayGame window3 = new PlayGame();
                    this.Hide();
                    window3.Show();
                }
            }

        }

        private async void btnchoiTiep_Click(object sender, EventArgs e)
        {
            String line;
            using (StreamReader sr = new StreamReader(@"E:\save.txt", Encoding.UTF8))
            {
                line = await sr.ReadToEndAsync();
            }
            if (line == "")
            {
                MessageBox.Show("Vui lòng bắt đầu game mới khi chưa có save nha ");
            }
            else
            {
                User.label = 1;
                var wd = new PlayGame();
                this.Hide();
                wd.Show();
            }
        }
    }
}
