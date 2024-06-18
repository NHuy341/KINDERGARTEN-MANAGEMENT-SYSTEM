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
    public partial class QuanLiThongBao : Form
    {
        public QuanLiThongBao()
        {
            InitializeComponent();
            formLoad();
        }
        private void formLoad()
        {
            MainMenu.SetupMainMenu(menu);
            MainFunc.basicFormLoad(this);
        }
        private void btnNguoiDung_click(object sender, EventArgs e)
        {
            this.Hide();
            HoSoNHanVien hs = new HoSoNHanVien();
            hs.ShowDialog();

        }


        //Đăng xuất
        private void btnDangXuat_click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn đăng xuất hay không?", "Thông báo", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
            {
                this.Close();
                DangNhap d = new DangNhap();
                d.Show();
            }
        }


        //Thêm
        private void btnThem_click(object sender, EventArgs e)
        {
            thoiGian.Value = DateTime.Now;
            string idThongBao = thoiGian.Value.ToString("HHmmddMM");
            maThongBao.Text = idThongBao;
            string title = tieuDe.Text;
            string nd = noiDung.Text;
            if (!(string.IsNullOrEmpty(title)) && !(string.IsNullOrEmpty(nd)))
            {
                SevicesDAO.Instance.Notifications(idThongBao , thoiGian.Value , title, nd);
                MessageBox.Show("Thêm thành công");
            }
            else
            {
                MessageBox.Show("Không được để trống dữ liệu");
            }
        }


        //Xóa 
        private void btnXoa_click(object sender, EventArgs e)
        {
            string idThongBao = maThongBao .Text;
            if (!(string.IsNullOrEmpty(idThongBao)) && idThongBao.Trim() != "")
            {
                try
                {
                    SevicesDAO.Instance.DeleteNoti(idThongBao);
                    MessageBox.Show("Xóa dữ liệu thành công");
                }
                catch 
                {
                    MessageBox.Show("ID Không tồn tại");
                }
            }
            else
            {
                MessageBox.Show("Không được để trống dữ liệu");
            }
        }

        //Xem thông báo
        private void btnXem_click(object sender, EventArgs e)
        {
            this.Hide();
            XemThongBao x = new XemThongBao();
            x.Show();
        }
    }
}
