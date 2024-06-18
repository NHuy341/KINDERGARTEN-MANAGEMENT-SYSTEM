using QuanLyTruongMamNon.DAO;
using QuanLyTruongMamNon.DT;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyTruongMamNon
{
    public partial class HoSoNHanVien : Form
    {
        public HoSoNHanVien()
        {
            InitializeComponent();
            formLoad();
            loadPro();
        }

        private void btnXem_click(object sender, EventArgs e)
        {
            this.Hide();
            XemThongBao x = new XemThongBao();
            x.Show();
        }
        public HoSoNHanVien(string them)
        {
            InitializeComponent();
            formLoad();
            btnCapNhat.Enabled = false;
            btnChinhSua.Enabled = false;
            btnXoa.Enabled = false;
            enableInfor();
        }

        //Xem thông tin cá nhân
        private void btnNguoiDung_click(object sender, EventArgs e)
        {
            this.Hide();
            HoSoNHanVien hs = new HoSoNHanVien();
            hs.ShowDialog();

        }
        public HoSoNHanVien(string id ,string temp)
        {
            InitializeComponent();
            formLoad();
            loadPro1(id);
        }
        private void formLoad()
        {
            MainMenu.SetupMainMenu(menu);
            MainFunc.basicFormLoad(this);
        }

        //Hiển thị thông tin
        public void loadPro()
        {
            Account st = AccountDAO.Instance.loadStaff1();
            txtHoTen.Text = st.NameStaff;
            txtEmail.Text = st.Email;
            txtGioiTinh.Text = st.Gender ? "Nam" : "Nữ";
            txtMaNhanVien.Text = st.IdStaff;
            txtngaySinh.Value = st.DateBirth;
            txtquocTich.Text = st.Nationality;
            txtdanToc.Text = st.Nation;
            txtngayCap.Value = st.LicenseDate;
            txtsoDienThoai.Text = st.Phone;
            txtCCCD.Text = st.IdCityzen;
            txtnoiCap.Text = st.LicensePlace;
            txtCOHN.Text = st.AddressCur;
            txtCOHN_C1.Text = st.ProvinceCur;
            txtCOHN_2.Text = st.DistrictCur;
            txtCOHN_3.Text = st.CommuneCur;
            txtDCTT.Text = st.AddressRes;
            txtDCTT_C1.Text = st.ProvinceRes;
            txtDCTT_C2.Text = st.DistrictRes;
            txtDCTT_C3.Text = st.CommuneRes;
            txtChucVu.Text = st.Roled;
            txttrangThai.Text = st.Actived.ToString();
            txtnoiSinh.Text = st.PlaceBirth;

        }

        public void loadPro1(string id)
        {
            Account st = AccountDAO.Instance.loadStaff(id);
            txtHoTen.Text = st.NameStaff;
            txtEmail.Text = st.Email;
            txtGioiTinh.Text = st.Gender ? "Nam" : "Nữ";
            txtMaNhanVien.Text = st.IdStaff;
            txtngaySinh.Value = st.DateBirth;
            txtquocTich.Text = st.Nationality;
            txtdanToc.Text = st.Nation;
            txtngayCap.Value = st.LicenseDate;
            txtsoDienThoai.Text = st.Phone;
            txtCCCD.Text = st.IdCityzen;
            txtnoiCap.Text = st.LicensePlace;
            txtCOHN.Text = st.AddressCur;
            txtCOHN_C1.Text = st.ProvinceCur;
            txtCOHN_2.Text = st.DistrictCur;
            txtCOHN_3.Text = st.CommuneCur;
            txtDCTT.Text = st.AddressRes;
            txtDCTT_C1.Text = st.ProvinceRes;
            txtDCTT_C2.Text = st.DistrictRes;
            txtDCTT_C3.Text = st.CommuneRes;
            txtChucVu.Text = st.Roled;
            txttrangThai.Text = st.Actived.ToString();
            txtnoiSinh.Text = st.PlaceBirth;

        }

        //Tạo id tự động
        private string GenerateStaffID(string role, int count)
        {
            string prefix = "";
            switch (role)
            {
                case "Giáo viên":
                    prefix = "GV";
                    break;
                case "Kế toán":
                    prefix = "KT";
                    break;
                // Thêm các vai trò khác nếu cần
                case "Ban Giám Hiệu":
                    prefix = "GH";
                    break;
                case "Quản Bếp":
                    prefix = "QB";
                    break;
                case "Văn  Phòng":
                    prefix = "VP";
                    break;
                default:
                    prefix = "NV";
                    break;
            }
            string idStaff = prefix + count.ToString("D6"); // D6 để thêm các số 0 vào trước số

            return idStaff;
        }

        private void LoadIDStaff(object sender, EventArgs e)
        {
            string role = txtChucVu.Text;
            int count = AccountDAO.Instance.GetStaffCountByRole(role) + 1;
            txtMaNhanVien.Text = GenerateStaffID(role, count);

        }

        //Thêm nhân viên
        private void btnThemMoi_Click(object sender, EventArgs e)
        {
            string idStaff = txtMaNhanVien.Text;
            string nameStaff = txtHoTen.Text;
            bool gender = (txtGioiTinh.Text == "Nam") ? true : false;
            DateTime dateBirth = txtngaySinh.Value;
            string placeBirth = txtnoiSinh.Text;
            string nation = txtdanToc.Text;
            string nationality = txtquocTich.Text;
            string idCityzen = txtCCCD.Text;
            DateTime licenseDate = txtngayCap.Value;
            string licensePlace = txtnoiCap.Text;
            string address_cur = txtCOHN.Text;
            string province_cur = txtCOHN_C1.Text;
            string district_cur = txtCOHN_2.Text;
            string commune_cur = txtCOHN_3.Text;
            string address_res = txtDCTT.Text;
            string province_res = txtDCTT_C1.Text;
            string district_res = txtDCTT_C2.Text;
            string commune_res = txtDCTT_C3.Text;
            string roled = txtChucVu.Text;
            bool actived = (txttrangThai.Text == "True") ? true : false;
            string phone = txtsoDienThoai.Text;
            string email = txtEmail.Text;

            if (!(string.IsNullOrEmpty(idStaff)) && !(string.IsNullOrEmpty(nameStaff)) && !(string.IsNullOrEmpty(placeBirth)) && !(string.IsNullOrEmpty(nation)) && 
                !(string.IsNullOrEmpty(nationality)) && !(string.IsNullOrEmpty(idCityzen)) && !(string.IsNullOrEmpty(licensePlace)) && !(string.IsNullOrEmpty(address_cur)) &&
                !(string.IsNullOrEmpty(province_cur)) && !(string.IsNullOrEmpty(district_cur)) && !(string.IsNullOrEmpty(commune_cur)) && !(string.IsNullOrEmpty(address_res)) &&
                !(string.IsNullOrEmpty(province_res)) && !(string.IsNullOrEmpty(district_res)) && !(string.IsNullOrEmpty(commune_res)) && !(string.IsNullOrEmpty(roled)) &&
                !(string.IsNullOrEmpty(phone)) && !(string.IsNullOrEmpty(email)) && (DateTime.Now).Subtract(dateBirth).Days > 7300 && (DateTime.Now).Subtract(licenseDate).Days > 0 && !(string.IsNullOrEmpty(gender.ToString())) 
                && idCityzen.Length == 12 && phone.Length == 10 && phone.Substring(0, 1) == "0" && IsValidEmail(email) == true && IsNumeric(phone) && IsNumeric(idCityzen))
            {

                try
                {
                    if (AccountDAO.Instance.AddNewStaff(idStaff, nameStaff, gender, dateBirth, placeBirth, nation, nationality, idCityzen, licenseDate, licensePlace, address_cur, province_cur, district_cur, commune_cur, address_res, province_res, district_res, commune_res, roled, actived, phone, email))
                    {
                        MessageBox.Show("Thêm thành công");
                    }
                    else
                    {
                        MessageBox.Show("Thêm thất bại");
                    }
                }
                catch
                {
                    MessageBox.Show("Mã nhân viên đã tồn tại ");
                }
            }
            else
            {
                MessageBox.Show("Không được để trống dữ liệu");
                return;
            }
        }


        //Chỉnh sửa danh sách nhân viên 
        private void btnChinhSua_Click(object sender, EventArgs e)
        {
            enableInfor();
        }


        //Cập nhật danh sách nhân viên
        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            string idStaff = txtMaNhanVien.Text;
            string nameStaff = txtHoTen.Text;
            bool gender = (txtGioiTinh.Text == "Nam") ? true : false;
            DateTime dateBirth = txtngaySinh.Value;
            string placeBirth = txtnoiSinh.Text;
            string nation = txtdanToc.Text;
            string nationality = txtquocTich.Text;
            string idCityzen = txtCCCD.Text;
            DateTime licenseDate = txtngayCap.Value;
            string licensePlace = txtnoiCap.Text;
            string address_cur = txtCOHN.Text;
            string province_cur = txtCOHN_C1.Text;
            string district_cur = txtCOHN_2.Text;
            string commune_cur = txtCOHN_3.Text;
            string address_res = txtDCTT.Text;
            string province_res = txtDCTT_C1.Text;
            string district_res = txtDCTT_C2.Text;
            string commune_res = txtDCTT_C3.Text;
            string roled = txtChucVu.Text;
            bool actived = (txtGioiTinh.Text == "True") ? true : false;
            string phone = txtsoDienThoai.Text;
            string email = txtEmail.Text;

            if (!(string.IsNullOrEmpty(idStaff)) && !(string.IsNullOrEmpty(nameStaff)) && !(string.IsNullOrEmpty(placeBirth)) && !(string.IsNullOrEmpty(nation)) &&
                !(string.IsNullOrEmpty(nationality)) && !(string.IsNullOrEmpty(idCityzen)) && !(string.IsNullOrEmpty(licensePlace)) && !(string.IsNullOrEmpty(address_cur)) &&
                !(string.IsNullOrEmpty(province_cur)) && !(string.IsNullOrEmpty(district_cur)) && !(string.IsNullOrEmpty(commune_cur)) && !(string.IsNullOrEmpty(address_res)) &&
                !(string.IsNullOrEmpty(province_res)) && !(string.IsNullOrEmpty(district_res)) && !(string.IsNullOrEmpty(commune_res)) && !(string.IsNullOrEmpty(roled)) &&
                !(string.IsNullOrEmpty(phone)) && !(string.IsNullOrEmpty(email)) && (DateTime.Now).Subtract(dateBirth).Days > 7300 && (DateTime.Now).Subtract(licenseDate).Days > 0)
            {
                bool success = AccountDAO.Instance.UpdateStaffInfo(idStaff, nameStaff, gender, dateBirth, placeBirth, nation, nationality, idCityzen, licenseDate, licensePlace, address_cur, province_cur, district_cur, commune_cur, address_res, province_res, district_res, commune_res, roled, actived, phone, email);

                if (success)
                {
                    MessageBox.Show("Cập nhật thông tin thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Cập nhật thông tin thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }

        //Xóa danh sách nhân viên
        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                string idStaff = txtMaNhanVien.Text;
                if (!(string.IsNullOrEmpty(idStaff)))
                {
                    bool check = AccountDAO.Instance.DeleteStaff(idStaff);
                    if (check)
                    {
                        MessageBox.Show("Xóa thông tin thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Xóa thông tin thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch 
            {
                MessageBox.Show("Giáo viên hiện tại đang có lớp");
            }
        }


        //Đổi mật khẩu nhân viên
        private void btnDoiMatKhau_Click(object sender, EventArgs e)
        {
            this.Hide();
            DoiMatKhau q  = new DoiMatKhau();
            q.ShowDialog();
        }

        
        //Thoát 
        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
            TrangChu t = new TrangChu();
            t.Show();

        }

        //Xóa dữ liệu 
        private void clearData()
        {
            txtHoTen.Clear();
            txtEmail.Clear();
            txtGioiTinh.Items.Clear();
            txtMaNhanVien.Clear();
            txtngaySinh.Value = DateTime.Now;
            txtquocTich.Clear();
            txtdanToc.Clear();
            txtngayCap.Value = DateTime.Now;
            txtsoDienThoai.Clear();
            txtCCCD.Clear();
            txtnoiCap.Items.Clear();
            txtCOHN.Clear();
            txtCOHN_C1.Items.Clear();
            txtCOHN_2.Items.Clear(); 
            txtCOHN_3.Items.Clear();
            txtDCTT.Clear();
            txtDCTT_C1.Items.Clear();
            txtDCTT_C2.Items.Clear();
            txtDCTT_C3.Items.Clear();
            txtChucVu.Items.Clear();
            txttrangThai.Items.Clear();
            txtnoiSinh.Clear();
        }

        //Chuyển thành enable = true 
        private void enableInfor()
        {
            TextBox hoTen = txtHoTen;
            hoTen.Enabled = true;
            txtEmail.Enabled = true;
            txtGioiTinh.Enabled = true;
            txtMaNhanVien.Enabled = true;
            txtngaySinh.Enabled = true;
            txtquocTich.Enabled = true;
            txtdanToc.Enabled = true;
            txtngayCap.Enabled = true;
            txtsoDienThoai.Enabled = true;
            txtCCCD.Enabled = true;
            txtnoiCap.Enabled = true;
            txtCOHN.Enabled = true;
            txtCOHN_C1.Enabled = true;
            txtCOHN_2.Enabled = true;
            txtCOHN_3.Enabled = true;
            txtDCTT.Enabled = true;
            txtDCTT_C1.Enabled = true;
            txtDCTT_C2.Enabled = true;
            txtDCTT_C3.Enabled = true;
            txtChucVu.Enabled = true;
            txttrangThai.Enabled = true;
            txtnoiSinh.Enabled = true;
        }

        //Đăng xuất 
        private void btnDangXuat_click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn đăng xuất hay không?", "Thông báo", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
            {
                this.Close();
                DangNhap d = new DangNhap();
                d.Show();
            }
        }

        //check Email
        static bool IsValidEmail(string email)
        {
            string pattern = @"^[a-zA-Z0-9_.+-]+@[a-zA-Z0-9-]+\.[a-zA-Z0-9-.]+$";
            return Regex.IsMatch(email, pattern);
        }

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
