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
    public partial class ThuDichVu : Form
    {

        private static string[] ones = {
            "", "một", "hai", "ba", "bốn", "năm", "sáu", "bảy", "tám", "chín", "mười", "mười một", "mười hai", "mười ba", "mười bốn", "mười lăm", "mười sáu", "mười bảy", "mười tám", "mười chín"
        };

        private static string[] tens = {
            "", "", "hai mươi", "ba mươi", "bốn mươi", "năm mươi", "sáu mươi", "bảy mươi", "tám mươi", "chín mươi"
        };

        private static string[] groups = {
            "", "nghìn", "triệu", "tỷ"
        };
        public ThuDichVu()
        {
            InitializeComponent();
            formLoad();
        }
        private void formLoad()
        {
            MainMenu.SetupMainMenu(menu);
            MainFunc.basicFormLoad(this);
        }

        private void btnXem_click(object sender, EventArgs e)
        {
            this.Hide();
            XemThongBao x = new XemThongBao();
            x.Show();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnThem_click(object sender, EventArgs e)
        {
            int soLuong = 0;
            if (dp1.Checked)
            {
                soLuong = 1;
            }
            else if (dp2.Checked)
            {
                soLuong = 2;
            }
            else if (dp3.Checked)
            {
                soLuong = 3;
            }
            else if (dp4.Checked)
            {
                soLuong = 4;
            }
            else if (dp5.Checked)
            {
                soLuong = 5;
            }
            else
            {
                soLuong = 0;
            }
            int tongTien = soLuong * 200000;

            bool hk1 = false;
            bool hk2 = false;
            if (ct1.Checked) hk1 = true;
            if (ct2.Checked) hk2 = true;

            bool bhyt = false;
            bool bhxh = false;
            if (bh1.Checked) bhyt = true;
            if (bh2.Checked) bhxh = true;

            string nd = "Đồng phục học sinh " + soLuong + " bộ, dịch vụ cơm trưa:";
            if (hk1 == true)
            {
                nd += " kì 1";
                tongTien += 9000000;
            }

            if (hk2 == true)
            {
                if (hk1 == true) nd += " và ";
                nd += " kì 2";
                tongTien += 9000000;
            }

            if (hk1 == false && hk2 == false)
            {
                nd += "không có";
                tongTien += 0;
            }

            if (bhyt == true)
            {
                nd += ", bảo hiểm y tế";
                tongTien += 600000;
            }

            if (bhxh == true)
            {
                nd += ",bảo hiểm xã hội";
                tongTien += 150000;
            }

            nd += ".";
            string maHS = maHocSinh.Text;
            string idThu = DateTime.Now.ToString("ssmmddMM");
            if (!(string.IsNullOrEmpty(maHS)))
            {
                //try
                //{
                    Student s = SevicesDAO.Instance.loadStudent(maHS);
                    SevicesDAO.Instance.Services(idThu, maHS, "Dịch vụ",tongTien,soLuong,hk1,hk2,bhyt,bhxh);
                    MessageBox.Show("Thành công");
                //}
                //catch
                //{
                  //  MessageBox.Show("ID Không tồn tại");
                //}
            }
            else
            {
                MessageBox.Show("Dữ liệu đang trống");
            }
        }

        private void btnTruy_click(object sender, EventArgs e)
        {
            int soLuong = 0;
            if (dp1.Checked)
            {
                soLuong = 1;
            }
            else if (dp2.Checked)
            {
                soLuong = 2;
            }
            else if (dp3.Checked)
            {
                soLuong = 3;
            }
            else if (dp4.Checked)
            {
                soLuong = 4;
            }
            else if (dp5.Checked)
            {
                soLuong = 5;
            }
            else
            {
                soLuong = 0;
            }
            int tongTien = soLuong * 200000;

            bool hk1 = false;
            bool hk2 = false;
            if (ct1.Checked) hk1 = true;
            if (ct2.Checked) hk2 = true;

            bool bhyt = false;
            bool bhxh = false;
            if (bh1.Checked) bhyt = true;
            if (bh2.Checked) bhxh = true;

            string nd = "Đồng phục học sinh " + soLuong + " bộ, dịch vụ cơm trưa:";
            if (hk1 == true)
            {
                nd += " kì 1";
                tongTien += 9000000;
            }

            if (hk2 == true)
            {
                if (hk1 == true) nd += " và ";
                nd += " kì 2";
                tongTien += 9000000;
            }

            if (hk1 == false && hk2 == false)
            {
                nd += "không có";
                tongTien += 0;
            }

            if (bhyt == true)
            {
                nd += ", bảo hiểm y tế";
                tongTien += 600000;
            }

            if (bhxh == true)
            {
                nd += ",bảo hiểm xã hội";
                tongTien += 150000;
            }

            nd += ".";


            string idStudent = maHocSinh.Text;
            if (!(string.IsNullOrEmpty(idStudent)))
            {
                try
                {
                    Student s = SevicesDAO.Instance.loadStudent(idStudent);
                    hoTen.Text = s.NameStudent;
                    lopHoc.Text = s.Classes;
                    maHocSinh2.Text = s.IdStudent;
                    soTien.Text = tongTien.ToString();
                    bangChu.Text = ConvertToWords(tongTien);
                    lbBienLai.Text = "BIÊN LAI THU HỌC PHÍ DỊCH VỤ" + s.YearSchool;
                    noiDung.Text = nd;
                    DateTime date = DateTime.Now;
                    lbNgay.Text = "TP. Hồ Chí Minh, ngày " + date.Day + " tháng " + date.Month + " năm " + date.Year;
                }
                catch
                {
                    MessageBox.Show("ID Không tồn tại");
                }
            }
            else
            {
                MessageBox.Show("Không để trống dữ liệu");
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

        private static string ConvertToWords(long number)
        {
            if (number == 0)
                return "Không đồng";

            if (number < 0)
                return "Số âm không được hỗ trợ";

            StringBuilder words = new StringBuilder();

            int groupIndex = 0;
            while (number > 0)
            {
                int group = (int)(number % 1000);
                number /= 1000;

                if (group > 0)
                {
                    if (words.Length > 0)
                        words.Insert(0, ", ");

                    words.Insert(0, ConvertGroup(group) + " " + groups[groupIndex]);
                }

                groupIndex++;
            }

            words[0] = char.ToUpper(words[0]); // Chuyển chữ cái đầu tiên thành chữ in hoa
            words.Append(" đồng");

            return words.ToString().Trim();
        }

        private static string ConvertGroup(int group)
        {
            StringBuilder groupWords = new StringBuilder();

            int hundreds = group / 100;
            if (hundreds > 0)
            {
                groupWords.Append(ones[hundreds] + " trăm");
            }

            int tensAndOnes = group % 100;
            if (tensAndOnes > 0)
            {
                if (groupWords.Length > 0)
                    groupWords.Append(" ");

                if (tensAndOnes <= 19)
                {
                    groupWords.Append(ones[tensAndOnes]);
                }
                else
                {
                    int tensDigit = tensAndOnes / 10;
                    int onesDigit = tensAndOnes % 10;

                    groupWords.Append(tens[tensDigit]);
                    if (onesDigit > 0)
                    {
                        groupWords.Append(" " + ones[onesDigit]);
                    }
                }
            }

            return groupWords.ToString().Trim();
        }

        //kiểm tra dữ liệu nhập vào phải là số
        private static bool IsNumeric(string input)
        {
            foreach (char c in input)
            {
                if (!char.IsDigit(c))
                {
                    return false;
                }
            }
            return true;
        }
    }
}
