using DoAnTGVL.Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnTGVL.DAO
{
    
    class DAONgayBan
    {
        DbConection dbConection = new DbConection();

        internal void Them(int id, DateTime selectedDate)
        {
            string query= string.Format("INSERT INTO NgayBan ( IdTho, DateThue) VALUES ({0}, '{1}')"
                    , id,selectedDate.Date);
            dbConection.Process(query);
        }

        internal List<DateTime> TimNgayBan(int id)
        {
            string query = string.Format("Select * From NgayBan Where IdTho = {0}", id);
            return dbConection.ReadDatabaseNgayBan(query);
        }
    }
}
