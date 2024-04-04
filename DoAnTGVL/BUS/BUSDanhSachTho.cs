using DoAnTGVL.Class;
using DoAnTGVL.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnTGVL.BUS
{
    public class BUSDanhSachTho
    {
        public void ThemXoaDSYeuThich(Tho tho, User user)
        {
            DAOYeuThich dAOYeuThich = new DAOYeuThich();
            if(tho.DcYeuThich)
            {
                dAOYeuThich.Add(tho.Id, user.Id);
                user.DSYeuThich.Add(tho.Id);
            }
            else
            {
                dAOYeuThich.Remove(tho.Id, user.Id);
                user.DSYeuThich.Remove(tho.Id);
            }
        }


    }
}
