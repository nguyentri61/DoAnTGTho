using DoAnTGVL.Class;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace DoAnTGVL.DAO
{
    class DAOBaiDang
    {
        DbConection dbConection = new DbConection();
        public List<BaiDang> ReadAllBaiDang()
        {
            string query = "Select * From BaiDang";
            return dbConection.ReadDatabaseBaiDang(query);
        }

        public void Them(BaiDang baidang,User user)
        {
            string sqlStr = string.Format("INSERT INTO BaiDang ( IDUser, TieuDe, LinhVuc, KhuVuc, MoTa, Date, KinhNghiem, YeuCau, GhiChu) VALUES ({0}, N'{1}', N'{2}', N'{3}', '{4}', N'{5}', N'{6}', N'{7}', N'{8}')"
                    , user.Id, baidang.TieuDe, baidang.LinhVuc, baidang.KhuVuc, baidang.MoTa, baidang.DateThue.Date.ToShortDateString(), baidang.KinhNghiem, baidang.YeuCau, baidang.GhiChu);
            dbConection.Process(sqlStr);
        }
        public List<BaiDang> FilterBaiDang(FilterBaiDang filterBaiDang, Tho tho)
        {
            string query = "Select * From BaiDang";
            bool exist = false;
            if (!filterBaiDang.checkemp())
            {
                query += " Where";
                if (filterBaiDang.KhuVuc != "")
                {
                    query += string.Format(" KhuVuc = N'{0}'", filterBaiDang.KhuVuc);
                    exist = true;
                }
                if (filterBaiDang.KinhNghiem != "")
                {
                    if (exist)
                        query += " and";
                    query += string.Format(" KinhNghiem = N'{0}'", filterBaiDang.KinhNghiem);
                    exist = true;
                }

                if (filterBaiDang.Ten != "")
                {
                    if (exist)
                        query += " and";
                    query += string.Format(" TieuDe like N'%{0}%'", filterBaiDang.Ten);
                }
            }
            query += string.Format(" ORDER BY (CASE WHEN LinhVuc = N'{0}' THEN 0 ELSE 1 END), LinhVuc", tho.LinhVuc);
            return dbConection.ReadDatabaseBaiDang(query);
        }

        public void XoaBaiDang(int ID)
        {
            string query =string.Format( "Delete  From BaiDang Where ID = {0}",ID);
            dbConection.Process(query);
        }
    }
}
