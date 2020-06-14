using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TVKCoffe.DTO
{
    class DanhMucDTO
    {
        private string maDM;
        private string tenDM;
        public DanhMucDTO(DataRow row)
        {
            this.maDM = (string)row["MaDM"];
            this.tenDM = (string)row["TenDM"];
        }
        public DanhMucDTO() { }
        public string MaDM { get => maDM; set => maDM = value; }
        public string TenDM { get => tenDM; set => tenDM = value; }
    }
}
