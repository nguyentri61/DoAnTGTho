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
        public List<DateTime> Load_Calender( int id)
        {
           return dAODScongViec.TimNgayBan(id);
        }
        public void Them(CongViec congviec)
        {
            if (congviec.TieuDe != "" && congviec.MoTa != "")
                dAODScongViec.Them(congviec);
            else
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
            } 
                
        }
    }
}
