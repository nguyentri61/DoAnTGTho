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
        public void Add(DanhGia danhGia,int idCV, string image)
        {
           string sqlStr = string.Format("INSERT INTO DanhGia ( IDCongViec, TieuDeCViec, DanhGia, MoTaDanhGia, Image) VALUES ({0}, N'{1}', {2}, N'{3}', N'{4}')",idCV,danhGia.TieuDeCViec,danhGia.DanhGiaCV,
               danhGia.MoTaDanhGia,image);
           dbConection.Process(sqlStr);
            new ShowDialogCustom("Thành công", ShowDialogCustom.OK).Show();
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
            if(filterDanhGia.CoAnh == true)
                sqlStr += string.Format(" and DanhGia.Image  !=''");
            return dbConection.ReadDatabaseDanhGia(sqlStr);
        }

        internal List<float> ReadSao(int idCV)
        {
            string sqlStr = string.Format("(select sum(DanhGia.DanhGia) as Tong,COUNT(DanhGia.DanhGia) as SLuong, Tho.Id from Tho,DanhGia, DSCongViec where  DSCongViec.ID={0} and DSCongViec.IDTho = Tho.Id group by Tho.Id) ", idCV);
            return dbConection.ReadSaoDatabase(sqlStr);
        }
    }
}
