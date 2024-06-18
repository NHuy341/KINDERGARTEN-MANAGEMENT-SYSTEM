using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing.Text;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;


namespace QuanLyTruongMamNon.DT
{
    internal class Account
    {
        private string idStaff;
        private string nameStaff;
        private bool gender;
        private DateTime dateBirth;
        private string placeBirth;
        private string nation;
        private string nationality;
        private string idCityzen;
        private DateTime licenseDate;
        private string licensePlace;
        private string address_cur;
        private string province_cur;
        private string district_cur;
        private string commune_cur;
        private string address_res;
        private string province_res;
        private string district_res;
        private string commune_res;
        private string roled;
        private bool actived;
        private string phone;
        private string email;

        public string IdStaff { get => idStaff; set => idStaff = value; }
        public string NameStaff { get => nameStaff; set => nameStaff = value; }
        public bool Gender { get => gender; set => gender = value; }
        public DateTime DateBirth { get => dateBirth; set => dateBirth = value; }
        public string PlaceBirth { get => placeBirth; set => placeBirth = value; }
        public string Nation { get => nation; set => nation = value; }
        public string Nationality { get => nationality; set => nationality = value; }
        public string IdCityzen { get => idCityzen; set => idCityzen = value; }
        public DateTime LicenseDate { get => licenseDate; set => licenseDate = value; }
        public string LicensePlace { get => licensePlace; set => licensePlace = value; }
        public string AddressCur { get => address_cur; set => address_cur = value; }
        public string ProvinceCur { get => province_cur; set => province_cur = value; }
        public string DistrictCur { get => district_cur; set => district_cur = value; }
        public string CommuneCur { get => commune_cur; set => commune_cur = value; }
        public string AddressRes { get => address_res; set => address_res = value; }
        public string ProvinceRes { get => province_res; set => province_res = value; }
        public string DistrictRes { get => district_res; set => district_res = value; }
        public string CommuneRes { get => commune_res; set => commune_res = value; }
        public string Roled { get => roled; set => roled = value; }
        public bool Actived { get => actived; set => actived = value; }
        public string Phone { get => phone; set => phone = value; }
        public string Email { get => email; set => email = value; }



        public Account(string idStaff, string nameStaff, bool gender, DateTime dateBirth, string placeBirth, string nation, string nationality, string idCityzen, DateTime licenseDate, string licensePlace, string address_cur, string province_cur, string district_cur, string commune_cur, string address_res, string province_res, string district_res, string commune_res, string roled, bool actived, string phone, string email)
        {
            this.IdStaff = idStaff;
            this.NameStaff = nameStaff;
            this.Gender = gender;
            this.DateBirth = dateBirth;
            this.PlaceBirth = placeBirth;
            this.Nation = nation;
            this.Nationality = nationality;
            this.IdCityzen = idCityzen;
            this.LicenseDate = licenseDate;
            this.LicensePlace = licensePlace;
            this.AddressCur = address_cur;
            this.ProvinceCur = province_cur;
            this.DistrictCur = district_cur;
            this.CommuneCur = commune_cur;
            this.AddressRes = address_res;
            this.ProvinceRes = province_res;
            this.DistrictRes = district_res;
            this.CommuneRes = commune_res;
            this.Roled = roled;
            this.Actived = actived;
            this.Phone = phone;
            this.Email = email;
        }


        public Account(DataRow row)
        {
            this.IdStaff = row["idStaff"].ToString();
            this.NameStaff = row["nameStaff"].ToString();

            //this.Gender = Convert.ToBoolean(row["gender"]);

            object genderValue = row["gender"];
            if (genderValue != DBNull.Value)
            {
                this.Gender = Convert.ToBoolean(genderValue);
            }
            else
            {
                this.Gender = false;
            }


            //this.DateBirth = Convert.ToDateTime(row["dateBirth"]);
            object dateOfBirthValue = row["dateBirth"];
            if (dateOfBirthValue != DBNull.Value)
            {
                this.DateBirth = Convert.ToDateTime(dateOfBirthValue);
            }
            else
            {
                this.DateBirth = DateTime.MinValue;
            }


            this.PlaceBirth = row["placeBirth"].ToString();
            this.Nation = row["nation"].ToString();
            this.Nationality = row["nationality"].ToString();
            this.IdCityzen = row["idCityzen"].ToString();

            //this.LicenseDate = Convert.ToDateTime(row["licenseDate"]);
            object licenseDateValue = row["licenseDate"];
            if (licenseDateValue != DBNull.Value)
            {
                this.LicenseDate = Convert.ToDateTime(licenseDateValue);
            }
            else
            {
                this.LicenseDate = DateTime.MinValue;

            }
            this.LicensePlace = row["licensePlace"].ToString();
            this.AddressCur = row["address_cur"].ToString();
            this.ProvinceCur = row["province_cur"].ToString();
            this.DistrictCur = row["district_cur"].ToString();
            this.CommuneCur = row["commune_cur"].ToString();
            this.AddressRes = row["address_res"].ToString();
            this.ProvinceRes = row["province_res"].ToString();
            this.DistrictRes = row["district_res"].ToString();
            this.CommuneRes = row["commune_res"].ToString();
            this.Roled = row["roled"].ToString();

            //this.Actived = Convert.ToBoolean(row["actived"]);
            object activedValue = row["actived"];
            if (activedValue != DBNull.Value)
            {
                this.Actived = Convert.ToBoolean(activedValue);
            }
            else
            {
                this.Actived = false;
            }


            this.Phone = row["phone"].ToString();
            this.Email = row["email"].ToString();
        }
    }
}
