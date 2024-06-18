using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyTruongMamNon.DT
{
    internal class Student
    {
        private string idStudent;
        private string nameStudent;
        private bool gender;
        private DateTime dateBirth;
        private string placeBirth;
        private string nation;
        private string nationality;
        private string address_cur;
        private string province_cur;
        private string district_cur;
        private string commune_cur;
        private string address_res;
        private string province_res;
        private string district_res;
        private string commune_res;
        private string yearSchool;
        private string classes;
        private bool actived;

        public string IdStudent { get => idStudent; set => idStudent = value; }
        public string NameStudent { get => nameStudent; set => nameStudent = value; }
        public bool Gender { get => gender; set => gender = value; }
        public DateTime DateBirth { get => dateBirth; set => dateBirth = value; }
        public string PlaceBirth { get => placeBirth; set => placeBirth = value; }
        public string Nation { get => nation; set => nation = value; }
        public string Nationality { get => nationality; set => nationality = value; }
        public string AddressCur { get => address_cur; set => address_cur = value; }
        public string ProvinceCur { get => province_cur; set => province_cur = value; }
        public string DistrictCur { get => district_cur; set => district_cur = value; }
        public string CommuneCur { get => commune_cur; set => commune_cur = value; }
        public string AddressRes { get => address_res; set => address_res = value; }
        public string ProvinceRes { get => province_res; set => province_res = value; }
        public string DistrictRes { get => district_res; set => district_res = value; }
        public string CommuneRes { get => commune_res; set => commune_res = value; }
        public string YearSchool { get => yearSchool; set => yearSchool = value; }
        public string Classes { get => classes; set => classes = value; }
        public bool Actived { get => actived; set => actived = value; }


        public Student(string id, string name, bool gen, DateTime dob, string place, string nat, string nation, string addrCur, string provinceCur, string districtCur, string communeCur, string addrRes, string provinceRes, string districtRes, string communeRes, string year, string cls, bool active)
        {
            this.idStudent = id;
            this.nameStudent = name;
            this.gender = gen;
            this.DateBirth = dob;
            this.placeBirth = place;
            this.nation = nat;
            this.nationality = nation;
            this.address_cur = addrCur;
            this.province_cur = provinceCur;
            this.district_cur = districtCur;
            this.commune_cur = communeCur;
            this.address_res = addrRes;
            this.province_res = provinceRes;
            this.district_res = districtRes;
            this.commune_res = communeRes;
            this.yearSchool = year;
            this.classes = cls;
            this.actived = active;
        }


        public Student(DataRow row)
        {
            this.idStudent = row["idStudent"].ToString();
            this.nameStudent = row["nameStudent"].ToString();
            this.gender = Convert.ToBoolean(row["gender"]);
            this.DateBirth = Convert.ToDateTime(row["dateBirth"]);
            this.placeBirth = row["placeBirth"].ToString();
            this.nation = row["nation"].ToString();
            this.nationality = row["nationality"].ToString();
            this.address_cur = row["address_cur"].ToString();
            this.province_cur = row["province_cur"].ToString();
            this.district_cur = row["district_cur"].ToString();
            this.commune_cur = row["commune_cur"].ToString();
            this.address_res = row["address_res"].ToString();
            this.province_res = row["province_res"].ToString();
            this.district_res = row["district_res"].ToString();
            this.commune_res = row["commune_res"].ToString();
            this.yearSchool = row["yearSchool"].ToString();
            this.classes = row["class"].ToString();
            this.actived = Convert.ToBoolean(row["actived"]);
        }



    }
}
