using DoAnTGVL.Class;
using Microsoft.VisualStudio.Shell.Interop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnTGVL.DAO
{
    class DAOTaiKhoan
    {
        DbConection dbConection = new DbConection();
        public int Checkcheck(TaiKhoan taiKhoan)
        {
            string query = string.Format("Select * TaiKhoan where TaiKhoan.Role = 0 and TaiKhoan='{0}' and Pass='{1}'", taiKhoan.LogName, taiKhoan.Pass);
            return dbConection.Readid(query);

        }
    }
}
