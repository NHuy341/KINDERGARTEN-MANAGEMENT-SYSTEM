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
    public partial class QuanLiGiaoVu : Form
    {
        public QuanLiGiaoVu()
        {
            InitializeComponent();
            formLoad();
        }
        private void formLoad()
        {
            MainMenu.SetupMainMenu(menu);
            MainFunc.basicFormLoad(this);

            List<Tuple<string, string, string, int>> listStu = new List<Tuple<string, string, string, int>>();
            foreach (var i in ClassesDAO.Instance.getAllClass())
            {
                listStu.Add(new Tuple<string, string, string, int >(i.YearSchool , i.ClassName , i.Teacher , i.WholeSale));
            }
            duLieu.DataSource = listStu;
            duLieu.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            duLieu.Columns["Item1"].HeaderText = "Năm học";
            duLieu.Columns["Item2"].HeaderText = "Lớp học ";
            duLieu.Columns["Item3"].HeaderText = "giáo viên phụ trách";
            duLieu.Columns["Item4"].HeaderText = "Số lượng";
        }

        private void btnXem_click(object sender, EventArgs e)
        {
            this.Hide();
            XemThongBao x = new XemThongBao();
            x.Show();
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
        private void btnNguoiDung_click(object sender, EventArgs e)
        {
            this.Hide();
            HoSoNHanVien hs = new HoSoNHanVien();
            hs.ShowDialog();

        }

        private void btnKhaiBao_click(object sender, EventArgs e)
        {
            string namHoc = namhocNM.Text;
            string soLuongHS = siSo.Text;
            if (!(string.IsNullOrEmpty(namHoc)) && !(string.IsNullOrEmpty(soLuongHS)))
            {
                int soLuong = int.Parse(soLuongHS);

                string[] years = namHoc.Split('-');
                int startYear = int.Parse(years[0]);
                int endYear = int.Parse(years[1]);

                if (soLuong % 30 == 0 && endYear - startYear == 1 && namHoc.Length == 9)
                {
                    int soLopHoc = (soLuong / 30);
                    soLop.Text = soLopHoc.ToString();
                    string teacher = "Unsigned";
                    for (int i = 1; i <= soLopHoc; i++)
                    {
                        string nameClass = "Mầm " + i;
                        ClassesDAO.Instance.NewSchoolYear(namHoc, nameClass, teacher, 0);
                    }
                    MessageBox.Show("Khai báo năm học thành công");
                }
                else
                {
                    MessageBox.Show("Dữ liệu nhập không hợp lệ. Vui lòng nhập lại!");
                }
            }
            else
            {
                MessageBox.Show("Không để trống dữ liệu ");
            }
        }

    }
}
