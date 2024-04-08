using DoAnTGVL.Class;
using DoAnTGVL.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace DoAnTGVL.BUS
{
    class BUSDangNhap
    {
        TaiKhoan taikhoan;
        public Window Login(TaiKhoan taiKhoan)
        {
            this.taikhoan = taiKhoan;
            if(!taikhoan.Role)
            {
                Dao
                DAOUser daouser = new DAOUser();
                DAOYeuThich dAOYeuThich = new DAOYeuThich();
                User user=daouser.ReadDBToSLUser(id);
                
                user.DSYeuThich=dAOYeuThich.ReadDBYeuThich(id);
                return new UserMain(user);
            }
            Tho tho = new Tho(1, "Nguyễn Ngọc Hoàng", "099900134386", "08765678542", DateTime.Today, "Quận 1", "Điện lạnh", "Sửa máy lạnh", "1 - 2 năm", 500000, 4);
            return new ThoMain(tho);
        }
    }
}
