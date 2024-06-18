using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZXing;
using System.IO;
using QuanLyTruongMamNon.DAO;
using QuanLyTruongMamNon.DT;

namespace QuanLyTruongMamNon
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new DangNhap());
        }
    }
    internal static class MainMenu
    {
        public static void SetupMainMenu(MenuStrip mainMenu)
        {
            mainMenu.Items.Clear();
            mainMenu.AutoSize = false;
            mainMenu.BackColor = System.Drawing.Color.SteelBlue;
            mainMenu.Dock = System.Windows.Forms.DockStyle.Left;
            mainMenu.ImageScalingSize = new System.Drawing.Size(40, 40);
            mainMenu.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            mainMenu.Font = new Font("Segoe UI", 16);
            mainMenu.Padding = new Padding(15, 0, 0, 0);


            CreateMenuItem(mainMenu, "mnuTC", "TRANG CHỦ", Properties.Resources.icon_TrangChu, typeof(QuanLyTruongMamNon.TrangChu).FullName);

            Account sta = AccountDAO.Instance.loadStaff1();
            string role = sta.IdStaff;
            if(role.Substring(0,2) == "GV")
            {
                CreateMenuItem(mainMenu, "mnuDD", "QUẢN LÍ ĐIỂM DANH", Properties.Resources.icon_DiemDanh, typeof(QuanLyTruongMamNon.QuanLiDiemDanh).FullName);
                CreateMenuItem(mainMenu, "mnuTT", "QUẢN LÍ THÀNH TÍCH", Properties.Resources.icon_ThanhTich, typeof(QuanLyTruongMamNon.QuanLiThanhTich).FullName);
            }
            else if (role.Substring(0, 2) == "GH")
            {
                CreateMenuItem(mainMenu, "mnuTB", "QUẢN LÍ THÔNG BÁO", Properties.Resources.icon_ThongBao, typeof(QuanLyTruongMamNon.QuanLiThongBao).FullName);
                CreateMenuItem(mainMenu, "mnuGV", "QUẢN LÍ GIÁO VỤ", Properties.Resources.icon_GiaoVu, typeof(QuanLyTruongMamNon.QuanLiGiaoVu).FullName);
            }
            else if (role.Substring(0, 2) == "KT")
            {
                CreateMenuItem(mainMenu, "mnuNS", "QUẢN LÍ NGÂN SÁCH", Properties.Resources.icon_NganSach, typeof(QuanLyTruongMamNon.QuanLiNganSach).FullName);
            }
            else if (role.Substring(0, 2) == "VP")
            {
                CreateMenuItem(mainMenu, "mnuNV", "QUẢN LÍ NHÂN VIÊN", Properties.Resources.icon_GiaoVien, typeof(QuanLyTruongMamNon.QuanLiNhanVien).FullName);
                CreateMenuItem(mainMenu, "mnuHS", "QUẢN LÍ HỌC SINH", Properties.Resources.icon_HocSinh, typeof(QuanLyTruongMamNon.QuanLiHocSinh).FullName);
            }
            else if (role.Substring(0, 2) == "DB")
            {
                CreateMenuItem(mainMenu, "mnuTD", "QUẢN LÍ THỰC ĐƠN", Properties.Resources.icon_ThucDon, typeof(QuanLyTruongMamNon.QuanLiThucDon).FullName);
                CreateMenuItem(mainMenu, "mnuMA", "QUẢN LÍ MÓN ĂN", Properties.Resources.icon_MonAn, typeof(QuanLyTruongMamNon.QuanLiMonAn).FullName);
            }
            //Khởi tạo các item
            else
            {
                CreateMenuItem(mainMenu, "mnuTB", "QUẢN LÍ THÔNG BÁO", Properties.Resources.icon_ThongBao, typeof(QuanLyTruongMamNon.QuanLiThongBao).FullName);
                CreateMenuItem(mainMenu, "mnuGV", "QUẢN LÍ GIÁO VỤ", Properties.Resources.icon_GiaoVu, typeof(QuanLyTruongMamNon.QuanLiGiaoVu).FullName);
                CreateMenuItem(mainMenu, "mnuNV", "QUẢN LÍ NHÂN VIÊN", Properties.Resources.icon_GiaoVien, typeof(QuanLyTruongMamNon.QuanLiNhanVien).FullName);
                CreateMenuItem(mainMenu, "mnuHS", "QUẢN LÍ HỌC SINH", Properties.Resources.icon_HocSinh, typeof(QuanLyTruongMamNon.QuanLiHocSinh).FullName);
                CreateMenuItem(mainMenu, "mnuNS", "QUẢN LÍ NGÂN SÁCH", Properties.Resources.icon_NganSach, typeof(QuanLyTruongMamNon.QuanLiNganSach).FullName);
                CreateMenuItem(mainMenu, "mnuDD", "QUẢN LÍ ĐIỂM DANH", Properties.Resources.icon_DiemDanh, typeof(QuanLyTruongMamNon.QuanLiDiemDanh).FullName);
                CreateMenuItem(mainMenu, "mnuTT", "QUẢN LÍ THÀNH TÍCH", Properties.Resources.icon_ThanhTich, typeof(QuanLyTruongMamNon.QuanLiThanhTich).FullName);
                CreateMenuItem(mainMenu, "mnuTD", "QUẢN LÍ THỰC ĐƠN", Properties.Resources.icon_ThucDon, typeof(QuanLyTruongMamNon.QuanLiThucDon).FullName);
                CreateMenuItem(mainMenu, "mnuMA", "QUẢN LÍ MÓN ĂN", Properties.Resources.icon_MonAn, typeof(QuanLyTruongMamNon.QuanLiMonAn).FullName);
            }
        }

        private static void CreateMenuItem(MenuStrip menuStrip, string name, string text, Image icon, string formPath)
        {
            //Thuộc tính cơ bản
            ToolStripMenuItem item = new ToolStripMenuItem();
            item.Name = name;
            item.Text = text;
            item.Size = new Size(300, 40);
            item.TextAlign = ContentAlignment.MiddleLeft;
            item.ImageAlign = ContentAlignment.MiddleLeft;
            item.Padding = new Padding(0, 10, 0, 10);

            //Định dạng ICON
            if (icon != null)
            {
                item.Image = icon;
                item.ImageScaling = ToolStripItemImageScaling.SizeToFit;
                item.TextImageRelation = TextImageRelation.ImageBeforeText;
            }

            if (!string.IsNullOrEmpty(formPath) && menuStrip.FindForm().GetType().FullName != formPath)
            {
                item.Click += (sender, e) =>
                {
                    Form currentForm = menuStrip.FindForm();
                    Form newForm = (Form)Activator.CreateInstance(Type.GetType(formPath));

                    // Đăng ký sự kiện Shown của form mới
                    newForm.Shown += (s, args) =>
                    {
                        // Sau khi form mới được hiển thị, ẩn form hiện tại
                        currentForm.Hide();

                        // Sau khi form mới đã đóng, giải phóng tài nguyên của form hiện tại
                        newForm.FormClosed += (s2, args2) => currentForm.Dispose();
                    };

                    // Hiển thị form mới
                    newForm.Show();
                };
            }

            menuStrip.Items.Add(item);
        }
    }


}
