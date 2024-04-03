using DoAnTGVL.Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnTGVL.DAO
{
    class DAOUser
    {
        DbConection dbConection=new DbConection();
        public User ReadDBToSLUser(int id)
        {
            string query = string.Format("Select * From [User] Where Id = {0}", id);
            return dbConection.ReadDatabaseUser(query);
        }
    }
}
