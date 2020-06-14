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
using TVKCoffe.Model;

namespace TVKCoffe
{
    public partial class Order_Huy : Form
    {
        private string code;
        public Order order;
        public Order_Huy(string code)
        {
            InitializeComponent();
            this.code = code;
            
        }
        private void BtnKhong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnCo_Click(object sender, EventArgs e)
        {

            if (OrderDAO.Instance.Delete(this.code))
            {
                if (BanDAO.Instance.SetTrangThai(0, this.code)){
                    order.backToBanHang();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Lỗi đặt trạng thái bàn");
                }
            }
            else
            {
                MessageBox.Show("Lỗi xóa Order");
            }
            
        }


    }
}
