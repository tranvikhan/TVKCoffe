using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TVKCoffe.DTO
{
    class ConvertDTO
    {
        private static ConvertDTO instance;

        public static ConvertDTO Instance { 
            get
            {
                if (instance == null) instance = new ConvertDTO();
                return instance;
            } 
            set => instance = value; 
        }
        private ConvertDTO() { }
        public Image ImageFromByte(byte [] img)
        {
            Image pic= null;
            try
            {
                if (img != null)
                {
                    MemoryStream ms = new MemoryStream(img);
                    pic = Image.FromStream(ms);
                }
            }catch(Exception)
            {
                pic = null;
            }
            
            return pic;
        }
        public byte[] ByteFromImage(Image imageIn)
        {
            using (var ms = new MemoryStream())
            {
                imageIn.Save(ms, imageIn.RawFormat);
                return ms.ToArray();
            }
        }

        public string CurrencyFromDecimal(decimal money)
        {
            string str = money.ToString();

            if (str.IndexOf('.') > 0) str = str.Substring(0, str.IndexOf('.'));
            string sub = str;
            int i = 0;
           
            while (sub.Length >3)
            {
                i++;
                str = str.Insert(str.Length - i * 3 - i + 1, ".");
                sub = sub.Substring(0,sub.Length-3);
               

            }
            return str + "đ";
        }
        public string SexFromLogic(Object o)
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
        public bool LogicFromSex(string sex)
        {
            return (sex == "Nam") ? true : false;
        }
        public string DateStringFromDay(DateTime day)
        {
            return day.ToString("dd/MM/yyyy");
        }
        public byte ByteFromSex(string sex)
        {
            return (sex == "Nam") ? (byte)1 :(byte)0;
        }
        public Color ColorFromString(string str)
        {
            while (str.IndexOf(' ') > 0) str = str.Replace(" ", "");
            int a = Int32.Parse(str.Substring(0, str.IndexOf(',')));
            str = str.Substring(str.IndexOf(',') + 1, str.Length - str.IndexOf(',') - 1);
            int b = Int32.Parse(str.Substring(0, str.IndexOf(',')));
            str = str.Substring(str.IndexOf(',') + 1, str.Length - str.IndexOf(',') - 1);
            int c = Int32.Parse(str);
            Color color = Color.FromArgb(a, b, c);
            return color;
        }
        public string StringFromColor(Color cl)
        {
            return cl.R.ToString() + "," + cl.G.ToString() + "," + cl.B.ToString();
        }
        public  Image CropToCircle(Image srcImage, Color backGround)
        {
            Image dstImage = new Bitmap(srcImage.Width, srcImage.Height, srcImage.PixelFormat);
            Graphics g = Graphics.FromImage(dstImage);
            using (Brush br = new SolidBrush(backGround))
            {
                g.FillRectangle(br, 0, 0, dstImage.Width, dstImage.Height);
            }
            float radius = 50;
            PointF center = new Point(60, 60);
            GraphicsPath path = new GraphicsPath();
            path.AddEllipse(0, 0, radius * 2, radius * 2);
            g.SetClip(path);
            g.SmoothingMode = SmoothingMode.AntiAlias;
            g.InterpolationMode = InterpolationMode.HighQualityBicubic;
            g.DrawImage(srcImage, 0, 0);

            return dstImage;
        }
        public Image ResizeImage(Image image, Size size, bool preserveAspectRatio = true)
        {
            int newWidth;
            int newHeight;
            if (preserveAspectRatio)
            {
                int originalWidth = image.Width;
                int originalHeight = image.Height;
                float percentWidth = (float)size.Width / (float)originalWidth;
                float percentHeight = (float)size.Height / (float)originalHeight;
                float percent = percentHeight < percentWidth ? percentHeight : percentWidth;
                newWidth = (int)(originalWidth * percent);
                newHeight = (int)(originalHeight * percent);
            }
            else
            {
                newWidth = size.Width;
                newHeight = size.Height;
            }
            Image newImage = new Bitmap(newWidth, newHeight);
            using (Graphics graphicsHandle = Graphics.FromImage(newImage))
            {
                graphicsHandle.InterpolationMode = InterpolationMode.HighQualityBicubic;
                graphicsHandle.DrawImage(image, 0, 0, newWidth, newHeight);
            }
            return newImage;
        }
        public string TrangThaiToString(int no)
        {
            string trangthai = "";
            switch (no)
            {
                case 0: trangthai = "Trống"; break;
                case 1: trangthai = "Đang Order"; break;
                case 2: trangthai = "Tạm tính"; break;
                case 3: trangthai = "Thanh toán"; break;
            }
            return trangthai;
        }

    }

}
