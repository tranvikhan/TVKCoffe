using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TVKCoffe.DTO
{
    class KhuVucDTO
    {
        private string maKV;
        private string tenKV;
        public KhuVucDTO() { }
        public KhuVucDTO(DataRow row)
        {
            this.MaKV = (string)row["MaKV"];
            this.TenKV = (string)row["TenKV"];
        }

        public string MaKV { get => maKV; set => maKV = value; }
        public string TenKV { get => tenKV; set => tenKV = value; }
    }
}
