using QuanLyTruongMamNon.DAO;
using QuanLyTruongMamNon.DT;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyTruongMamNon
{
    public partial class XemDanhSachLop : Form
    {
        CultureInfo culture = new CultureInfo("vi-vn");
        public XemDanhSachLop()
        {
            InitializeComponent();
            formLoad();
            LoadListClass();
        }
        private void formLoad()
        {
            MainMenu.SetupMainMenu(menu);
            MainFunc.basicFormLoad(this);
        }

        private void LoadListClass()
        {
            List<Classes> year = ClassesDAO.Instance.LoadListClasses();
            var distinctYears = year.GroupBy(x => x.ClassName).Select(g => g.First()).ToList();
            noiSinh.DataSource = distinctYears;
            noiSinh.DisplayMember = "ClassName";
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

        private void btnXem_click(object sender, EventArgs e)
        {
            this.Hide();
            XemThongBao x = new XemThongBao();
            x.Show();
        }

        private void loadStudent(object sender, EventArgs e)
        {
            string className = noiSinh.Text.ToString(culture);
            duLieu.Rows.Clear();
            duLieu.Columns.Clear();
            duLieu.Columns.Add("Item1", "IDStudents");
            duLieu.Columns.Add("Item2", "Tên học sinh");
            duLieu.Columns.Add("Item3", "Giới tính");
            duLieu.Columns.Add("Item4", "Ngày sinh");
            duLieu.Columns.Add("Item5", "Năm học");
            duLieu.Columns.Add("Item6", "Lớp");
            foreach (var i in StudentDAO.Instance.LoadClassStudent(className))
            {
                string sex = (i.Gender) ? "Nam" : "Nữ";

                // Tạo một hàng mới
                int rowIndex = duLieu.Rows.Add();

                // Gán giá trị cho từng ô trong hàng mới
                duLieu.Rows[rowIndex].Cells["Item1"].Value = i.IdStudent;
                duLieu.Rows[rowIndex].Cells["Item2"].Value = i.NameStudent;
                duLieu.Rows[rowIndex].Cells["Item3"].Value = sex;
                duLieu.Rows[rowIndex].Cells["Item4"].Value = i.DateBirth.ToString("dd/MM/yyyy");
                duLieu.Rows[rowIndex].Cells["Item5"].Value = i.YearSchool;
                duLieu.Rows[rowIndex].Cells["Item6"].Value = i.Classes;
            }
        }
    }
}
