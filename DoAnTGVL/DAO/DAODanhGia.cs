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

        public List<DanhGia> ReadDanhGia(Tho tho)
        {
            string sqlStr = string.Format("Select[User].HoTen,DanhGia.MoTaDanhGia,DanhGia.Image, DSCongViec.DateThue, DanhGia.DanhGia, DSCongViec.LinhVuc, DSCongViec.ChiPhi From DanhGia, DSCongViec, [User] Where DanhGia.IDCongViec=DSCongViec.ID and DSCongViec.IDUser=[User].ID and DSCongViec.IDTho={0}", tho.Id);
            return dbConection.ReadDatabaseDanhGia(sqlStr); 
        }

        public List<DanhGia> ReadDanhGia(Tho tho, FilterDanhGia filterDanhGia)
        {
            
            string sqlStr = string.Format("Select[User].HoTen,DanhGia.MoTaDanhGia,DanhGia.Image, DSCongViec.DateThue, DanhGia.DanhGia, DSCongViec.LinhVuc, DSCongViec.ChiPhi From DanhGia, DSCongViec, [User] Where DanhGia.IDCongViec=DSCongViec.ID and DSCongViec.IDUser=[User].ID and DSCongViec.IDTho={0}", tho.Id);
            string danhgia = filterDanhGia.GetDanhGia();
            if (danhgia != "")
                sqlStr += string.Format(" and DanhGia.DanhGia  = {0}", danhgia);
            if(filterDanhGia.CoAnh ==true)
                sqlStr += string.Format(" and DanhGia.Image  is not null");
            return dbConection.ReadDatabaseDanhGia(sqlStr);
        }
    }
}
