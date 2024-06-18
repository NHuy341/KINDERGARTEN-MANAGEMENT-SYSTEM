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
    public partial class QuanLiThucDon : Form
    {
        public QuanLiThucDon()
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
            btnThem.Click += BtnThem_click;
            btnSua.Click += BtnSua_click;
            btnHuy.Click += BtnHuy_click;
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
            duLieu.Columns.Add("Item2", "Món ăn 1");
            duLieu.Columns.Add("Item3", "Món ăn 2");
            duLieu.Columns.Add("Item4", "Món ăn 3");
            duLieu.AllowUserToAddRows = false;
        }

        private void loadData()
        {
            duLieu.Rows.Clear();

            foreach (var i in StudentDAO.Instance.getAllStudents())
            {
                // Tạo một hàng mới
                int rowIndex = duLieu.Rows.Add();

                // Gán giá trị cho từng ô trong hàng mới
                duLieu.Rows[rowIndex].Cells["Item1"].Value = i.DateBirth.ToString("MM/dd/yyyy");
                duLieu.Rows[rowIndex].Cells["Item2"].Value = i.NameStudent;
                duLieu.Rows[rowIndex].Cells["Item3"].Value = i.NameStudent;
                duLieu.Rows[rowIndex].Cells["Item4"].Value = i.NameStudent;
                duLieu.CellMouseDoubleClick += DataGridView_CellMouseDoubleClick;
            }
        }

        private void BtnThem_click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(thoiGian.Text) &&
                !string.IsNullOrEmpty(comboBox1.Text) &&
                !string.IsNullOrEmpty(comboBox2.Text) &&
                !string.IsNullOrEmpty(comboBox3.Text))
            {
                //Code thêm ở đay nè
                duLieu.Rows.Insert(0, thoiGian.Value.ToString("dd/MM/yyyy"), comboBox1.Text, comboBox2.Text, comboBox3.Text);
            }
            else
            {
                MessageBox.Show("Không được để trống dữ liệu");
            }
        }

        private void BtnSua_click(object sender, EventArgs e)
        {
            if (thoiGian.Value < DateTime.Now)
            {
                //Code sửa nè
                if (duLieu.CurrentRow != null)
                {
                    int selectedRowIndex = duLieu.CurrentRow.Index;

                    if (selectedRowIndex >= 0 && selectedRowIndex < duLieu.Rows.Count)
                    {
                        DataGridViewRow selectedRow = duLieu.Rows[selectedRowIndex];

                        selectedRow.Cells["Item1"].Value = thoiGian.Value.ToString("dd/MM/yyyy");
                        selectedRow.Cells["Item2"].Value = comboBox1.Text;
                        selectedRow.Cells["Item3"].Value = comboBox2.Text;
                        selectedRow.Cells["Item4"].Value = comboBox3.Text;

                    }
                }
            }
            else
            {
                MessageBox.Show("Thời gian không thể sửa thực đơn");
            }
        }

        private void BtnHuy_click(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = -1;
            comboBox2.SelectedIndex = -1;
            comboBox3.SelectedIndex = -1;
        }

        private void DataGridView_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = duLieu.Rows[e.RowIndex];
                thoiGian.Value = DateTime.Parse(selectedRow.Cells["Item1"].Value.ToString());
                comboBox1.Text = selectedRow.Cells["Item2"].Value.ToString();
                comboBox2.Text = selectedRow.Cells["Item3"].Value.ToString();
                comboBox3.Text = selectedRow.Cells["Item4"].Value.ToString();
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
