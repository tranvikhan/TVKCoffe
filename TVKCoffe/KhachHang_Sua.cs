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
    public partial class KhachHang_Sua : Form
    {
        private KhachHangDTO khachhang;
        public KhachHang_Sua(string maKH)
        {
            InitializeComponent();
            khachhang = KhachHangDAO.Instance.GetKhach(maKH);
            fillInput();
        }

        private void fillInput()
        {
            TxtMaKH.Text = khachhang.MaKH;
            TxtTenKH.Text = khachhang.TenKH;
            TimeNgaySinh.Value = khachhang.NgaySinh;
            radioNam.Checked = ConvertDTO.Instance.LogicFromSex(khachhang.GioiTinh);
            radioNu.Checked = !radioNam.Checked;
            TxtEmail.Text = khachhang.Email;
            TxtSoDienThoai.Text = khachhang.SoDienThoai;
            TxtDiaChi.Text = khachhang.DiaChi;
            TxtMaSoThue.Text = khachhang.MaSoThue;
            TxtThue.Text = khachhang.Thue.ToString();
            TxtChietKhau.Text = khachhang.ChietKhau.ToString();
        }

        private void BtnLamLai_Click(object sender, EventArgs e)
        {
            fillInput();
        }

        private void BtnLuu_Click(object sender, EventArgs e)
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
                if (KhachHangDAO.Instance.Update(kh))
                {
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Không thể sửa khách hàng");
                }

            }
        }
    }
}
