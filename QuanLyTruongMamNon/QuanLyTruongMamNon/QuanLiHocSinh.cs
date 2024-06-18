using QuanLyTruongMamNon.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyTruongMamNon
{
    public partial class QuanLiHocSinh : Form
    {
        public QuanLiHocSinh()
        {
            InitializeComponent();
            formLoad();
        }
        private void formLoad()
        {
            MainMenu.SetupMainMenu(menu);
            MainFunc.basicFormLoad(this);

            duLieu.Rows.Clear();
            duLieu.Columns.Clear();
            duLieu.Columns.Add("Item1", "IDStudents");
            duLieu.Columns.Add("Item2", "Tên học sinh");
            duLieu.Columns.Add("Item3", "Giới tính");
            duLieu.Columns.Add("Item4", "Ngày sinh");
            duLieu.Columns.Add("Item5", "Năm học");
            duLieu.Columns.Add("Item6", "Lớp");


            DataGridViewButtonColumn btnColumn = new DataGridViewButtonColumn();
            btnColumn.Name = "Item7";
            btnColumn.HeaderText = "Xem chi tiết";
            btnColumn.Text = "Xem chi tiết";
            btnColumn.UseColumnTextForButtonValue = true;
            duLieu.Columns.Add(btnColumn);
            foreach (var i in StudentDAO.Instance.getAllStudents())
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

            duLieu.CellContentClick += (sender, e) =>
            {
                if (e.ColumnIndex == duLieu.Columns["Item7"].Index && e.RowIndex >= 0)
                {
                    var id = duLieu.Rows[e.RowIndex].Cells["Item1"].Value.ToString();
                    btnView_click(this,id);
                }
            };
            duLieu.AllowUserToAddRows = false;
            duLieu.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void btnXem_click(object sender, EventArgs e)
        {
            this.Hide();
            XemThongBao x = new XemThongBao();
            x.Show();
        }
        private static void btnView_click( Form curr ,string idStudent)
        {
            curr.Hide();
            HoSoHocSinh hs = new HoSoHocSinh(idStudent);
            hs.Show();
        }


        private void btnNguoiDung_click(object sender, EventArgs e)
        {
            this.Hide();
            HoSoNHanVien hs = new HoSoNHanVien();
            hs.ShowDialog();

        }

        private void btnThem_click(object sender, EventArgs e)
        {
            this.Hide();
            HoSoHocSinh hs = new HoSoHocSinh();
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

        private void btnTim_click(object sender, EventArgs e)
        {
            string idStud = boxTimKiem.Text;
            duLieu.Rows.Clear();
            duLieu.Columns.Clear();
            duLieu.Columns.Add("Item1", "IDStudents");
            duLieu.Columns.Add("Item2", "Tên học sinh");
            duLieu.Columns.Add("Item3", "Giới tính");
            duLieu.Columns.Add("Item4", "Ngày sinh");
            duLieu.Columns.Add("Item5", "Năm học");
            duLieu.Columns.Add("Item6", "Lớp");


            DataGridViewButtonColumn btnColumn = new DataGridViewButtonColumn();
            btnColumn.Name = "Item7";
            btnColumn.HeaderText = "Xem chi tiết";
            btnColumn.Text = "Xem chi tiết";
            btnColumn.UseColumnTextForButtonValue = true;
            duLieu.Columns.Add(btnColumn);
            foreach (var i in StudentDAO.Instance.getAllStudents())
            {
                string sex = (i.Gender) ? "Nam" : "Nữ";

                if (i.IdStudent.ToLower().Contains(idStud.ToLower()))
                {
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

            duLieu.CellContentClick += (btnsender, btne) =>
            {
                if (btne.ColumnIndex == duLieu.Columns["Item7"].Index && btne.RowIndex >= 0)
                {
                    var id = duLieu.Rows[btne.RowIndex].Cells["Item1"].Value.ToString();
                    btnView_click(this, id);
                }
            };
            duLieu.AllowUserToAddRows = false;
            duLieu.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void btnXemds_click(object sender, EventArgs e)
        {
            this.Hide();
            XemDanhSachLop x =new XemDanhSachLop();
            x.ShowDialog();
        }
    }
}
