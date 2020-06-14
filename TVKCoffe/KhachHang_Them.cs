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
using TVKCoffe.DAO;
using TVKCoffe.DTO;

namespace TVKCoffe
{
    public partial class KhachHang_Them : Form
    {
        public KhachHang_Them()
        {
            InitializeComponent();
            fillInput();
        }

        private void fillInput()
        {
            int maHT = KhachHangDAO.Instance.getNewCode();
            string phanSau = maHT.ToString();
            while (phanSau.Length < 4)
            {
                phanSau = "0" + phanSau;
            }
            string newCode = "KH" + phanSau;
            TxtMaKH.Text = newCode;
            TxtTenKH.Text = "";
            TimeNgaySinh.Value = DateTime.Parse("1/1/2000");
            radioNam.Checked = true;
            TxtEmail.Text = "";
            TxtSoDienThoai.Text = "";
            TxtDiaChi.Text = "";
            TxtMaSoThue.Text = "";
            TxtThue.Text = "0";
            TxtChietKhau.Text = "0";


        }

        private void BtnLamLai_Click(object sender, EventArgs e)
        {
            fillInput();
        }

        private void BtnThemKH_Click(object sender, EventArgs e)
        {
            bool kt = true;
            if (TxtTenKH.Text.Equals(""))
            {
                kt = false;
                label1.ForeColor = Color.Red;
            }
            else
            {
                kt = true;
                label1.ForeColor = Color.Black;
            }
            if (kt)
            {
                KhachHangDTO kh = new KhachHangDTO();
                kh.MaKH = TxtMaKH.Text;
                kh.TenKH = TxtTenKH.Text;
                kh.NgaySinh = TimeNgaySinh.Value;
                kh.GioiTinh = (radioNam.Checked) ? "Nam" : "Nữ";
                kh.Email = TxtEmail.Text;
                kh.SoDienThoai = TxtSoDienThoai.Text;
                kh.DiaChi = TxtDiaChi.Text;
                kh.MaSoThue = TxtMaSoThue.Text;
                kh.Thue = Double.Parse(TxtThue.Text);
                kh.ChietKhau = Double.Parse(TxtChietKhau.Text);
                if (KhachHangDAO.Instance.Insert(kh))
                {
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Không thể thêm khách hàng mới");
                }
                
            }
        }
    }
}
