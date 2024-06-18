using QuanLyTruongMamNon.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyTruongMamNon
{
    public partial class DangNhap : Form
    {
        public DangNhap()
        {
            InitializeComponent();
        }

        private void btnThoat_click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát hay không?", "Thông báo", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK  )
            {
                Application.Exit();
            }
        }

        private void btnDangNhap_click(object sender, EventArgs e)
        {
            string username = txtTaiKhoan.Text;
            string password = txtMatKhau.Text;

            if (login(username,password) == true)
            {
                this.Hide();
                TrangChu t = new TrangChu();
                t.ShowDialog();
            }
            else
            {
                MessageBox.Show("Sai mật khẩu hoặc tài khoản");
            }

        }
        bool login(string username, string password)
        {
            return AccountDAO.Instance.Login(username, password);
        }

        private void btnQuenMatKhau_click(object sender, EventArgs e)
        {
            this.Hide();
            QuenMatKhau q = new QuenMatKhau();
            q.ShowDialog();
        }


    }
}
