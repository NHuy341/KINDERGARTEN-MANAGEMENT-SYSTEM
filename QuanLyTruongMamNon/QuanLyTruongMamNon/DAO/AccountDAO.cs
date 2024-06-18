using QuanLyTruongMamNon.DT;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace QuanLyTruongMamNon.DAO
{
    public class AccountDAO
    {
        private static AccountDAO instance;
        public static AccountDAO Instance 
        {
            get { if (instance == null) instance = new AccountDAO(); return instance; }
            private set { instance = value; }
        }
        private AccountDAO() { }

        private string user;

        public string getUser()
        {
            return this.user;
        }

        //Đăng nhập
        public bool Login(string username, string password)
        {
            this.user = username;
            string query = "USP_Login @userName , @password";
            DataTable result = DataProvider.Instance.ExcuteQuery(query, new object[] { username , password } );
            return result.Rows.Count > 0;
        }

        //Count ROle 
        public int GetStaffCountByRole(string role)
        {

            string query = "SELECT * FROM STAFFS WHERE roled = @roled ;";

            int result = DataProvider.Instance.ExcuteQuery(query, new object[] { role }).Rows.Count;
            return result;
        }

        //Quen mật khẩu
        public bool ForgotPassword(string username, string newPassword , string email)
        {
            string query = "USP_ForgotPassword @userName , @newPassword , @email";
            DataTable result = DataProvider.Instance.ExcuteQuery(query, new object[] { username , newPassword , email });
            return result.Rows.Count > 0 && result.Rows[0]["Result"].ToString() == "Success";
        }

        //doi
        public bool ChangePass(string id, string mkht , string mkm)
        {
            string query = "USP_ChangePassword @id , @pwd , @newpwd";
            DataTable result = DataProvider.Instance.ExcuteQuery(query, new object[] { id, mkht , mkm });
            return result.Rows.Count > 0 && result.Rows[0]["Result"].ToString() == "Success";
        }

        //Xem thông tin nhân viên
        internal Account loadStaff(string username)
        {
            string query = "select * from STAFFS where phone = '"+ username +"'";
            DataTable result = DataProvider.Instance.ExcuteQuery(query);
            Account account = new Account(result.Rows[0]);
            return account;
        }
        internal Account loadStaff1()
        {
            return loadStaff(user);
        }

        //Thêm nhân viên
        internal bool AddNewStaff(string idStaff, string nameStaff, bool gender, DateTime dateBirth, string placeBirth, string nation, string nationality, string idCityzen, DateTime licenseDate, string licensePlace, string address_cur, string province_cur, string district_cur, string commune_cur, string address_res, string province_res, string district_res, string commune_res, string roled, bool actived, string phone, string email)
        {
            string query = "USP_AddNewStaff @idStaff , @nameStaff , @gender , @dateBirth , @placeBirth , @nation , @nationality , @idCityzen , @licenseDate , @licensePlace , @address_cur , @province_cur , @district_cur , @commune_cur , @address_res , @province_res , @district_res , @commune_res , @roled , @actived , @phone , @email ";
            int result = DataProvider.Instance.ExcuteNonQuery(query, new object[] { idStaff, nameStaff, gender, dateBirth, placeBirth, nation, nationality, idCityzen, licenseDate, licensePlace, address_cur, province_cur, district_cur, commune_cur, address_res, province_res, district_res, commune_res, roled, actived, phone, email });
            return result > 0;
        }
        //sửa thông tin nhân viên 
        internal bool UpdateStaffInfo(string idStaff, string nameStaff, bool gender, DateTime dateBirth, string placeBirth, string nation, string nationality, string idCityzen, DateTime licenseDate, string licensePlace, string address_cur, string province_cur, string district_cur, string commune_cur, string address_res, string province_res, string district_res, string commune_res, string roled, bool actived, string phone, string email)
        {
            string query = "USP_UpdateStaffInfo @idStaff , @nameStaff , @gender , @dateBirth , @placeBirth , @nation , @nationality , @idCityzen , @licenseDate , @licensePlace , @address_cur , @province_cur , @district_cur , @commune_cur , @address_res , @province_res , @district_res , @commune_res , @roled , @actived , @phone , @email ";
            int result = DataProvider.Instance.ExcuteNonQuery(query, new object[] { idStaff, nameStaff, gender, dateBirth, placeBirth, nation, nationality, idCityzen, licenseDate, licensePlace, address_cur, province_cur, district_cur, commune_cur, address_res, province_res, district_res, commune_res, roled, actived, phone, email });
            return result > 0;
        }

        //Xóa nhân viên
        internal bool DeleteStaff(string idStaff)
        {
            string query = "USP_DeleteStaff @idStaff";
            int rowsAffected = DataProvider.Instance.ExcuteNonQuery(query, new object[] { idStaff });
            return rowsAffected > 0;
        }


        //tìm kiếm
        internal List<Account> getAllStaffs()
        {
            string query = " select * from STAFFS ";
            DataTable allStaff = DataProvider.Instance.ExcuteQuery(query);
            List<Account> staffs = new List<Account>();
            foreach (DataRow st in allStaff.Rows)
            {
                Account s = new Account(st);
                staffs.Add(s);
            }
            return staffs;
        }
    }
}
