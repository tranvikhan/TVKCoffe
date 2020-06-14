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
    public partial class KhuyenMai_ChuongTrinh : Form
    {
        public KhuyenMai_ChuongTrinh()
        {
            InitializeComponent();
        }
        public void reset()
        {
            TxtTenCT.Text = "CHƯƠNG TRÌNH";
            TextGiaTri.Text = "100000";
        }
        public string GetTenCT()
        {
            return TxtTenCT.Text;
        }
        public decimal getGiaTri()
        {
            try
            {
                return Decimal.Parse( TextGiaTri.Text);
            }
            catch
            {
                return 0;
            }
        }
    }
}
