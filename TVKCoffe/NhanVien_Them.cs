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
    public partial class NhanVien_Them : Form
    {
        public NhanVien nv; 
        public NhanVien_Them()
        {
            InitializeComponent();
            ResetInput();
        }
        private void ResetInput() {
            PicAnhDaiDien.Image = global::TVKCoffe.Properties.Resources.plus_150px;
            TxtTenNV.Text = "";
            TxtTenDangNhap.Text = "";
            TxtMatKhau.Text = "";
            TxtEmail.Text = "";
            TxtSoDienThoai.Text = "";
            radioNam.Checked = true;
            SelectChucVu.selectedIndex = 0;
            TimeNgaySinh.Value = DateTime.Parse("1/1/2000");
        }
        private void taoma()
        {
            int maHT = NhanVienDAO.Instance.GetNewCode();
            string phanSau = maHT.ToString();
            while(phanSau.Length <4)
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
            TxtMaNV.Text = phanDau+phanSau;

        }
        private void NhanVien_Them_Load(object sender, EventArgs e)
        {
            taoma();
        }

        private void SelectChucVu_onItemSelected(object sender, EventArgs e)
        {
            taoma();
        }

        private void BtnUpload_Click(object sender, EventArgs e)
        {
            
            if(openFile.ShowDialog()== System.Windows.Forms.DialogResult.OK)
            {
                string URLavatar = openFile.FileName.ToString();
                PicAnhDaiDien.ImageLocation = URLavatar;
            }
        }

        private void BtnThemNhanVien_Click(object sender, EventArgs e)
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
                NhanVienDTO nhanvien = new NhanVienDTO();
                try
                {
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
                                        
                    if (NhanVienDAO.Instance.Insert(nhanvien))
                    {
                        nv.fillDataGridView();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Lỗi thêm nhân viên mới!");
                    }
                    
                }catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                
                
            }
            
        }

        private void bunifuCheckbox1_OnChange(object sender, EventArgs e)
        {
            if (bunifuCheckbox1.Checked) TxtMatKhau.isPassword = false;
            else TxtMatKhau.isPassword = true;
        }

        private void BtnLamLai_Click(object sender, EventArgs e)
        {
            ResetInput();
        }
    }
}
