using DoAnTGVL.Class;
using Microsoft.VisualStudio.Shell.Interop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace DoAnTGVL.DAO
{
    class DAOTaiKhoan
    {
        DbConection dbConection = new DbConection();
        public int CheckAcc(TaiKhoan taiKhoan)
        {
            string query = string.Format("Select * from TaiKhoan where Role = {0} and Logname='{1}' and Pass='{2}'",taiKhoan.Role, taiKhoan.LogName, taiKhoan.Pass);
            return dbConection.ReadId(query);

        }
    }
}
