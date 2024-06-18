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
    public partial class ChiNganSach : Form
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

        public ChiNganSach()
        {
            InitializeComponent();
            formLoad();
        }
        private void formLoad()
        {
            MainMenu.SetupMainMenu(menu);
            MainFunc.basicFormLoad(this);
        }

        //Dang xuat
        private void btnDangXuat_click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn đăng xuất hay không?", "Thông báo", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
            {
                this.Close();
                DangNhap d = new DangNhap();
                d.Show();
            }
        }

        //Xem thông tin cá nhân
        private void btnNguoiDung_click(object sender, EventArgs e)
        {
            this.Hide();
            HoSoNHanVien hs = new HoSoNHanVien();
            hs.ShowDialog();

        }

        //Truy xuất
        private void btnTruyxuat_click(Object sender, EventArgs e)
        {
            if (!(string.IsNullOrEmpty(txtDiaChi.Text)) && !(string.IsNullOrEmpty(txtLydo.Text)) && !(string.IsNullOrEmpty(txtngNhan.Text)) && !(string.IsNullOrEmpty(txtSoTien.Text))
                && IsNumeric(txtSoTien.Text) == true)
            {
                hoTen.Text = txtngNhan.Text;
                diaChi.Text = txtDiaChi.Text;
                soTien.Text = txtSoTien.Text;
                long tienChi = long.Parse(txtSoTien.Text);
                bangChu.Text = ConvertToWords(tienChi);
                lyDo.Text = txtLydo.Text;
                DateTime date = DateTime.Now;
                lbNgay.Text = "TP. Hồ Chí Minh, ngày " + date.Day + " tháng " + date.Month + " năm " + date.Year;
            }
            else
            {
                MessageBox.Show("Dữ liệu đang trống hoặc số tiền nhập vào không chính xác");
            }
        }

        //Thêm dữ liệu Chi Ngân sách
        private void btnThem_click(Object sender, EventArgs e)
        {
            try
            {
                string idChi = DateTime.Now.ToString("ssmmddMM");
                string ngNhan = txtngNhan.Text;
                string diaChi = txtDiaChi.Text;
                string lyDo = txtLydo.Text;
                int amount = int.Parse(txtSoTien.Text);
                if (!(string.IsNullOrEmpty(txtDiaChi.Text)) && !(string.IsNullOrEmpty(txtLydo.Text)) && !(string.IsNullOrEmpty(txtngNhan.Text)) && !(string.IsNullOrEmpty(txtSoTien.Text))
                    && IsNumeric(txtSoTien.Text) == true)
                {
                    SevicesDAO.Instance.Expend(idChi, ngNhan, diaChi, lyDo, "Chi tiêu", amount);
                    MessageBox.Show("Thành công");
                }
                else
                {
                    MessageBox.Show("Dữ liệu đang trống hoặc số tiền nhập vào không chính xác");
                }
            }
            catch 
            {
                MessageBox.Show("Vui lòng đợi 5s rồi thử lại");
            }
        }

        //Đổi số thành chữ
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

        //Xem thông báo
        private void btnXem_click(object sender, EventArgs e)
        {
            this.Hide();
            XemThongBao x = new XemThongBao();
            x.Show();
        }
    }
}
