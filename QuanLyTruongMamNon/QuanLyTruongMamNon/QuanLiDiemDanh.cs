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
using static System.Net.Mime.MediaTypeNames;

namespace QuanLyTruongMamNon
{
    public partial class QuanLiDiemDanh : Form
    {
        public QuanLiDiemDanh()
        {
            InitializeComponent();
            formLoad();
        }
        private void formLoad()
        {
            MainMenu.SetupMainMenu(menu);
            MainFunc.basicFormLoad(this);
            createCol();
            loadData();

            maHocSinh.Focus();
            maHocSinh.KeyPress += maHocSinh_TextChanged;
            btnThem.Click += BtnThem_Click;
        }

        private void btnXem_click(object sender, EventArgs e)
        {
            this.Hide();
            XemThongBao x = new XemThongBao();
            x.Show();
        }


        private void maHocSinh_TextChanged(object sender, KeyPressEventArgs e)
        {
            // Kiểm tra nếu ký tự Enter được nhấn
            if (e.KeyChar == (char)Keys.Enter)
            {
                BtnThem_Click(sender, e);
            }
        }



        private void createCol()
        {
            duLieu.Columns.Clear();
            duLieu.Columns.Add("Item1", "Ngày");
            duLieu.Columns.Add("Item2", "Mã số học sinh");


            DataGridViewButtonColumn btnColumn = new DataGridViewButtonColumn();
            btnColumn.Name = "Item3";
            btnColumn.HeaderText = "Chức năng";
            btnColumn.Text = "Xóa";
            btnColumn.UseColumnTextForButtonValue = true;
            duLieu.Columns.Add(btnColumn);
            duLieu.ReadOnly = true;
        }

        private void BtnThem_Click(object sender, EventArgs e)
        {
            string msHS = maHocSinh.Text;
            DateTime dt = thoiGian.Value;
            if (!string.IsNullOrEmpty(thoiGian.Text) && !string.IsNullOrEmpty(msHS))
            {
                bool check = false;
                foreach (var item in StudentDAO.Instance.getAllStudents())
                {
                    if (msHS == item.IdStudent)
                    {
                        check = true;
                        break;
                    }
                }
                //Code thêm ở đây 
                if (check) {
                    try
                    {
                        StudentDAO.Instance.AddNewExdend(maHocSinh.Text, dt);
                        duLieu.Rows.Insert(0, thoiGian.Value.ToString("MM/dd/yyyy"), maHocSinh.Text);
                        maHocSinh.Clear();
                        maHocSinh.Focus();
                    }
                    catch
                    {
                        MessageBox.Show("Dữ liệu đã tồn tại");
                    }
                }
                else
                {
                    MessageBox.Show("ID không hợp lệ");
                }

            }
            else
            {
                MessageBox.Show("Không được để trống dữ liệu");
            }
        }


        private void loadData()
        {
            duLieu.Rows.Clear();

            foreach (var i in SevicesDAO.Instance.getAllAttendance())
            {
                // Tạo một hàng mới
                int rowIndex = duLieu.Rows.Add();

                // Gán giá trị cho từng ô trong hàng mới
                duLieu.Rows[rowIndex].Cells["Item1"].Value = i.DateAttend.ToString("MM/dd/yyyy");
                duLieu.Rows[rowIndex].Cells["Item2"].Value = i.IdStudent;
            }

            duLieu.CellContentClick += (sender, e) =>
            {
                if (e.ColumnIndex == duLieu.Columns["Item3"].Index && e.RowIndex >= 0)
                {
                    var id = duLieu.Rows[e.RowIndex].Cells["Item2"].Value.ToString();
                    DateTime date = DateTime.Parse(duLieu.Rows[e.RowIndex].Cells["Item1"].Value.ToString());
                    btnDeltete_click(duLieu, date, id, e.RowIndex);
                }
            };
            duLieu.AllowUserToAddRows = false;
            duLieu.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private static void btnDeltete_click(DataGridView duLieu, DateTime date, string id, int index)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa dữ liệu điểm danh này", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                //Code xóa ở đây
                StudentDAO.Instance.DeleteExdend(id,date);
                MessageBox.Show("Xóa thành công");
                duLieu.Rows.RemoveAt(index);
            }
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
    }
}
