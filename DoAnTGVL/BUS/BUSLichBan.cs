using DoAnTGVL.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace DoAnTGVL.BUS
{
    public class BUSLichBan
    {
        DAODSCongViec dAODScongViec = new DAODSCongViec();
        DAONgayBan dAONgayBan = new DAONgayBan();
        internal List<DateTime> Load_Calender(int id)
        {
            List<DateTime> ngaybans = dAODScongViec.TimNgayBan(id);
            ngaybans.AddRange(dAONgayBan.TimNgayBan(id));
            return ngaybans;    
        }

        internal void Them(int id, DateTime? selectedDate)
        {
            if (selectedDate != null)
            {
                dAONgayBan.Them(id, (DateTime)selectedDate);
                new ShowDialogCustom("Đã cập nhật lịch trình", ShowDialogCustom.OK).Show();

            }
            else
                new ShowDialogCustom("Vui lòng chọn ngày!", ShowDialogCustom.OK).Show();
        }
    }
}
