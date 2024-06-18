using QuanLyTruongMamNon.DT;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;

namespace QuanLyTruongMamNon.DAO
{
    public class ClassesDAO
    {
        private static ClassesDAO instance;
        public static ClassesDAO Instance
        {
            get { if (instance == null) instance = new ClassesDAO(); return instance; }
            private set { instance = value; }
        }
        private ClassesDAO() { }


        //Hiện các lớp còn trống
        public List<Classes> LoadEmptyClass(string yearSchool)
        {
            List<Classes> classList = new List<Classes>();
            string query = "USP_LoadEmptyClass @yearSchool";
            DataTable data = DataProvider.Instance.ExcuteQuery(query, new object[] { yearSchool });
            foreach (DataRow row in data.Rows)
            {
                Classes classes = new Classes(row);
                classList.Add(classes);
            }
            return classList;
        }

        //Hiện năm học
        public List<Classes> LoadListYear()
        {
            string query = "select * from CLASSES";
            DataTable data = DataProvider.Instance.ExcuteQuery(query);
            List<Classes> yearList = new List<Classes>();
            foreach (DataRow row in data.Rows)
            {
                Classes c = new Classes(row);
                if (!yearList.Any(item => item.YearSchool == c.YearSchool))
                {
                    yearList.Add(c);
                }
            }
            return yearList;
        }

        //Hiện lớp
        public List<Classes> LoadListClasses()
        {
            string query = "select * from CLASSES";
            DataTable data = DataProvider.Instance.ExcuteQuery(query);
            List<Classes> classList = new List<Classes>();
            foreach (DataRow row in data.Rows)
            {
                Classes c = new Classes(row);
                if (!classList.Any(item => item.ClassName == c.ClassName))
                {
                    classList.Add(c);
                }
            }
            return classList;
        }

        //Khai báo năm học
        public void NewSchoolYear(string yearSchool, string className, string teacher, int wholesale)
        {
            string query = "INSERT INTO CLASSES(yearSchool , className , teacher , wholesale ) VALUES ('" + yearSchool + "' , N'" + className + "' , '" + teacher + " ' , "+ wholesale+ " );";
            DataProvider.Instance.ExcuteNonQuery(query);
        }


        //Hiện lớp đang có
        internal List<Classes> getAllClass()
        {
            string query = " select * from Classes ";
            DataTable allClass = DataProvider.Instance.ExcuteQuery(query);
            List<Classes> classes = new List<Classes>();
            foreach (DataRow st in allClass.Rows)
            {
                Classes s = new Classes(st);
                classes.Add(s);
            }
            return classes;
        }
    }
}
