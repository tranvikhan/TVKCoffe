using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TVKCoffe
{
    public partial class GopBan : Form
    {
        public GopBan()
        {
            InitializeComponent();
        }

        private void BtnGopBan_Click(object sender, EventArgs e)
        {

        }

        private void BtnAddBan_Click(object sender, EventArgs e)
        {
            ChonBan fm = new ChonBan();
            fm.ShowDialog(this);
        }
    }
}
