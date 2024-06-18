using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    internal class DangNhapTaiKhoan
    {
        public string idStaff { get; set; }
        public string nameStaff { get; set; }
        public bool gender { get; set; }
        public DateTime dateBirth { get; set; }
        public string placeBirth { get; set; }
        public string nation { get; set; }
        public string nationality { get; set; }
        public string idCityzen { get; set; }
        public DateTime licenseDate { get; set; }
        public string licensePlace { get; set; }
        public string addressCur { get; set; }
        public string provinceCur { get; set; }
        public string districtCur { get; set; }
        public string communeCur { get; set; }
        public string addressRes { get; set; }
        public string provinceRes { get; set; }
        public string districtRes { get; set; }
        public string communeRes { get; set; }
        public string roled { get; set; }
        public bool actived { get; set; }
        public string phone { get; set; }
        public string email { get; set; }
    }
}
