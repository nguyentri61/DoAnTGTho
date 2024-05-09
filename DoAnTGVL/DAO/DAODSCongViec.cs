using DoAnTGVL.Class;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data;
using System.DirectoryServices.ActiveDirectory;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using static System.Net.Mime.MediaTypeNames;


namespace DoAnTGVL.DAO
{
    public class DAODSCongViec
    {
        DbConection dbConection = new DbConection();
        public List<DateTime> TimNgayBan(int idTho)
        {
            string query = string.Format("Select * From DSCongViec Where IDTho = {0}",idTho);
            return dbConection.ReadDatabaseNgayBan(query);
        }
        public void Them(CongViec congViec)
        {

            string sqlString = string.Format("INSERT INTO DSCongViec ( IDTho, IDUser, TieuDe, MoTa, GhiChu,LinhVuc, KhuVuc, DateThue, TrangThai) VALUES ({0}, {1}, N'{2}', N'{3}',N'{4}',N'{5}',N'{6}','{7}', N'{8}')", congViec.IDTho, congViec.IDUser,
                congViec.TieuDe, congViec.MoTa,congViec.GhiChu ,congViec.LinhVuc,congViec.KhuVuc ,congViec.DateThue, congViec.TrangThai);
            dbConection.Process(sqlString);
            new ShowDialogCustom("Thuê thành công", ShowDialogCustom.OK).ShowDialog();
        }

        public void XoaDSCongViec(int textid)
        {
            string sqlStr = string.Format("DELETE FROM DSCongViec WHERE ID = '{0}'", textid);
            dbConection.Process(sqlStr);
        }

        public void SuaDSCongViec(CongViec cv, Tho tho)
        {
            string sqlStr = string.Format("UPDATE DSCongViec SET TrangThai = N'{0}' WHERE ID = '{1}' and IDTho = '{2}'"
                    , cv.TrangThai, cv.ID, tho.Id);
            dbConection.Process(sqlStr);
        }
        public void ThoThem(BaiDang baiDang, Tho tho)
        {
            string sqlString = string.Format("INSERT INTO DSCongViec ( IDTho, IDUser, TieuDe, MoTa, GhiChu,LinhVuc, KhuVuc, DateThue, TrangThai, IDBaiDang) VALUES ({0}, {1}, N'{2}', N'{3}',N'{4}',N'{5}',N'{6}','{7}', N'{8}',{9})", tho.Id, baiDang.IDUser,
              baiDang.TieuDe, baiDang.MoTa, baiDang.GhiChu,baiDang.LinhVuc, baiDang.KhuVuc, baiDang.DateThue, "Chờ được duyệt",baiDang.ID);
            dbConection.Process(sqlString);
            new ShowDialogCustom("Nhận việc thành công", ShowDialogCustom.OK).ShowDialog();
        }
        public bool CheckNgayBan(DateTime date, int idTho)
        {
            string queryString = string.Format("SELECT * FROM DSCongViec WHERE DateThue = '{0}' and IDTho = {1}", date, idTho);
            return dbConection.CheckExist(queryString);
        }

        public List<CongViec> ReadAllCongViec(int id)
        {
            string query =string.Format("Select * From DSCongViec Where IDTho = {0}", id);
            return dbConection.ReadDatabaseCongViec(query);
        }

        public List<CongViec> ReadAllLichSuCongViec(int id, string trangthai)
        {
            string query = string.Format("Select * From DSCongViec Where IDTho = {0} and TrangThai = N'{1}'", id, trangthai);
            return dbConection.ReadDatabaseCongViec(query);
        }

        public List<CongViec> ReadAllDSThueTho(int id, string trangthai)
        {
            string query = string.Format("Select * From DSCongViec Where IDUser = {0} and TrangThai = N'{1}'", id, trangthai);
            return dbConection.ReadDatabaseCongViec(query);
        }

        public List<CongViec> FilterCongViecDaHoanThanh(FilterDSCongViec filterDSCongViec, int id)
        {
            string query = string.Format("Select * From DSCongViec Where IDTho = {0} and TrangThai = N'Đã hoàn thành'", id);
            if (filterDSCongViec.TieuDe != "")
            {
                query += string.Format(" AND TieuDe like N'%{0}%'", filterDSCongViec.TieuDe);
            }
            return dbConection.ReadDatabaseCongViec(query);
        }


        public List<CongViec> FilterCongViec(FilterDSCongViec filterDSCongViec, int id)
        {
            string query = string.Format("Select * From DSCongViec Where IDTho = {0}", id);
            bool conditionAppended = false;
            if (!filterDSCongViec.checkemp())
            {
                if (filterDSCongViec.ChuaThucHien)
                {
                    if (!conditionAppended)
                    {
                        query += " AND (";
                        conditionAppended = true;
                    }
                    else
                    {
                        query += " OR ";
                    }
                    query += string.Format("TrangThai = N'Chưa thực hiện'");
                }

                if (filterDSCongViec.DangThucHien)
                {
                    if (!conditionAppended)
                    {
                        query += " AND (";
                        conditionAppended = true;
                    }
                    else
                    {
                        query += " OR ";
                    }
                    query += string.Format("TrangThai = N'Đang thực hiện'");
                }

                if (filterDSCongViec.DaHoanThanh)
                {
                    if (!conditionAppended)
                    {
                        query += " AND (";
                        conditionAppended = true;
                    }
                    else
                    {
                        query += " OR ";
                    }
                    query += string.Format("TrangThai = N'Đã hoàn thành'");
                }

                if (conditionAppended)
                {
                    query += ")";
                }

                if (filterDSCongViec.TieuDe != "")
                {
                    query += string.Format(" AND TieuDe like N'%{0}%'", filterDSCongViec.TieuDe);
                }
            }
            return dbConection.ReadDatabaseCongViec(query);
        }

        public void Add(CongViec congviec, string image)
        {
            string query = string.Format("UPDATE DSCongViec  SET ChiTietSua = N'{0}', ChiPhi = {1}, Image = '{2}' WHERE ID={3}", congviec.ChiTietSua, congviec.ChiPhi, image, congviec.ID);
            dbConection.Process(query);
        }

        public List<CongViec> ReadAllDSCongViec(int id, string trangthai)
        {
            string query = string.Format("Select * From DSCongViec Where IDTho = {0} and TrangThai = N'{1}'", id, trangthai);
            return dbConection.ReadDatabaseCongViec(query);
        }

        internal void XoaTheoBaiDang(CongViec congviec)
        {
            string sqlStr = string.Format("DELETE FROM DSCongViec WHERE IDBaiDang = '{0}' and TrangThai = 'Chờ được duyệt'", congviec.IDBaiDang);
            dbConection.Process(sqlStr);
        }

        internal int CountCV(Tho tho,string thang, string trangthai)
        {
            string query = string.Format("SELECT COUNT(*) as DemCV FROM DSCongViec Where IDTho = {0} and TrangThai = N'{1}' and MONTH(DateThue)={2}", tho.Id, trangthai, thang);
            return dbConection.CountCongViec(query);
        }

        internal List<int> GetThuNhap(Tho tho)
        {
            string query = string.Format("SELECT SUM(ChiPhi) AS TongChiPhi, MONTH(DateThue) AS Thang FROM DSCongViec WHERE IDTho = {0} GROUP BY MONTH(DateThue)", tho.Id);
            return dbConection.GetThuNhap(query);
        }
    }
}
