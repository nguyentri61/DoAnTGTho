using DoAnTGVL.Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace DoAnTGVL.DAO
{
    public class DAODanhGia
    {
        DbConection dbConection = new DbConection();
        public void Add(DanhGia danhGia, string image)
        {
           string sqlStr = string.Format("INSERT INTO DanhGia ( IDCongViec, TieuDeCViec, DanhGia, MoTaDanhGia, Image) VALUES ({0}, N'{1}', {2}, N'{3}', N'{4}')",1,danhGia.TieuDeCViec,danhGia.DanhGiaCV,
               danhGia.MoTaDanhGia,image);
           dbConection.Process(sqlStr);
           MessageBox.Show("Thành công"); 
        }
    }
}
