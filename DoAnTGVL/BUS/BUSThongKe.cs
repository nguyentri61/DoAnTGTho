using DoAnTGVL.Class;
using DoAnTGVL.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnTGVL.BUS
{
    internal class BUSThongKe
    {
        DAODSCongViec dAODSCongViec=new DAODSCongViec();
        internal List<int>? GetCongViec(Tho tho, string thang)
        {
            List<int >? list = new List<int>();
            list.Add(dAODSCongViec.CountCV(tho, thang, "Chưa thực hiện"));
            list.Add(dAODSCongViec.CountCV(tho, thang, "Đang thực hiện"));
            list.Add(dAODSCongViec.CountCV(tho, thang, "Đã hoàn thành"));
            return list;
        }

        internal List<int> GetThuNhap(Tho tho)
        {
            return dAODSCongViec.GetThuNhap(tho);

        }
    }
}
