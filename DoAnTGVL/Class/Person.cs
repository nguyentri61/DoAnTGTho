using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnTGVL.Class
{
    public class Person
    {
        private int id;
        private string hoTen;
        private string cCCD;
        private string sDT;
        private DateTime dob;
        private string khuvuc;

        public Person(int id, string hoTen, string cCCD, string sDT, DateTime dob, string khuvuc)
        {
            this.Id = id;
            this.HoTen = hoTen;
            this.CCCD = cCCD;
            this.SDT = sDT;
            this.Dob = dob;
            this.Khuvuc = khuvuc;
        }

        public string HoTen { get => hoTen; set => hoTen = value; }
        public string CCCD { get => cCCD; set => cCCD = value; }
        public string SDT { get => sDT; set => sDT = value; }
        public DateTime Dob { get => dob; set => dob = value; }
        public int Id { get => id; set => id = value; }
        public string Khuvuc { get => khuvuc; set => khuvuc = value; }
    }
}
