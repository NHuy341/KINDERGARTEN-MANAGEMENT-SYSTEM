using QuanLyTruongMamNon.DT;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Resources;
using ZXing;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace QuanLyTruongMamNon.DAO
{
    public class StudentDAO
    {
        private static StudentDAO instance;
        public static StudentDAO Instance
        {
            get { if (instance == null) instance = new StudentDAO(); return instance; }
            private set { instance = value; }
        }
        private StudentDAO() { }

        //Thêm mới học sinh
        internal bool AddNewStudent(string idStudent, string nameStudent, bool gender, DateTime dateBirth, string placeBirth, string nation, string nationality, string address_cur, string province_cur, string district_cur, string commune_cur, string address_res, string province_res, string district_res, string commune_res, string yearSchool, string classes, bool actived)
        {
            string query = "USP_AddNewStudent @idStudent , @nameStudent , @gender , @dateBirth , @placeBirth , @nation , @nationality , @address_cur , @province_cur , @district_cur , @commune_cur , @address_res , @province_res , @district_res , @commune_res , @yearSchool , @classes , @actived  ";
            int result = DataProvider.Instance.ExcuteNonQuery(query, new object[] { idStudent , nameStudent , gender , dateBirth , placeBirth, nation, nationality, address_cur , province_cur , district_cur , commune_cur , address_res, province_res, district_res, commune_res, yearSchool , classes , actived });
            return result > 0;
        }

        //Thêm mới nhân thân
        internal bool AddNewRelationship(string idStudent, string idRelationship,string nameRelationship,string phone,string yearBorn,string relationship)
        {
            string query = "USP_AddNewRelationship @idStudent , @nameRelative , @phone , @yearBorn , @idRelative , @relationship ";
            int result = DataProvider.Instance.ExcuteNonQuery(query, new object[] { idStudent , nameRelationship , phone , yearBorn , idRelationship , relationship });
            return result > 0;
        }


        //Đếm số lượng học sinh đã có
        public int GetStudentCount(string yearSchool)
        {

            string query = "SELECT * FROM Students WHERE yearSchool = @yearSchool ;";

            int result = DataProvider.Instance.ExcuteQuery(query,new object[] { yearSchool }).Rows.Count;
            return result;
        }

        //Cập nhật thông tin học sinh
        internal bool UpdateStudent(string idStudent, string nameStudent, bool gender, DateTime dateBirth, string placeBirth, string nation, string nationality, string address_cur, string province_cur, string district_cur, string commune_cur, string address_res, string province_res, string district_res, string commune_res, string yearSchool, string classes, bool actived)
        {
            string query = "USP_UpdateStudent @idStudent , @nameStudent , @gender , @dateBirth , @placeBirth , @nation , @nationality , @address_cur , @province_cur , @district_cur , @commune_cur , @address_res , @province_res , @district_res , @commune_res , @yearSchool , @classes , @actived  ";
            int result = DataProvider.Instance.ExcuteNonQuery(query, new object[] { idStudent, nameStudent, gender, dateBirth, placeBirth, nation, nationality, address_cur, province_cur, district_cur, commune_cur, address_res, province_res, district_res, commune_res, yearSchool, classes, actived });
            return result > 0;
        }
    
        internal bool DeleteStudent(string idStudent)
        {
            string query = "USP_DeleteStudent @idStudent ";
            int rowsAffected = DataProvider.Instance.ExcuteNonQuery(query, new object[] { idStudent });
            return rowsAffected >0;
        }

        //Tìm kiếm sinh viên theo ID 
        internal bool getStudentByID(string id)
        {
            string query = " select * from STUDENTS where idStudent = " + id + ";";
            DataTable Student = DataProvider.Instance.ExcuteQuery(query);
            int count = Student.Rows.Count;
            return count > 0;
        }

        //Tìm kiếm 
        internal List<Student> getAllStudents()
        {
            string query = " select * from STUDENTS ";
            DataTable allStudents = DataProvider.Instance.ExcuteQuery(query);
            List<Student> students = new List<Student>();
            foreach (DataRow st in allStudents.Rows)
            {
                Student s = new Student(st);
                students.Add(s);
            }
            return students;
        }

        //Thêm thành tích
        internal bool AddAchieve(string maHS , DateTime date ,string nd )
        {
            string query = "USP_AddNewAchievements @idStudent , @dateAchived , @achievement ";
            int result = DataProvider.Instance.ExcuteNonQuery(query , new object[] { maHS , date , nd });
            return result > 0;
        }

        //Xóa thành tích
        internal bool DeleteAchieve(string maHS, DateTime date, string nd)
        {
            string query = "DELETE FROM ACHIEVEMENTS WHERE idStudent = '" + maHS + "' AND dateAchived = '" + date + "' AND achievement = N'" + nd + "';";
            int result = DataProvider.Instance.ExcuteNonQuery(query);
            return result > 0;
        }


        //loadStudent
        internal Student LoadStu(string id)
        {
            string query = "select * from STUDENTS where idStudent = '" + id + "'";
            DataTable result = DataProvider.Instance.ExcuteQuery(query);
            Student stu = new Student(result.Rows[0]);
            return stu;
        }


        internal List<Student> LoadClassStudent(string className)
        {
            string query = " select * from STUDENTS where class = N'"+ className + "'";
            DataTable allStudents = DataProvider.Instance.ExcuteQuery(query);
            List<Student> students = new List<Student>();
            foreach (DataRow st in allStudents.Rows)
            {
                Student s = new Student(st);
                students.Add(s);
            }
            return students;
        }


        //Thêm điểm danh
        internal bool AddNewExdend(string id,DateTime date)
        {
            string query = "USP_AddNewAttendences @idStudent , @dateAttendece ";
            int result = DataProvider.Instance.ExcuteNonQuery(query, new object[] { id, date });
            return result > 0;
        }

        //Xóa điểm danh
        internal bool DeleteExdend(string id,DateTime date)
        {
            string query = "Delete from ATTENDANCES where idStudent = '"+id + "' and dateAttend = '"+date+"';";
            int result = DataProvider.Instance.ExcuteNonQuery(query);
            return result > 0;
        }
    }
}