using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnCNPM
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnbatDau_Click(object sender, EventArgs e)
        {
            Form3 window3 = new Form3();
            this.Hide();
            window3.Show();
        }

        

        private void lbcauHoi_Click(object sender, EventArgs e)
        {
            Hide();
            Form3 window3 = new Form3();
            window3.ShowDialog();
            window3 = null;
            Show();
        }
    }
}
