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
    public partial class XemThongBao : Form
    {
        public XemThongBao()
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
        }

        private void createCol()
        {
            //Chưa xem
            duLieu.Columns.Clear();
            duLieu.Columns.Add("Item1", "Ngay thông báo");
            duLieu.Columns.Add("Item2", "Mã thông báo");
            DataGridViewButtonColumn btnColumn1 = new DataGridViewButtonColumn();
            btnColumn1.Name = "Item3";
            btnColumn1.HeaderText = "Chức năng";
            btnColumn1.Text = "Hiển thị";
            btnColumn1.UseColumnTextForButtonValue = true;
            duLieu.Columns.Add(btnColumn1);



            //Đã xem
            daXem.Columns.Clear();
            daXem.Columns.Add("Item1", "Ngay thông báo");
            daXem.Columns.Add("Item2", "Mã thông báo");
            DataGridViewButtonColumn btnColumn2 = new DataGridViewButtonColumn();
            btnColumn2.Name = "Item3";
            btnColumn2.HeaderText = "Chức năng";
            btnColumn2.Text = "Hiển thị";
            btnColumn2.UseColumnTextForButtonValue = true;
            daXem.Columns.Add(btnColumn2);
        }

        private void loadData()
        {
            duLieu.Rows.Clear();

            //Code tải thông báo CHƯA xem ở đây
            foreach (var i in SevicesDAO.Instance.getAllNotiStaf(false))
            {
                int rowIndex = duLieu.Rows.Add();
                duLieu.Rows[rowIndex].Cells["Item2"].Value = i.IdNotication;
                foreach (var item in SevicesDAO.Instance.getAllNoti(i.IdNotication))
                {
                    duLieu.Rows[rowIndex].Cells["Item1"].Value = item.DateNoti;
                }
                
            }

            duLieu.CellContentClick += (sender, e) =>
            {
                if (e.ColumnIndex == duLieu.Columns["Item3"].Index && e.RowIndex >= 0)
                {
                    var id = duLieu.Rows[e.RowIndex].Cells["Item2"].Value.ToString();
                    var date = DateTime.Parse(duLieu.Rows[e.RowIndex].Cells["Item1"].Value.ToString());
                    btnHienThi_Click1(duLieu, id, date, e.RowIndex);
                }
            };
            duLieu.AllowUserToAddRows = false;



            //Code tải thông báo ĐÃ xem ở đây
            foreach (var i in SevicesDAO.Instance.getAllNotiStaf(true))
            {
                int rowIndex = daXem.Rows.Add();
                daXem.Rows[rowIndex].Cells["Item2"].Value = i.IdNotication;
                foreach (var item in SevicesDAO.Instance.getAllNoti(i.IdNotication))
                {
                    daXem.Rows[rowIndex].Cells["Item1"].Value = item.DateNoti;
                }

            }

            daXem.CellContentClick += (sender, e) =>
            {
                if (e.ColumnIndex == daXem.Columns["Item3"].Index && e.RowIndex >= 0)
                {
                    var id = daXem.Rows[e.RowIndex].Cells["Item2"].Value.ToString();
                    var date = DateTime.Parse(daXem.Rows[e.RowIndex].Cells["Item1"].Value.ToString());
                    btnHienThi_Click2(daXem, id, date, e.RowIndex);
                }
            };
            daXem.AllowUserToAddRows = false;
        }


        private void btnHienThi_Click1(object sender, string id, DateTime date, int index)
        {
            
            maThongBao.Text = id;
            thoiGian.Value = date;

            string[] info = findNoti(id);

            tieuDe.Text = info[0];
            noiDung.Text = info[1];

            Account sta = AccountDAO.Instance.loadStaff1();
            string idSta = sta.IdStaff;
            //Code chuyển thành đã xem ở đây
            SevicesDAO.Instance.ChangeSeen(id,idSta);

            daXem.Rows.Insert(0, date.ToString("MM/dd/yyyy"), id);
            duLieu.Rows.RemoveAt(index);
        }

        private void btnHienThi_Click2(object sender, string id, DateTime date, int index)
        {
            maThongBao.Text = id;
            thoiGian.Value = date;

            string[] info = findNoti(id);

            tieuDe.Text = info[0];
            noiDung.Text = info[1];
        }


        private string[] findNoti(string id)
        {
            string[] result = { "Tên thông báo", "Nội dung thông báo" };
            //Code load thông báo lên theo id ở đây
            foreach (var item in SevicesDAO.Instance.getAllNoti(id))
            {
                result[0] = item.Title;
                result[1] = item.Description;
            }
            //Hàm này trả về 2 biến
            return result;
        }
    }
}
