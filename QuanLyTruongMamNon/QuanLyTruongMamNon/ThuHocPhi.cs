using QuanLyTruongMamNon.DAO;
using QuanLyTruongMamNon.DT;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Drawing.Printing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;
using System.Globalization;

namespace QuanLyTruongMamNon
{
    public partial class ThuHocPhi : Form
    {
        public ThuHocPhi()
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
        
        //Truy
        private void btnTruy_click (object sender, EventArgs e)
        {
            string idStudent = maHocSinh.Text;
            if (!(string.IsNullOrEmpty(idStudent)))
            {
                try
                {
                    Student s = SevicesDAO.Instance.loadStudent(idStudent);
                    lbTen.Text = s.NameStudent;
                    lopHoc.Text = s.Classes;
                    maHocSinh2.Text = s.IdStudent;
                    soTien.Text = "2.000.000 đồng";
                    bangChu.Text = "2 triệu đồng";
                    noiDung.Text = "Học phí năm học " + s.YearSchool;
                    lbBienLai.Text = "BIÊN LAI THU HỌC PHÍ NĂM HỌC " + s.YearSchool;
                    DateTime date = DateTime.Now;
                    lbNgay.Text = "TP. Hồ Chí Minh, ngày " + date.Day + " tháng " + date.Month + " năm " + date.Year;
                }
                catch 
                {
                    MessageBox.Show("ID Không tồn tại");
                }
            }
            else
            {
                MessageBox.Show("Không để trống dữ liệu");
            }
        }

        //Thêm
        private void btnThem_click(object sender, EventArgs e)
        {
            string maHS = maHocSinh.Text;
            string idThu = DateTime.Now.ToString("ssmmddMM");
            if (!(string.IsNullOrEmpty(maHS)))
            {
                try
                {
                    Student s = SevicesDAO.Instance.loadStudent(maHS);
                    SevicesDAO.Instance.Fee(idThu, maHS, true, "Thu", 2000000);
                    MessageBox.Show("Thành công");
                    Print();
                }
                catch
                {
                    MessageBox.Show("ID Không tồn tại");
                }
            }
            else
            {
                MessageBox.Show("Dữ liệu đang trống");
            }

        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(bitmap, 58, 70);
            bitmap.Dispose();
        }

        Bitmap bitmap;
        private void Print()
        {
            Graphics graphics = this.CreateGraphics();
            bitmap = new Bitmap(944, 835, graphics);
            Graphics _graphics = Graphics.FromImage(bitmap);
            _graphics.CopyFromScreen(this.Location.X + 115, this.Location.Y + 28, 0, 0, new Size(944, 835));
            bitmap.Save(Application.StartupPath + @"\Bill.Png", ImageFormat.Png);
            bitmap = new Bitmap(Application.StartupPath + @"\Bill.Png");
            if (printDialog2.ShowDialog() == DialogResult.OK)
                printDocument2.Print();
        }
    }
}
