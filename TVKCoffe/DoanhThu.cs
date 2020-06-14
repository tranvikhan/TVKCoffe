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
    public partial class DoanhThu : Form
    {
        public DoanhThu()
        {
            InitializeComponent();
        }

        private void BtnChuyenCheDo_Click(object sender, EventArgs e)
        {
            if (BieuDo.Visible)
            {
                BieuDo.Visible = false;
                BangSoLieu.Visible = true;
            }
            else
            {
                BieuDo.Visible = true;
                BangSoLieu.Visible =  false;
            }
        }
    }
}
