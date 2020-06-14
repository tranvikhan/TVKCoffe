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
    public partial class KhuyenMai_Them : Form
    {
        private KhuyenMai_Vocher fmVC;
        private KhuyenMai_ChuongTrinh fmCT;
        public KhuyenMai_Them()
        {
            InitializeComponent();
            fmVC = new KhuyenMai_Vocher();
            fmCT = new KhuyenMai_ChuongTrinh();
            addFormtoPanel(fmVC);
            reset();            

        }

        private void reset()
        {
            TimeNgayBatDau.Value = DateTime.Today;
            TimeNgayKetThuc.Value = DateTime.Today.AddDays(30);
            SwitchTuXoa.Value = false;
            fmVC.reset();
            fmCT.reset();
            
        }

        private void addFormtoPanel(object formobj)
        {
            
            this.panelKhuyenMai.Controls.Clear();

            Form fh = formobj as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.panelKhuyenMai.Controls.Add(fh);
            this.panelKhuyenMai.Tag = fh;
            fh.Show();

        }
        private void SelectLoaiKM_onItemSelected(object sender, EventArgs e)
        {
            switch (SelectLoaiKM.selectedIndex)
            {
                case 0:addFormtoPanel(fmVC); break;
                case 1:addFormtoPanel(fmCT); break;
            }
        }
        private string getnewcodeKM(int i)
        {
            int maHT = KhuyenMaiDAO.Instance.getNewCode() + i;
            string phanSau = maHT.ToString();
            while (phanSau.Length < 4)
            {
                phanSau = "0" + phanSau;
            }
            return "KM" + phanSau;
        }
        private void BtnThemKM_Click(object sender, EventArgs e)
        {
            if(TimeNgayKetThuc.Value >= TimeNgayBatDau.Value && TimeNgayKetThuc.Value >= DateTime.Today && TimeNgayBatDau.Value>=DateTime.Today)
            {
                if (SelectLoaiKM.selectedIndex == 1)
                {
                    KhuyenMaiDTO km = new KhuyenMaiDTO();

                    km.MaKM = getnewcodeKM(0);
                    km.TenKM = fmCT.GetTenCT();
                    km.GiaTri = fmCT.getGiaTri();
                    km.LoaiKM = "Chương Trình";
                    km.MaApDung = getnewcodeKM(0);
                    km.BatDau = TimeNgayBatDau.Value;
                    km.KetThuc = TimeNgayKetThuc.Value;
                    km.TuXoa = SwitchTuXoa.Value;
                    km.TrangThai = (km.BatDau <= DateTime.Today && km.KetThuc >= DateTime.Today)?true:false;
                    if (KhuyenMaiDAO.Instance.Insert(km))
                    {
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Không thể thêm Chương Trình Khuyến Mãi");
                    }
                }

                if(SelectLoaiKM.selectedIndex == 0)
                {
                    int soluong;
                    try
                    {
                        soluong = Int32.Parse(fmVC.getSoLuong());
                    }
                    catch
                    {
                        soluong = 0;
                    }
                    try
                    {
                        for (int i = 0; i < soluong; i++)
                        {
                            KhuyenMaiDTO km = new KhuyenMaiDTO();
                            km.MaKM = getnewcodeKM(i);
                            km.TenKM = fmVC.getTenVoCher();
                            try
                            {
                                km.GiaTri = Decimal.Parse(fmVC.getGiaTri());
                            }
                            catch
                            {
                                km.GiaTri = 0;
                            }
                            
                            km.MaApDung = "VOCHER-" + km.MaKM;
                            km.LoaiKM = "Vocher";
                            km.BatDau = TimeNgayBatDau.Value;
                            km.KetThuc = TimeNgayKetThuc.Value;
                            km.TuXoa = SwitchTuXoa.Value;
                            km.TrangThai = (km.BatDau <= DateTime.Today && km.KetThuc >= DateTime.Today) ? true : false;
                            KhuyenMaiDAO.Instance.Insert(km);
                        }
                        this.Close();
                    }
                    catch
                    {
                        MessageBox.Show("Không thể thêm Vocher");
                    }
                    
                }
            }
            else
            {
                MessageBox.Show("Khuyến Mãi Không Hợp lệ");
            }
                
        }

        private void BtnLamLai_Click(object sender, EventArgs e)
        {
            reset();
        }
    }
}
