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
    public partial class HoSoHocSinh : Form
    {
        public HoSoHocSinh()
        {
            InitializeComponent();
            formLoad();
            LoadListYearSchool();
        }

        public HoSoHocSinh(string id)
        {
            InitializeComponent();
            formLoad();
            LoadListYearSchool();
            loadStudent(id);
        }

        private void formLoad()
        {
            MainFunc.basicFormLoad(this);
            MainMenu.SetupMainMenu(menu);
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

        //Load sinhvien
        private void loadStudent(string id)
        {
            Student stu = StudentDAO.Instance.LoadStu(id);
            hoTen.Text = stu.NameStudent;
            gioiTinh.Text = stu.Gender ? "Nam" : "Nữ";
            ngaySinh.Value = stu.DateBirth;
            noiSinh.Text = stu.PlaceBirth;
            danToc.Text = stu.Nation;
            quocTich.Text = stu.Nationality;
            COHN.Text = stu.AddressCur;
            COHN_C1.Text = stu.ProvinceCur;
            COHN_2.Text = stu.DistrictCur;
            COHN_3.Text = stu.CommuneCur;
            DCTT.Text = stu.AddressRes;
            DCTT_C1.Text = stu.ProvinceRes;
            DCTT_C2.Text = stu.DistrictRes;
            DCTT_C3.Text = stu.CommuneRes;
            maHS.Text = stu.IdStudent;
            namHoc.Text = stu.YearSchool;
            lopHoc.Text = stu.Classes;
            trangThai.Text = stu.Actived.ToString();
        }

        //Tải dữ liệu lớp trống
        private void loadClasses(string namHoc)
        {
            List<Classes> classes = ClassesDAO.Instance.LoadEmptyClass(namHoc);
            lopHoc.DataSource = classes;
            lopHoc.DisplayMember = "className";
        }
        private void loadClasses(object sender, EventArgs e)
        {
            string Nam = namHoc.Text;
            loadClasses(Nam);
        }

        //Hiện năm học
        private void LoadListYearSchool()
        {
            List<Classes> year = ClassesDAO.Instance.LoadListYear();
            var distinctYears = year.GroupBy(x => x.YearSchool).Select(g => g.First()).ToList();
            namHoc.DataSource = distinctYears;
            namHoc.DisplayMember = "YearSchool";
        }

        private void btnNguoiDung_click(object sender, EventArgs e)
        {
            this.Hide();
            HoSoNHanVien hs = new HoSoNHanVien();
            hs.ShowDialog();

        }

        private void btnXem_click(object sender, EventArgs e)
        {
            this.Hide();
            XemThongBao x = new XemThongBao();
            x.Show();
        }

        //Thêm học sinh
        private void btnThemMoi_Click(object sender, EventArgs e)
        {
            string idStudent = maHS.Text;
            string nameStudent = hoTen.Text;
            bool gender = (gioiTinh.Text == "Nam") ? true : false;
            DateTime dateBirth = ngaySinh.Value;
            string placeBirth = noiSinh.Text;
            string nation = danToc.Text;
            string nationality = quocTich.Text;
            string address_cur = COHN.Text;
            string province_cur = COHN_C1.Text;
            string district_cur = COHN_2.Text;
            string commune_cur = COHN_3.Text;
            string address_res = DCTT.Text;
            string province_res = DCTT_C1.Text;
            string district_res = DCTT_C2.Text;
            string commune_res = DCTT_C3.Text;
            string classes = lopHoc.Text;
            bool actived = (trangThai.Text == "True") ? true : false;
            string yearSchool = namHoc.Text;

            string idNhanThan1;
            string idNhanThan2;
            string namenhanThan1 = nhanThan1.Text;
            string phone1 = nhanThan1_dienThoai.Text;
            string yearBorn1 = nhanThan1_namSinh.Text;
            string relationship1 = nhanThan1_quanHe.Text;
            string namenhanThan2 = nhanThan2.Text;
            string phone2 = nhanThan2_dienThoai.Text;
            string yearBorn2 = nhanThan2_namSinh.Text;
            string relationship2 = nhanThan2_quanHe.Text;

            try
            {
                if (!(string.IsNullOrEmpty(idStudent)) && !(string.IsNullOrEmpty(nameStudent)) && !(string.IsNullOrEmpty(placeBirth)) && !(string.IsNullOrEmpty(nation)) && !(string.IsNullOrEmpty(classes)) &&
                !(string.IsNullOrEmpty(nationality)) && !(string.IsNullOrEmpty(address_cur)) && !(string.IsNullOrEmpty(province_cur)) && !(string.IsNullOrEmpty(district_cur)) && !(string.IsNullOrEmpty(namenhanThan1)) &&
                !(string.IsNullOrEmpty(commune_cur)) && !(string.IsNullOrEmpty(address_res)) && !(string.IsNullOrEmpty(province_res)) && !(string.IsNullOrEmpty(district_res)) && !(string.IsNullOrEmpty(namenhanThan2)) &&
                !(string.IsNullOrEmpty(commune_res)) && (DateTime.Now).Subtract(dateBirth).Days > 1000 && !(string.IsNullOrEmpty(gender.ToString())) && !(string.IsNullOrEmpty(yearSchool)) && !(string.IsNullOrEmpty(phone1)) &&
                !(string.IsNullOrEmpty(yearBorn1)) && !(string.IsNullOrEmpty(relationship1)) && !(string.IsNullOrEmpty(phone2)) && !(string.IsNullOrEmpty(yearBorn2)) && !(string.IsNullOrEmpty(relationship2)) &&
                phone1.Length == 10 && phone1.Substring(0, 1) == "0" && phone2.Length == 10 && phone2.Substring(0, 1) == "0" && IsNumeric(phone1) && IsNumeric(phone2))
                {
                    string idNhanThan1_1 = string.Concat(relationship1.Substring(0, 1), idStudent.Substring(0, 4));
                    idNhanThan1 = string.Concat(idNhanThan1_1, idStudent.Substring(5, 3));
                    string idNhanThan2_1 = string.Concat(relationship2.Substring(0, 1), idStudent.Substring(0, 4));
                    idNhanThan2 = string.Concat(idNhanThan2_1, idStudent.Substring(5, 3));

                    bool checkStudent = StudentDAO.Instance.AddNewStudent(idStudent, nameStudent, gender, dateBirth, placeBirth, nation, nationality, address_cur, province_cur, district_cur, commune_cur, address_res, province_res, district_res, commune_res, yearSchool, classes, actived);
                    bool checkNhanThan1 = StudentDAO.Instance.AddNewRelationship(idStudent, idNhanThan1, namenhanThan1, phone1, yearBorn1, relationship1);
                    bool checkNhanThan2 = StudentDAO.Instance.AddNewRelationship(idStudent, idNhanThan2, namenhanThan2, phone2, yearBorn2, relationship2);

                    if (checkStudent = true && checkNhanThan1 == true && checkNhanThan2 == true)
                    {
                        MessageBox.Show("Thêm thành công");
                    }
                    else
                    {
                        MessageBox.Show("Thêm thất bại");
                    }

                }
                else
                {
                    MessageBox.Show("Không được để trống dữ liệu");
                    return;
                }
            }
            catch
            {
                MessageBox.Show("ID học sinh đã tồn tại");
            }
        }

        //Cập nhật học sinh
        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            string idStudent = maHS.Text;
            string nameStudent = hoTen.Text;
            bool gender = (gioiTinh.Text == "Nam") ? true : false;
            DateTime dateBirth = ngaySinh.Value;
            string placeBirth = noiSinh.Text;
            string nation = danToc.Text;
            string nationality = quocTich.Text;
            string address_cur = COHN.Text;
            string province_cur = COHN_C1.Text;
            string district_cur = COHN_2.Text;
            string commune_cur = COHN_3.Text;
            string address_res = DCTT.Text;
            string province_res = DCTT_C1.Text;
            string district_res = DCTT_C2.Text;
            string commune_res = DCTT_C3.Text;
            string classes = lopHoc.Text;
            bool actived = (trangThai.Text == "True") ? true : false;
            string yearSchool = namHoc.Text;

            if (!(string.IsNullOrEmpty(idStudent)) && !(string.IsNullOrEmpty(nameStudent)) && !(string.IsNullOrEmpty(placeBirth)) && !(string.IsNullOrEmpty(nation)) && !(string.IsNullOrEmpty(classes)) &&
                !(string.IsNullOrEmpty(nationality)) && !(string.IsNullOrEmpty(address_cur)) && !(string.IsNullOrEmpty(province_cur)) && !(string.IsNullOrEmpty(district_cur)) &&
                !(string.IsNullOrEmpty(commune_cur)) && !(string.IsNullOrEmpty(address_res)) && !(string.IsNullOrEmpty(province_res)) && !(string.IsNullOrEmpty(district_res)) &&
                !(string.IsNullOrEmpty(commune_res)) && (DateTime.Now).Subtract(dateBirth).Days > 1000 && !(string.IsNullOrEmpty(gender.ToString())) && !(string.IsNullOrEmpty(yearSchool)))
            {
                bool checkStudent = StudentDAO.Instance.UpdateStudent(idStudent, nameStudent, gender, dateBirth, placeBirth, nation, nationality, address_cur, province_cur, district_cur, commune_cur, address_res, province_res, district_res, commune_res, yearSchool, classes, actived);

                if (checkStudent)
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

        //Chỉnh sửa
        private void btnChinhSua_Click(object sender, EventArgs e)
        {
            clearData();
        }


        //xóa 
        private void btnXoa_click(object sender, EventArgs e ) 
        {
            string idStudent = maHS.Text;
            if (!(string.IsNullOrEmpty(idStudent)) && StudentDAO.Instance.getStudentByID(idStudent))
            {
                try
                {
                    StudentDAO.Instance.DeleteStudent(idStudent);
                    MessageBox.Show("Xóa thông tin thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch
                {
                    MessageBox.Show("Lỗi khi xóa");
                }
            }
            else
            {
                MessageBox.Show("Xóa thông tin thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void clearData()
        {
            hoTen.Clear();
            gioiTinh.SelectedIndex = 0;
            ngaySinh.Value = DateTime.Now;
            quocTich.Items.Clear();
            danToc.Items.Clear();
            COHN.Clear();
            COHN_C1.Items.Clear();
            COHN_2.Items.Clear();
            COHN_3.Items.Clear();
            DCTT.Clear();
            DCTT_C1.Items.Clear();
            DCTT_C2.Items.Clear();
            DCTT_C3.Items.Clear();
            trangThai.Items.Clear();
            noiSinh.Items.Clear();

            maHS.Enabled = true;
            nhanThan1.Enabled = false;
            nhanThan1_dienThoai.Enabled = false;
            nhanThan1_namSinh.Enabled = false;
            nhanThan1_quanHe.Enabled = false;
            nhanThan2.Enabled = false;
            nhanThan2_dienThoai.Enabled = false;
            nhanThan2_namSinh.Enabled = false;
            nhanThan2_quanHe.Enabled = false;

        }
        //tạo mã tự động id học sinh
        private string GenerateStudentID(string yearSchool)
        {
            // Lấy năm học từ chuỗi năm học
            string[] years = yearSchool.Split('-');
            int startYear = int.Parse(years[0]);
            int endYear = int.Parse(years[1]);

            // Tạo ID học sinh dạng số thứ tự
            int studentCount = StudentDAO.Instance.GetStudentCount(yearSchool) + 1;

            // Format ID học sinh theo yêu cầu (VD: 23240001)
            string studentID = $"{startYear % 100}{endYear % 100}{studentCount:D4}";

            return studentID;
        }

        private void loadID(object sender, EventArgs e)
        {
            string Nam = namHoc.Text;
            maHS.Text = GenerateStudentID(Nam);

        }

        //In thẻ học sinh
        private void btnIn_click(object sender, EventArgs e)
        {
            this.Hide();
            TheHocSinh t = new TheHocSinh(maHS.Text,hoTen.Text, gioiTinh.Text ,namHoc.Text,ngaySinh.Value);
            t.ShowDialog();
        }

        //check
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
