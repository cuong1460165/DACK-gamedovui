using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAn_CNPM
{
    public partial class CustomListView : RichTextBox
    {
        public CustomListView()
        {
            InitializeComponent();
            this.SetStyle(ControlStyles.Opaque, true);
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer, false);
            this.SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            this.TextChanged += CustomListView_TextChanged;
            this.VScroll += CustomListView_TextChanged;
            this.HScroll += CustomListView_TextChanged;
        }
        protected override CreateParams CreateParams
        {
            get
            {
                //This makes the control's background transparent
                CreateParams CP = base.CreateParams;
                CP.ExStyle |= 0x20;
                return CP;
            }
        }

        private void CustomListView_TextChanged(object sender, EventArgs e)
        {
            this.ForceRefresh();
        }
        public void ForceRefresh()
        {
            this.UpdateStyles();
        }
    }
}
