using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnTGVL.Class
{
    public class User : Person
    {
        private List <int> dSYeuThich=new List<int>();
        public User(int id, string hoTen, string cCCD, string sDT, DateTime dob, string khuvuc) : base(id, hoTen, cCCD, sDT, dob, khuvuc)
        {
        }

        public List<int> DSYeuThich { get => dSYeuThich; set => dSYeuThich = value; }
    }
}
