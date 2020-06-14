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
    public partial class DanhMuc : Form
    {
        private DataTable danhmuc;
        public DanhMuc()
        {
            InitializeComponent();
            danhmuc = new DataTable();
            danhmuc.Columns.Add("stt", typeof(int));
            danhmuc.Columns.Add("madanhmuc", typeof(string));
            danhmuc.Columns.Add("tendanhmuc", typeof(string));
            danhmuc.Columns.Add("soluongmon", typeof(int));
            fillData();
        }

        public void fillData()
        {
            danhmuc.Rows.Clear();
            List<DanhMucDTO> list = DanhMucDAO.Instance.GetListDanhMuc();
            int stt = 0;
            foreach(DanhMucDTO dm in list)
            {
                stt++;
                int soluong = SanPhamDAO.Instance.GetCountFromDM(dm.MaDM);
                danhmuc.Rows.Add(new object[] {stt,dm.MaDM,dm.TenDM,soluong});
            }
            BangDanhMuc.DataSource = danhmuc;
        }

        private void addFormtoPanel(object formobj)
        {
            if (this.Tag != null)
            {
                Form tmp = this.Tag as Form;
                tmp.Close();
            }
            if (this.Controls.Count > 0)
                this.Controls.Clear();
            Form od = formobj as Form;
            AddOwnedForm(od);
            od.FormBorderStyle = FormBorderStyle.None;
            od.TopLevel = false;
            od.Dock = DockStyle.Fill;
            this.Controls.Add(od);
            this.Tag = od;
            od.BringToFront();
            od.Show();
        }

        private void BtnTroVe_Click(object sender, EventArgs e)
        {
            addFormtoPanel(new ThucDon());
        }

        private void BtnThemDanhMuc_Click(object sender, EventArgs e)
        {
            DanhMuc_Them fm = new DanhMuc_Them();
            fm.danhmuc = this;
            fm.ShowDialog();
        }

        private void BtnTimKiem_OnTextChange(object sender, EventArgs e)
        {
            string filterField = "tendanhmuc";
            danhmuc.DefaultView.RowFilter = string.Format("[{0}] LIKE '%{1}%' OR [{2}] LIKE '%{1}%'", filterField, BtnTimKiem.text, "madanhmuc");
        }

        private void BtnXoaDanhMuc_Click(object sender, EventArgs e)
        {
            if ((int)(BangDanhMuc.CurrentRow.Cells[3].Value) > 0)
            {
                MessageBox.Show("Tồn Tại Sản Phẩm, Không thể xóa danh mục này");
            }
            else
            {
                Xoa fm = new Xoa("Danh Mục: " + BangDanhMuc.CurrentRow.Cells[2].Value.ToString(), "DANHMUC", BangDanhMuc.CurrentRow.Cells[1].Value.ToString());
                fm.danhmuc = this;
                fm.ShowDialog(this);
            }
            
        }

        private void BtnSuaDanhMuc_Click(object sender, EventArgs e)
        {
            DanhMuc_Sua fm = new DanhMuc_Sua(BangDanhMuc.CurrentRow.Cells[1].Value.ToString());
            fm.danhmuc = this;
            fm.ShowDialog(this);
        }
    }
}
