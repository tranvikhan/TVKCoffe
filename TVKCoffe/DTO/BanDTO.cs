using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TVKCoffe.DTO
{
    class BanDTO
    {
        private string maBan;
        private string tenBan;
        private int trangThai;
        //0:Trông 1: Đang order 2:Đã tạm tính 3:Đã thanh toán
        private KhuVucDTO khuVuc;
        public BanDTO() { }
        public BanDTO(DataRow row,KhuVucDTO kv)
        {
            this.maBan = (string)row["MaBan"];
            this.tenBan =(string)row["TenBan"];
            this.trangThai = (int)row["TrangThai"];
            this.khuVuc = kv;
        }
        public string MaBan { get => maBan; set => maBan = value; }
        public string TenBan { get => tenBan; set => tenBan = value; }
        public int TrangThai { get => trangThai; set => trangThai = value; }
        public KhuVucDTO KhuVuc { get => khuVuc; set => khuVuc = value; }
    }
}
