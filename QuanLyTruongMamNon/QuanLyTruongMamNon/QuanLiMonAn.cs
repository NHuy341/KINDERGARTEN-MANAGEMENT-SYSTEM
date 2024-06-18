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
    public partial class QuanLiMonAn : Form
    {
        public QuanLiMonAn()
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
            btnThem.Click += BtnThem_Click;
            maMonAn.Text = "0000";
        }

        private void BtnThem_Click(object sender, EventArgs e)
        {
            maMonAn.Text = DateTime.Now.ToString("ssmm");
            if (!string.IsNullOrEmpty(maMonAn.Text) && !string.IsNullOrEmpty(tenMonAn.Text) && !string.IsNullOrEmpty(dinhDuong.Text))
            {
                //Them
                try
                {
                    MenuDAO.Instance.AddNewFood(maMonAn.Text, tenMonAn.Text, int.Parse(dinhDuong.Text));
                    duLieu.Rows.Insert(0, maMonAn.Text, tenMonAn.Text, dinhDuong.Text);
                    MessageBox.Show("Thành công");
                }
                catch 
                {
                    MessageBox.Show("ID tồn tại");
                }
            }
            else
            {
                MessageBox.Show("Không được để trống dữ liệu hoặc id chỉ có 4 số");
            }
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
            duLieu.Columns.Add("Item1", "Mã món ăn");
            duLieu.Columns.Add("Item2", "Tên món ănh");
            duLieu.Columns.Add("Item3", "Dinh dưỡng");


            DataGridViewButtonColumn btnColumn = new DataGridViewButtonColumn();
            btnColumn.Name = "Item4";
            btnColumn.HeaderText = "Chức năng";
            btnColumn.Text = "Xóa";
            btnColumn.UseColumnTextForButtonValue = true;
            duLieu.Columns.Add(btnColumn);
        }

        private void loadData()
        {
            duLieu.Rows.Clear();

            foreach (var i in MenuDAO.Instance.getAllFood())
            {
                // Tạo một hàng mới
                int rowIndex = duLieu.Rows.Add();

                // Gán giá trị cho từng ô trong hàng mới
                duLieu.Rows[rowIndex].Cells["Item1"].Value = i.IdFood;
                duLieu.Rows[rowIndex].Cells["Item2"].Value = i.NameFood;
                duLieu.Rows[rowIndex].Cells["Item3"].Value = i.Nutrition;
            }

            duLieu.CellContentClick += (sender, e) =>
            {
                if (e.ColumnIndex == duLieu.Columns["Item4"].Index && e.RowIndex >= 0)
                {
                    var id = duLieu.Rows[e.RowIndex].Cells["Item1"].Value.ToString();
                    btnDeltete_click(duLieu, id, e.RowIndex);
                }
            };
            duLieu.AllowUserToAddRows = false;
            duLieu.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }


        private static void btnDeltete_click(DataGridView duLieu, string idFood, int index)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa món ăn này", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                MenuDAO.Instance.DeleteFood(idFood);
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
