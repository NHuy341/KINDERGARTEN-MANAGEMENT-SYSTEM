using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyTruongMamNon.DT
{
    internal class NotiStaff
    {
        private string idNotication;
        private string idStaff;
        private bool seen;
        public string IdNotication { get => idNotication ; set => idNotication = value; }
        public string IdStaff { get => idStaff; set => idStaff = value; }
        public bool Seen { get => seen ; set => seen = value; }

        public NotiStaff(DataRow row)
        {
            this.idNotication = row["idNotication"].ToString();
            this.idStaff = row["idStaff"].ToString();
            this.seen = Convert.ToBoolean(row["seen"]);
        }
    }
}
