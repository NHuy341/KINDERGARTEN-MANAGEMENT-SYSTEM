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
    public partial class QuanLiNhanVien : Form
    {
        public QuanLiNhanVien()
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
            duLieu.Columns.Add("Item1", "IDStaffs");
            duLieu.Columns.Add("Item2", "Tên nhân viên");
            duLieu.Columns.Add("Item3", "Giới tính");
            duLieu.Columns.Add("Item4", "Ngày sinh");
            duLieu.Columns.Add("Item5", "Chức vụ");
            duLieu.Columns.Add("Item6", "Số điện thoại");


            DataGridViewButtonColumn btnColumn = new DataGridViewButtonColumn();
            btnColumn.Name = "Item7";
            btnColumn.HeaderText = "Xem chi tiết";
            btnColumn.Text = "Xem chi tiết";
            btnColumn.UseColumnTextForButtonValue = true;
            duLieu.Columns.Add(btnColumn);
            foreach (var i in AccountDAO.Instance.getAllStaffs())
            {
                string sex = (i.Gender) ? "Nam" : "Nữ";

                // Tạo một hàng mới
                int rowIndex = duLieu.Rows.Add();

                // Gán giá trị cho từng ô trong hàng mới
                duLieu.Rows[rowIndex].Cells["Item1"].Value = i.IdStaff;
                duLieu.Rows[rowIndex].Cells["Item2"].Value = i.NameStaff;
                duLieu.Rows[rowIndex].Cells["Item3"].Value = sex;
                duLieu.Rows[rowIndex].Cells["Item4"].Value = i.DateBirth.ToString("dd/MM/yyyy");
                duLieu.Rows[rowIndex].Cells["Item5"].Value = i.Roled;
                duLieu.Rows[rowIndex].Cells["Item6"].Value = i.Phone;
            }

            duLieu.CellContentClick += (sender, e) =>
            {
                if (e.ColumnIndex == duLieu.Columns["Item7"].Index && e.RowIndex >= 0)
                {
                    var id = duLieu.Rows[e.RowIndex].Cells["Item6"].Value.ToString();
                    btnView_click(this, id);
                }
            };
            duLieu.AllowUserToAddRows = false;
            duLieu.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        private static void btnView_click(Form curr, string id)
        {
            curr.Hide();
            HoSoNHanVien st = new HoSoNHanVien(id,null);
            st.Show();
        }

        private void btnXem_click(object sender, EventArgs e)
        {
            this.Hide();
            XemThongBao x = new XemThongBao();
            x.Show();
        }

        public static T GetCurrentInstance<T>(Form form) where T : Form
        {
            return form as T;
        }

        private void btnNguoiDung_click(object sender, EventArgs e)
        {
            this.Hide();
            HoSoNHanVien hs = new HoSoNHanVien(null);
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
            string idst = boxTimKiem.Text;
            duLieu.Rows.Clear();
            duLieu.Columns.Clear();
            duLieu.Columns.Add("Item1", "IDStaffs");
            duLieu.Columns.Add("Item2", "Tên nhân viên");
            duLieu.Columns.Add("Item3", "Giới tính");
            duLieu.Columns.Add("Item4", "Ngày sinh");
            duLieu.Columns.Add("Item5", "Chức vụ");
            duLieu.Columns.Add("Item6", "Số điện thoại");


            DataGridViewButtonColumn btnColumn = new DataGridViewButtonColumn();
            btnColumn.Name = "Item7";
            btnColumn.HeaderText = "Xem chi tiết";
            btnColumn.Text = "Xem chi tiết";
            btnColumn.UseColumnTextForButtonValue = true;
            duLieu.Columns.Add(btnColumn);
            foreach (var i in AccountDAO.Instance.getAllStaffs())
            {
                string sex = (i.Gender) ? "Nam" : "Nữ";

                if (i.IdStaff.ToLower().Contains(idst.ToLower()))
                {
                    // Tạo một hàng mới
                    int rowIndex = duLieu.Rows.Add();

                    // Gán giá trị cho từng ô trong hàng mới
                    duLieu.Rows[rowIndex].Cells["Item1"].Value = i.IdStaff;
                    duLieu.Rows[rowIndex].Cells["Item2"].Value = i.NameStaff;
                    duLieu.Rows[rowIndex].Cells["Item3"].Value = sex;
                    duLieu.Rows[rowIndex].Cells["Item4"].Value = i.DateBirth.ToString("dd/MM/yyyy");
                    duLieu.Rows[rowIndex].Cells["Item5"].Value = i.Roled;
                    duLieu.Rows[rowIndex].Cells["Item6"].Value = i.Phone;
                }
            }

            duLieu.CellContentClick += (btnsender, btne) =>
            {
                if (btne.ColumnIndex == duLieu.Columns["Item7"].Index && btne.RowIndex >= 0)
                {
                    var id = duLieu.Rows[btne.RowIndex].Cells["Item6"].Value.ToString();
                    btnView_click(this, id);
                }
            };
            duLieu.AllowUserToAddRows = false;
            duLieu.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
    }
}
