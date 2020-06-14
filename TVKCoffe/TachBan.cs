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
    public partial class TachBan : Form
    {
        public TachBan()
        {
            InitializeComponent();
        }

        private void BtnChonBan_Click(object sender, EventArgs e)
        {
            ChonBan fm = new ChonBan();
            fm.ShowDialog(this);
        }
    }
}
