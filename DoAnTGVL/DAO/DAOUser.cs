using DoAnTGVL.Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnTGVL.DAO
{
    public class DAOUser
    {
        DbConection dbConection=new DbConection();
        User user;
        public User ReadDBToSLUser(int id)
        {
            string query = string.Format("Select * From [User] Where Id = {0}", id);
            return dbConection.ReadDatabaseUser(query);
        }
        public void Sua(User user)
        {
            string query = string.Format("Update [User] Set HoTen = N'{0}', CCCD = '{1}', SDT = '{2}', Dob = '{3}', KhuVuc = N'{4}' Where Id={5}",
               user.HoTen, user.CCCD, user.SDT, user.Dob.Date.ToShortDateString(), user.Khuvuc, user.Id);
            dbConection.Process(query);
        }
    }
}
