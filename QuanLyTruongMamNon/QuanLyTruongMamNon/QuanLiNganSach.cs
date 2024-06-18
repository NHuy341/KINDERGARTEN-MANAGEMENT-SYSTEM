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
    public partial class QuanLiNganSach : Form
    {
        public QuanLiNganSach()
        {
            InitializeComponent();
            formLoad();
        }
        private void formLoad()
        {
            MainMenu.SetupMainMenu(menu);
            MainFunc.basicFormLoad(this);
        }

        private void btnXem_click(object sender, EventArgs e)
        {
            this.Hide();
            XemThongBao x = new XemThongBao();
            x.Show();
        }

        private void btnNguoiDung_click(object sender, EventArgs e)
        {
            this.Hide();
            HoSoNHanVien hs = new HoSoNHanVien();
            hs.ShowDialog();

        }
        private void btnDangXuat_click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn đăng xuất hay không?", "Thông báo", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
            {
                this.Close();
                DangNhap d = new DangNhap();
                d.Show();
            }
        }

        private void btnHocPhi_click(object sender, EventArgs e)
        {
            this.Hide();
            ThuHocPhi thp = new ThuHocPhi();
            thp.ShowDialog();
        }

        private void btnDichvu_click(object sender, EventArgs e)
        {
            this.Hide();
            ThuDichVu tdv = new ThuDichVu();
            tdv.ShowDialog();
        }

        private void btnChiPhi_click(Object sender, EventArgs e)
        {
            this.Hide();
            ChiNganSach chiNganSach = new ChiNganSach();
            chiNganSach.ShowDialog();
        }

        private void btnThongKe_click(object sender, EventArgs e)
        {
            this.Hide();
            ThongKeGiaoDich tk = new ThongKeGiaoDich();
            tk.ShowDialog();
        }
    }
}
