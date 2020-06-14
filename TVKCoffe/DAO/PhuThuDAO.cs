using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TVKCoffe.DAO
{
    class PhuThuDAO
    {
        private static PhuThuDAO instance;

        public static PhuThuDAO Instance
        {
            get
            {
                if (instance == null) instance = new PhuThuDAO();
                return instance;
            }
            private set => instance = value;
        }
    }
}
