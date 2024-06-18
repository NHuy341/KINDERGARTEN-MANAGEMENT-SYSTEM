using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyTruongMamNon.DT
{
    public class Noti
    {
        private string idNotication;
        private DateTime dateNoti;
        private string title;
        private string description;
        public string IdNotication { get => idNotication; set => idNotication = value; }
        public DateTime DateNoti { get => dateNoti; set => dateNoti = value; }
        public string Title { get => title; set => title = value; }
        public string Description { get => description; set => description = value; }


        public Noti(DataRow row)
        {
            this.idNotication = row["idNotication"].ToString();
            this.dateNoti = Convert.ToDateTime(row["dateNotication"]);
            this.title = row["title"].ToString();
            this.description = row["content"].ToString();
        }
    }
}
