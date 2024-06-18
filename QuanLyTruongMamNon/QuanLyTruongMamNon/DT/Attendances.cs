using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyTruongMamNon.DT
{
    public class Attendances
    {
        private string idStudent;
        private DateTime dateAttend;

        public string IdStudent { get => idStudent; set => idStudent = value; }
        public DateTime DateAttend { get => dateAttend; set => dateAttend = value; }

        public Attendances(string idStudent, DateTime dateAttend)
        {
            this.IdStudent = idStudent;
            this.DateAttend = dateAttend;
        }

        public Attendances()
        {
        }

        public Attendances(DataRow row)
        {
            this.IdStudent = row["idStudent"].ToString();
            this.DateAttend = Convert.ToDateTime(row["dateAttend"]);
        }
    }
}
