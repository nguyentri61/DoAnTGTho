using DoAnTGVL.Class;
using DoAnTGVL.DAO;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace DoAnTGVL.BUS
{
    public class BUSXacNhanThueTho
    {
        DAODSCongViec dAODScongViec = new DAODSCongViec();
        DAONgayBan dAONgayBan = new DAONgayBan();
        public List<DateTime> Load_Calender( int id)
        {
            List<DateTime> ngaybans = dAODScongViec.TimNgayBan(id);
            ngaybans.AddRange(dAONgayBan.TimNgayBan(id));
            return ngaybans;
        }
        public void Them(CongViec congviec)
        {
            if (congviec.TieuDe != "" && congviec.MoTa != "")
                dAODScongViec.Them(congviec);
            else
            {
                new ShowDialogCustom("Vui lòng nhập đầy đủ thông tin!", ShowDialogCustom.OK).Show();
            } 
                
        }
    }
}
