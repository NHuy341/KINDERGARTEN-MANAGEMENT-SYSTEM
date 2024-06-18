using QuanLyTruongMamNon.DT;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyTruongMamNon.DAO
{
    public class MenuDAO
    {
        private static MenuDAO instance;
        public static MenuDAO Instance
        {
            get { if (instance == null) instance = new MenuDAO(); return instance; }
            private set { instance = value; }
        }
        private MenuDAO() { }

        //Them mon an
        internal void AddNewFood(string id , string nameFood , int nutri)
        {
            string query = "INSERT INTO FOODS(idFood , nameFood , nutrition ) VALUES ('" + id + "' , N' " + nameFood + " ' , '" + nutri + "' );";
            DataProvider.Instance.ExcuteNonQuery(query);
        }

        //Xoa mon an
        internal void DeleteFood(string id)
        {
            string query = "Delete from FOODS where idFood = '" + id + "'";
            DataProvider.Instance.ExcuteNonQuery(query);
        }

        //load 
        internal List<Food> getAllFood()
        {
            string query = " select * from FOODS ";
            DataTable allFood = DataProvider.Instance.ExcuteQuery(query);
            List<Food> f = new List<Food>();
            foreach (DataRow st in allFood.Rows)
            {
                Food s = new Food(st);
                f.Add(s);
            }
            return f;
        }
    }
}
