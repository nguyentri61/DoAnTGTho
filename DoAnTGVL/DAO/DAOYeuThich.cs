using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnTGVL.DAO
{
    class DAOYeuThich
    {
        DbConection dbConection =new DbConection();
        public List<int> ReadDBYeuThich(int id)
        {
            string query = string.Format("Select * From YeuThich Where IdUser = {0}", id);
            return dbConection.ReadDatabaseYeuThich(query);
        }

        public void Add(int idTho, int idUser)
        {
            string query = string.Format("Insert into YeuThich Values ({0}, {1})", idUser, idTho);
            dbConection.Process(query);
        }
        public void Remove(int idTho, int idUser)
        {
            string query = string.Format("Delete from YeuThich Where IDUser = {0} and IDTho = {1}", idUser, idTho);
            dbConection.Process(query);
        }
    }
}
