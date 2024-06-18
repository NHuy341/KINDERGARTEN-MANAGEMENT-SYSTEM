using QuanLyTruongMamNon.DAO;
using QuanLyTruongMamNon.DT;
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
    public partial class DoiMatKhau : Form
    {
        public DoiMatKhau()
        {
            InitializeComponent();
        }

        private void Xacnhan_click(object sender, EventArgs e)
        {
            string mkht = tbMatKhau.Text;
            string f1 = Mk1.Text;
            string f2 = Mk2.Text;
            Account sta = AccountDAO.Instance.loadStaff1();
            string id = sta.IdStaff;
            if (!(string.IsNullOrEmpty(mkht)) && !(string.IsNullOrEmpty(f1)) && !(string.IsNullOrEmpty(f2))
                && f1 == f2)
            {
                bool check = AccountDAO.Instance.ChangePass(id, mkht, f2);
                if (check)
                {
                    MessageBox.Show("Ok");
                }
                else
                {
                    MessageBox.Show("Kh ok");
                }
            }
            else
            {
                MessageBox.Show("Không để trống dữ liệu");
            }
        }
        private void btnThoat_click(object sender, EventArgs e)
        {
            this.Close();
            TrangChu d = new TrangChu();
            d.Show();
        }
    }
}
