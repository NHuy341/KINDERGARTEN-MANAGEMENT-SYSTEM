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
    public partial class QuanLiThanhTich : Form
    {
        public QuanLiThanhTich()
        {
            InitializeComponent();
            formLoad();

            createCol();
            loadData();

            maHocSinh.Focus();
            btnThem.Click += BtnThem_Click;
        }

        private void btnXem_click(object sender, EventArgs e)
        {
            this.Hide();
            XemThongBao x = new XemThongBao();
            x.Show();
        }

        private void createCol()
        {
            duLieu.Columns.Clear();
            duLieu.Columns.Add("Item1", "Ngày");
            duLieu.Columns.Add("Item2", "Mã số học sinh");
            duLieu.Columns.Add("Item3", "Nội dung thành tích");


            DataGridViewButtonColumn btnColumn = new DataGridViewButtonColumn();
            btnColumn.Name = "Item4";
            btnColumn.HeaderText = "Chức năng";
            btnColumn.Text = "Xóa";
            btnColumn.UseColumnTextForButtonValue = true;
            duLieu.Columns.Add(btnColumn);
            duLieu.ReadOnly = true;
        }


        private void loadData()
        {
            duLieu.Rows.Clear();

            foreach (var i in SevicesDAO.Instance.getAllAchive())
            {
                // Tạo một hàng mới
                int rowIndex = duLieu.Rows.Add();

                // Gán giá trị cho từng ô trong hàng mới
                duLieu.Rows[rowIndex].Cells["Item1"].Value = i.DateAchieved.ToString("MM/dd/yyyy");
                duLieu.Rows[rowIndex].Cells["Item2"].Value = i.IdStudent;
                duLieu.Rows[rowIndex].Cells["Item3"].Value = i.Achievement;
            }

            duLieu.CellContentClick += (sender, e) =>
            {
                if (e.ColumnIndex == duLieu.Columns["Item4"].Index && e.RowIndex >= 0)
                {
                    DateTime date = DateTime.Parse(duLieu.Rows[e.RowIndex].Cells["Item1"].Value.ToString());
                    var id = duLieu.Rows[e.RowIndex].Cells["Item2"].Value.ToString();
                    var content = duLieu.Rows[e.RowIndex].Cells["Item3"].Value.ToString();
                    btnDeltete_click(duLieu, date, id, content, e.RowIndex);
                }
            };
            duLieu.AllowUserToAddRows = false;
            duLieu.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }


        private static void btnDeltete_click(DataGridView duLieu, DateTime date, string id, string content, int index)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa dữ liệu điểm danh này", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                //Code xóa ở đây
                StudentDAO.Instance.DeleteAchieve( id , date , content);
                //Truyền hết 3 cái vô nha tại ko có khóa chính
                MessageBox.Show("Xóa thành công");
                duLieu.Rows.RemoveAt(index);
            }
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

        private void BtnThem_Click(object sender, EventArgs e)
        {
            string maHS = maHocSinh.Text;
            string tt = thanhTich.Text;
            DateTime date = thoiGian.Value;

            if (!string.IsNullOrEmpty(thoiGian.Text) &&
                !string.IsNullOrEmpty(maHS) &&
                !string.IsNullOrEmpty(tt) &&
                (DateTime.Now).Subtract(date).Days >= 0)
            {
                //Code thêm ở đây
                bool check = false;
                foreach (var item in StudentDAO.Instance.getAllStudents())
                {
                    if (maHS == item.IdStudent)
                    {
                        check = true;
                        break;
                    }
                }
                if (check)
                {
                    bool check1 = StudentDAO.Instance.AddAchieve(maHS, date, tt);
                    if (check1)
                    {
                        duLieu.Rows.Insert(0, thoiGian.Value.ToString("MM/dd/yyyy"), maHocSinh.Text, thanhTich.Text);
                        maHocSinh.Clear();
                        maHocSinh.Focus();
                        MessageBox.Show("Thêm thành tích thành công");
                    }
                    else
                    {
                        MessageBox.Show("Thêm thất bại");
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
