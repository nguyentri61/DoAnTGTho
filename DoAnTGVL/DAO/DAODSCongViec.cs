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
            MessageBox.Show("Thuê thành công");
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
            string sqlString = string.Format("INSERT INTO DSCongViec ( IDTho, IDUser, TieuDe, MoTa, GhiChu,LinhVuc, KhuVuc, DateThue, TrangThai) VALUES ({0}, {1}, N'{2}', N'{3}',N'{4}',N'{5}',N'{6}','{7}', N'{8}')", tho.Id, baiDang.IDUser,
              baiDang.TieuDe, baiDang.MoTa, baiDang.GhiChu,baiDang.LinhVuc, baiDang.KhuVuc, baiDang.DateThue, "Chưa thực hiện");
            dbConection.Process(sqlString);
            MessageBox.Show("Nhận việc thành công"); 
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

        public List<CongViec> ReadAllDSThueTho(int id)
        {
            string query = string.Format("Select * From DSCongViec Where IDUser = {0}", id);
            return dbConection.ReadDatabaseCongViec(query);
        }

        public List<CongViec> FilterCongViec(FilterDSCongViec filterDSCongViec, string idrole ,int id)
        {
            string query = string.Format("Select * From DSCongViec Where {0} = {1} ", idrole, id);
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
    }
}
