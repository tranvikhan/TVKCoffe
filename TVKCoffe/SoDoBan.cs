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
    public partial class SoDoBan : Form
    {
        private DataTable tableKV;
        private DataTable table;
        private DataTable tableall;
        public SoDoBan()
        {
            InitializeComponent();
            fillKhuVuc();
            fillBan();
        }

        private void fillBan()
        {
            List<BanDTO> list = BanDAO.Instance.GetListBan();
            tableall = new DataTable();
            tableall.Columns.Add("stt", typeof(int));
            tableall.Columns.Add("maban", typeof(string));
            tableall.Columns.Add("tenban", typeof(string));
            tableall.Columns.Add("khuvuc", typeof(string));
            tableall.Columns.Add("trangthai", typeof(string));

            BangBan.DataSource = tableall;
            int i = 0;
            foreach (BanDTO ban in list)
            {
                i++;

                tableall.Rows.Add(new object[] { i, ban.MaBan, ban.TenBan,ban.KhuVuc.TenKV,ConvertDTO.Instance.TrangThaiToString(ban.TrangThai)});
            }
            BangBan.DataSource = tableall;
        }
        private void fillBanKV(string maKV)
        {
            List<BanDTO> list = BanDAO.Instance.GetListBan(maKV);
            table = new DataTable();
            table.Columns.Add("stt", typeof(int));
            table.Columns.Add("maban", typeof(string));
            table.Columns.Add("tenban", typeof(string));
            table.Columns.Add("khuvuc", typeof(string));
            table.Columns.Add("trangthai", typeof(string));

            BangBan.DataSource = table;
            int i = 0;
            foreach (BanDTO ban in list)
            {
                i++;

                table.Rows.Add(new object[] { i, ban.MaBan, ban.TenBan, ban.KhuVuc.TenKV, ConvertDTO.Instance.TrangThaiToString(ban.TrangThai) });
            }
            BangBan.DataSource = table;
        }
        private void fillKhuVuc()
        {
            List<KhuVucDTO> list = KhuVucDAO.Instance.GetListKhuVuc();
            tableKV = new DataTable();
            tableKV.Columns.Add("stt", typeof(int));
            tableKV.Columns.Add("makhuvuc", typeof(string));
            tableKV.Columns.Add("tenkhuvuc", typeof(string));

            BangKhuVuc.DataSource = tableKV;
            int i = 0;
            foreach(KhuVucDTO kv in list)
            {
                i++;
                tableKV.Rows.Add(new object[] {i,kv.MaKV,kv.TenKV });
            }
            BangKhuVuc.DataSource = tableKV;
        }

       

        private void BangKhuVuc_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(BangKhuVuc.CurrentRow.Cells[1].Value.ToString());
            fillBanKV(BangKhuVuc.CurrentRow.Cells[1].Value.ToString());
        }

        private void BtnTimKiem_OnTextChange(object sender, EventArgs e)
        {
            BangBan.DataSource = tableall;
            string filterField = "tenban";
            tableall.DefaultView.RowFilter = string.Format("[{0}] LIKE '%{1}%' OR [{2}] LIKE '%{1}%'", filterField, BtnTimKiem.text, "maban");
        }

        private void BtnThemKhuVuc_Click(object sender, EventArgs e)
        {
            KhuVuc_Them fm = new KhuVuc_Them();
            fm.ShowDialog(this);
            fillKhuVuc();
           
        }

        private void BtnSuaKhuVuc_Click(object sender, EventArgs e)
        {
            KhuVuc_Sua fm = new KhuVuc_Sua(BangKhuVuc.CurrentRow.Cells[1].Value.ToString());
            fm.ShowDialog(this);
            fillKhuVuc();
        }

        private void BtnXoaKhuVuc_Click(object sender, EventArgs e)
        {
            if (BanDAO.Instance.CountBanFromKV(BangKhuVuc.CurrentRow.Cells[1].Value.ToString()) == 0)
            {
                Xoa fm = new Xoa("Khu Vực: "+BangKhuVuc.CurrentRow.Cells[2].Value.ToString(), "KHUVUC", BangKhuVuc.CurrentRow.Cells[1].Value.ToString());
                fm.ShowDialog(this);
                fillKhuVuc();
            }
            else
            {
                MessageBox.Show("Chưa thể xóa Khu Vực này");
            }
        }

        private void BtnThemBan_Click(object sender, EventArgs e)
        {
            Ban_Them fm = new Ban_Them(BangKhuVuc.CurrentRow.Cells[1].Value.ToString());
            fm.ShowDialog(this);
            fillBanKV(BangKhuVuc.CurrentRow.Cells[1].Value.ToString());
        }

        private void BtnSuaBan_Click(object sender, EventArgs e)
        {
            Ban_Sua fm = new Ban_Sua(BangBan.CurrentRow.Cells[1].Value.ToString());
            fm.ShowDialog(this);
            fillBan();
        }

        private void BtnXoaBan_Click(object sender, EventArgs e)
        {
            if (BangBan.CurrentRow.Cells[4].Value.ToString().Equals("Trống"))
            {
                Xoa fm = new Xoa("Bàn: " + BangBan.CurrentRow.Cells[2].Value.ToString(), "BAN", BangBan.CurrentRow.Cells[1].Value.ToString());
                fm.ShowDialog(this);
                fillBanKV(BangKhuVuc.CurrentRow.Cells[1].Value.ToString());
            }
            else
            {
                MessageBox.Show("Chưa thể xóa bàn này");
            }
        }
    }
}
