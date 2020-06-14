using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TVKCoffe.DAO;
using TVKCoffe.DTO;

namespace TVKCoffe
{

    public partial class ThanhToan : Form
    {
        public Order fmOrder;
        private OrderDTO od;
        private decimal tongtien=0;
        private decimal khachdua=0;
        private decimal tienthoi=0;
        public ThanhToan(string maOrder,decimal tongtien)
        {
            InitializeComponent();
            od = OrderDAO.Instance.GetOrderFromDB(maOrder);
            this.tongtien = tongtien;
            fillText();
        }

        private void fillText()
        {
            tienthoi = khachdua -tongtien;
            this.textTonhThanhToan.Text = tongtien.ToString("0.00").Replace(".00", String.Empty);
            this.textKhachDua.Text = khachdua.ToString("0.00").Replace(".00", String.Empty);
            this.textThoiLai.Text = tienthoi.ToString("0.00").Replace(".00", String.Empty);
        }

        private void BtnLamLai_Click(object sender, EventArgs e)
        {
            khachdua = 0;
            fillText();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            plus(500000);
        }

        private void plus(decimal tien)
        {
            khachdua = khachdua + tien;
            fillText();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            plus(200000);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            plus(100000);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            plus(50000);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            plus(20000);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            plus(10000);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            plus(5000);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            plus(2000);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            plus(1000);
        }

        private void BtnApDung_Click(object sender, EventArgs e)
        {
            if (tienthoi < 0)
            {
                MessageBox.Show("Khách chưa thanh toán đủ số tiền!");
            }
            else
            {
                BanDAO.Instance.SetTrangThai(3, od.Ban.MaBan);
                fmOrder.backToBanHang();
                this.Close();
            }
        }
    }
}
