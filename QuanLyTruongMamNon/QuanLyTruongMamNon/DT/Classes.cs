using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyTruongMamNon.DT
{
    public class Classes
    {
        private string yearSchool;
        private string className;
        private string teacher;
        private int wholesale;

        public string YearSchool { get => yearSchool; set => yearSchool = value; }
        public string ClassName { get => className; set => className = value; }
        public string Teacher { get => teacher; set => teacher = value; }
        public int WholeSale { get => wholesale; set => wholesale = value; }


        public Classes(string yearSchool, string className, string teacher, int wholesale)
        {
            this.YearSchool = yearSchool;
            this.ClassName = className;
            this.Teacher = teacher;
            this.wholesale = wholesale;
        }
        
        public Classes()
        {
            this.yearSchool = YearSchool;
            this.className = ClassName;
            this.teacher = Teacher;
            this.wholesale = WholeSale;
        }

        public Classes (DataRow row)
        {
            this.YearSchool = row["yearSchool"].ToString();
            this.ClassName = row["className"].ToString();
            this.Teacher = row["teacher"].ToString();
            this.WholeSale = Convert.ToInt16(row["wholesale"]);
        }
    }
}
