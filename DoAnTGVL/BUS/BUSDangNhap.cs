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
        DAOTaiKhoan dAOTaiKhoan=new DAOTaiKhoan();
        
        public Window Login(TaiKhoan taiKhoan)
        {
            this.taikhoan = taiKhoan;
            if (taiKhoan.CheckEmpty())
            {
                int id = dAOTaiKhoan.CheckAcc(taiKhoan);
                if (id != 0)
                {
                    if (taikhoan.Role == 0)
                    {
                        DAOUser daouser = new DAOUser();
                        DAOYeuThich dAOYeuThich = new DAOYeuThich();
                        User user = daouser.ReadDBToSLUser(id);
                        user.DSYeuThich = dAOYeuThich.ReadDBYeuThich(id);
                        return new UserMain(user);
                    }
                    else
                    {
                        DAOTho dAOtho = new DAOTho();
                        Tho tho = dAOtho.ReadDBToSLTho(id);
                        return new ThoMain(tho);
                    }
                }
                else
                {
                    new ShowDialogCustom("Sai tài khoản, vui lòng nhập lại", ShowDialogCustom.OK).Show();
                    return null;
                }
            }
            else
            {
                new ShowDialogCustom("Vui lòng nhập đầy đủ!", ShowDialogCustom.OK).Show();
                return null;
            }
        }
    }
}
