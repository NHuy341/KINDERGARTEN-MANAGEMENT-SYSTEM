using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyTruongMamNon.DT
{
    public class Food
    {
        private string idFood;
        private string nameFood;
        private int nutrition;

        public string IdFood { get => idFood; set => idFood = value; }
        public string NameFood { get => nameFood; set => nameFood = value; }
        public int Nutrition { get => nutrition; set => nutrition = value; }

        public Food(string idFood, string nameFood, int nutrition)
        {
            this.IdFood = idFood;
            this.NameFood = nameFood;
            this.Nutrition = nutrition;
        }

        public Food() { }

        public Food(DataRow row)
        {
            this.IdFood = row["idFood"].ToString();
            this.NameFood = row["nameFood"].ToString();
            this.Nutrition = Convert.ToInt32(row["nutrition"]);
        }
    }
}
