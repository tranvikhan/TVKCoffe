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
using TVKCoffe.Model;

namespace TVKCoffe
{
    public partial class NhanVien_Sua : Form
    {
        public NhanVien nv;
        private string MaNV;
        public NhanVien_Sua(string codeno)
        {
            this.MaNV = codeno;
            InitializeComponent();
            Loadnput();
        }
        private void Loadnput()
        {
            NhanVienDTO nhanvien = NhanVienDAO.Instance.GetNhanVien(this.MaNV);
            TxtMaNV.Text = nhanvien.MaNV;
            PicAnhDaiDien.Image = nhanvien.AnhDaiDien;
            if (nhanvien.GioiTinh =="Nam")
            {
                radioNam.Checked = true;
                radioNu.Checked = false;
            }
            else
            {
                radioNam.Checked = false;
                radioNu.Checked = true;
            }
            TxtTenNV.Text = nhanvien.TenNV;
            TxtTenDangNhap.Text = nhanvien.TenDangNhap;
            TxtMatKhau.Text = nhanvien.MatKhau;
            TxtEmail.Text = nhanvien.Email;
            TxtSoDienThoai.Text = nhanvien.SoDienThoai;
            switch (nhanvien.ChucVu)
            {
                case "Thu Ngân": SelectChucVu.selectedIndex = 0; break;
                case "Quản Lý": SelectChucVu.selectedIndex = 1; break;
                case "Admin": SelectChucVu.selectedIndex = 2; break;
            }
            
            TimeNgaySinh.Value = nhanvien.NgaySinh;

        }
        private void bunifuCheckbox1_OnChange(object sender, EventArgs e)
        {
            if (bunifuCheckbox1.Checked) TxtMatKhau.isPassword = false;
            else TxtMatKhau.isPassword = true;
        }

        private void BtnUpload_Click(object sender, EventArgs e)
        {
            if (openFile.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string URLavatar = openFile.FileName.ToString();
                PicAnhDaiDien.ImageLocation = URLavatar;
            }
        }

        private void BtnLamLai_Click(object sender, EventArgs e)
        {
            Loadnput();
        }

        private void BtnLuu_Click(object sender, EventArgs e)
        {
            bool kt = true;
            if (TxtTenNV.Text.Equals(""))
            {
                label1.ForeColor = Color.Red;
                kt = false;
            }
            else
            {
                label1.ForeColor = Color.Black;
            }
            if (TxtTenDangNhap.Text.Equals(""))
            {
                label7.ForeColor = Color.Red;
                kt = false;
            }
            else
            {
                label7.ForeColor = Color.Black;
            }
            if (TxtMatKhau.Text.Equals(""))
            {
                label8.ForeColor = Color.Red;
                kt = false;
            }
            else
            {
                label8.ForeColor = Color.Black;
            }
            if (kt)
            {
                try
                {
                    NhanVienDTO nhanvien = new NhanVienDTO();
                    nhanvien.MaNV = TxtMaNV.Text;
                    nhanvien.TenNV = TxtTenNV.Text;
                    nhanvien.TenDangNhap = TxtTenDangNhap.Text;
                    nhanvien.MatKhau = TxtMatKhau.Text;
                    nhanvien.NgaySinh = TimeNgaySinh.Value;
                    nhanvien.Email = TxtEmail.Text;
                    nhanvien.SoDienThoai = TxtSoDienThoai.Text;
                    nhanvien.ChucVu = SelectChucVu.selectedValue;
                    nhanvien.GioiTinh = (radioNam.Checked) ? "Nam" : "Nữ";
                    nhanvien.AnhDaiDien = PicAnhDaiDien.Image;

                    if (NhanVienDAO.Instance.Update(nhanvien,this.MaNV))
                    {
                        nv.fillDataGridView();
                        this.Close();
                    }
                    
                }
                catch (Exception)
                {
                    MessageBox.Show("Lỗi sửa Nhân Viên!");
                }
            }
        }

        private void SelectChucVu_onItemSelected(object sender, EventArgs e)
        {
            int maHT = Int32.Parse(MaNV.Substring(2));
            string phanSau = maHT.ToString();
            while (phanSau.Length < 4)
            {
                phanSau = "0" + phanSau;
            }
            string phanDau = "";
            switch (SelectChucVu.selectedIndex)
            {
                case 0: phanDau = "TN"; break;
                case 1: phanDau = "QL"; break;
                case 2: phanDau = "AD"; break;

            }
            TxtMaNV.Text = phanDau + phanSau;
        }
    }
}
