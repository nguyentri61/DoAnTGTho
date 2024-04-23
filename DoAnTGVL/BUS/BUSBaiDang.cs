using DoAnTGVL.Class;
using DoAnTGVL.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnTGVL.BUS
{
    public class BUSBaiDang
    {
        DAOBaiDang daobaidang = new DAOBaiDang();
        public void XoaBaiDang(BaiDang baidang)
        {
            daobaidang.XoaBaiDang(baidang.ID);
        }

        public void SuaBaiDang(BaiDang baidang)
        {
            daobaidang.SuaBaiDang(baidang);
        }
    }
}
