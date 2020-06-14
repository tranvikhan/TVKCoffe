using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TVKCoffe.Model
{
    class ModelConvert
    {
        public static string ConvertMoney(decimal money)
        {

            string str = money.ToString();
            
            if(str.IndexOf('.')>0) str = str.Substring(0, str.IndexOf('.'));
            long num = long.Parse(str);
            int i = 0;
            if (num > 0)
            {
                while (num % 1000 == 0)
                {
                    i++;
                    str = str.Insert(str.Length - i * 3 - i + 1, ".");
                    num = num / 1000;
                }
            }
            return str + "đ";
        }
        public static Image ByteToImage(byte[] img)
        {
            Image anh;
            if (img == null)
            {
                anh = null;

            }
            else
            {
                try
                {
                    MemoryStream ms = new MemoryStream(img);
                    anh = Image.FromStream(ms);
                }
                catch (Exception)
                {
                    anh = null;
                }

            }
            return anh;
        }
        public static string GioiTinh(Object o)
        {
            string gtinh;
            if (Object.Equals(o, true))
            {
                gtinh = "Nam";
            }
            else
            {
                gtinh = "Nữ";
            }
            return gtinh;
        }
    }
}
