using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TVKCoffe.DTO
{
    class PhuThuDTO
    {
        private string loaiPhuThu;
        private decimal giaTri;
        public PhuThuDTO() { }
        public string LoaiPhuThu { get => loaiPhuThu; set => loaiPhuThu = value; }
        public decimal GiaTri { get => giaTri; set => giaTri = value; }
    }
}
