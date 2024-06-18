using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyTruongMamNon.DT
{
    public class Achievements
    {
        private string idStudent;
        private DateTime dateAchieved;
        private string achievement;

        public string IdStudent { get => idStudent; set => idStudent = value; }
        public DateTime DateAchieved { get => dateAchieved; set => dateAchieved = value; }
        public string Achievement { get => achievement; set => achievement = value; }

        public Achievements(string idStudent, DateTime dateAchieved, string achievement)
        {
            this.IdStudent = idStudent;
            this.DateAchieved = dateAchieved;
            this.Achievement = achievement;
        }

        public Achievements()
        {
        }

        public Achievements(DataRow row)
        {
            this.IdStudent = row["idStudent"].ToString();
            this.DateAchieved = Convert.ToDateTime(row["dateAchived"]);
            this.Achievement = row["achievement"].ToString();
        }
    }
}
