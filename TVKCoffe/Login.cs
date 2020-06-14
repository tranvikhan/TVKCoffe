using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Drawing;
using System.Data.SqlClient;
using TVKCoffe.DatabaseConnection;
using System.Data.Common;
using TVKCoffe.Model;
using TVKCoffe.DAO;

namespace TVKCoffe
{
    public partial class Login : Form
    {
        public Home hm = null;
        public Login()
        {
            InitializeComponent();
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
        private void WdsClose_Click(object sender, System.EventArgs e)
        {
            if (hm != null) hm.Close();
            Application.Exit();
        }

        private void WdsMin_Click(object sender, System.EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Username_TextChanged(object sender, System.EventArgs e)
        {

        }

        private void LabelPassword_Click(object sender, System.EventArgs e)
        {

        }

        private void TitlePanel_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void Username_Click(object sender, System.EventArgs e)
        {
            labelUsername.ForeColor = Color.FromArgb(52, 152, 219);
            LabelPassword.ForeColor = Color.Black;
        }

        private void Password_Click(object sender, System.EventArgs e)
        {
            LabelPassword.ForeColor = Color.FromArgb(52, 152, 219);
            labelUsername.ForeColor = Color.Black;
        }

        private void btnShowPassword_OnChange(object sender, System.EventArgs e)
        {
            if (btnShowPassword.Checked == true)
            {
                Password.isPassword = false;
            }
            else
            {
                Password.isPassword = true;
            }
        }
        private void checkLogin()
        {
            if (hm != null) hm.Close();



            //string MaNV = ModelNhanVien.CheckLogin(Username.Text, Password.Text);
            string maNV = NhanVienDAO.Instance.Login(Username.Text, Password.Text);
            if (maNV != "")
            {
                Password.Text = "";
                Home home = new Home();
                home.NhanVienDangNhap = maNV;
                home.Show();
                home.lg = this;
                KhuyenMaiDAO.Instance.RefeshKM();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Đăng nhập thất bại!");
            }
        }
        
        private void BtnLogin_Click(object sender, System.EventArgs e)
        {
            bool kt = true;
            if (Username.Text.Equals(""))
            {
                labelUsername.ForeColor = Color.FromArgb(231, 76, 60);
                kt = false;
            }
            if (Password.Text.Equals(""))
            {
                LabelPassword.ForeColor = Color.FromArgb(231, 76, 60);
                kt = false;
            }
            if(kt) checkLogin();
            
                
        }

        private void Password_KeyDown(object sender, KeyEventArgs e)
        {
            LabelPassword.ForeColor = Color.FromArgb(52, 152, 219);
            if (e.KeyCode == Keys.Enter)
            {
                checkLogin();
            }
        }

        private void Username_KeyDown(object sender, KeyEventArgs e)
        {
            labelUsername.ForeColor = Color.FromArgb(52, 152, 219);
            if (e.KeyCode == Keys.Enter)
            {
                checkLogin();
            }
        }
    }
}
