using QuanLyTruongMamNon.DT;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace QuanLyTruongMamNon.DAO
{
    public class SevicesDAO
    {
        private static SevicesDAO instance;
        public static SevicesDAO Instance
        {
            get { if (instance == null) instance = new SevicesDAO(); return instance; }
            private set { instance = value; }
        }

        //them Thông báo
        internal void Notifications(string id , DateTime date , string tiltes , string cont)
        {
            string query = "INSERT INTO NOTICATION (idNotication , dateNotication , title , content ) VALUES ('" + id + "' , ' " + date + " ' , N'" + tiltes + " ' , N'" + cont + "' );";
            DataProvider.Instance.ExcuteNonQuery(query);
        }
        //lay thong bao
        internal List<Noti> getAllNoti()
        {
            string query = " select * from NOTICATION";
            DataTable allNoti = DataProvider.Instance.ExcuteQuery(query);
            List<Noti> noti = new List<Noti>();
            foreach (DataRow st in allNoti.Rows)
            {
                Noti s = new Noti(st);
                noti.Add(s);
            }
            return noti;
        }
        //Xóa thông báo
        internal void DeleteNoti(string id)
        {
            string query = "Delete from NOTICATION  where idNotication =  '"+ id +"'";
            DataProvider.Instance.ExcuteNonQuery(query);
        }

        //tải danh sách học sinh
        internal Student loadStudent(string id)
        {
            string query = "select * from STUDENTS where idStudent = '" + id + "'";
            DataTable result = DataProvider.Instance.ExcuteQuery(query);
            Student stu = new Student(result.Rows[0]);
            return stu;
        }

        //chỉnh seen
        internal bool ChangeSeen(string idNoti , string idStaffs)
        {
            string query = "USP_UpdateSeenStatus @idNoti , @idStaff";
            int result = DataProvider.Instance.ExcuteNonQuery(query , new object[] { idNoti , idStaffs });
            return result > 0;
        }

        //Them Chi ngan sach
        internal void Expend(string id , string ngNhan , string diaChi , string lyDo , string chi , int tien)
        {
            string query1 = "INSERT INTO TRANSACTIONS(idTransaction , classify , amountMoney) VALUES ('" + id + "' , ' " + chi + " ' , N'" + tien + "' );";
            DataProvider.Instance.ExcuteNonQuery(query1);
            string query = "INSERT INTO EXPENSES(idTransaction , receiver , addressReceiver , reason) VALUES ('" + id + "' , ' " + ngNhan + " ' , N'" + diaChi + " ' , N'" + lyDo + "' );";
            DataProvider.Instance.ExcuteNonQuery (query);
        }

        //Them Thu hoc phi
        internal void Fee(string id, string maHS, bool collect, string thu, int tien)
        {
            string query1 = "INSERT INTO TRANSACTIONS(idTransaction , classify , amountMoney) VALUES ('" + id + "' , ' " + thu + " ' , N'" + tien + "' );";
            DataProvider.Instance.ExcuteNonQuery(query1);
            string query = "INSERT INTO FEES(idTransaction , idStudent , collected) VALUES ('" + id + "' , '" + maHS + "' , N'" + collect + "' );";
            DataProvider.Instance.ExcuteNonQuery(query);
        }

        //Them dich vu
        internal void Services(string id , string maHS , string dichvu , int tien , int soLuong , bool hk1 , bool hk2 , bool health , bool accident)
        {
            string query1 = "INSERT INTO TRANSACTIONS(idTransaction , classify , amountMoney) VALUES ('" + id + "' , ' " + dichvu + " ' , '" + tien + "' );";
            DataProvider.Instance.ExcuteNonQuery(query1);
            string query = "INSERT INTO SERVICES(idTransaction , idStudent , uniform , lunch1 , lunch2 , healthnsurance , accidentinsurance) VALUES ('" + id + "' , '" + maHS + "' , '" + soLuong + "' , ' " + hk1 + " ' , '" + hk2 + " ' , '"  + health + " ' , '" + accident + "' );";
            DataProvider.Instance.ExcuteNonQuery(query);
        }

        //Điểm danh
        internal List<Attendances> getAllAttendance()
        {
            string query = " select * from ATTENDANCES ";
            DataTable allatten = DataProvider.Instance.ExcuteQuery(query);
            List<Attendances> att = new List<Attendances>();
            foreach (DataRow st in allatten.Rows)
            {
                Attendances s = new Attendances(st);
                att.Add(s);
            }
            return att;
        }

        //Thành tích
        internal List<Achievements> getAllAchive()
        {
            string query = " select * from ACHIEVEMENTS ";
            DataTable allAchie = DataProvider.Instance.ExcuteQuery(query);
            List<Achievements> achi = new List<Achievements>();
            foreach (DataRow st in allAchie.Rows)
            {
                Achievements s = new Achievements(st);
                achi.Add(s);
            }
            return achi;
        }

        //thong bao xem hoac khong
        internal List<NotiStaff> getAllNotiStaf(bool check)
        {
            Account sta = AccountDAO.Instance.loadStaff1();
            string idSt = sta.IdStaff;
            string query = " select * from NOTICATION_STAFF where seen = '"+check+ "'and idStaff = '" + idSt +"';";
            DataTable allNotiSt = DataProvider.Instance.ExcuteQuery(query);
            List<NotiStaff> notiSt = new List<NotiStaff>();
            foreach (DataRow st in allNotiSt.Rows)
            {
                NotiStaff s = new NotiStaff(st);
                notiSt.Add(s);
            }
            return notiSt;
        }

        internal List<Noti> getAllNoti(string id)
        {
            string query = " select * from NOTICATION where idNotication ='"+id+"';";
            DataTable allNoti = DataProvider.Instance.ExcuteQuery(query);
            List<Noti> noti = new List<Noti>();
            foreach (DataRow st in allNoti.Rows)
            {
                Noti s = new Noti(st);
                noti.Add(s);
            }
            return noti;
        }
    }
}
