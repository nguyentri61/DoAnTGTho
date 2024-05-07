using DoAnTGVL.Class;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Documents;
using System.Windows.Media.Converters;

namespace DoAnTGVL.DAO
{
    
    public class DAOTho

    {
        DbConection dbConection =new DbConection();
        public List<Tho> ReadAllTho()
        {        
            string query = "Select * From Tho";
            return dbConection.ReadDatabase(query);
        }
        public List<Tho> FilterTho(FilterTho filterTho, int userId)
        {
            string query = "Select * From Tho";
            bool exist = false;
            if (!filterTho.checkemp()) {
                if(filterTho.YeuThich) 
                {
                    query += string.Format(", YeuThich Where Id=IDTho and IDUser = {0}",userId); 
                    exist = true;
                }
                else
                {
                    query += " Where"; 
                }
                if (filterTho.KhuVuc != "")
                {
                    if (exist)
                        query += " and";
                    query += string.Format(" KhuVuc = N'{0}'", filterTho.KhuVuc);
                    exist = true;
                }
                if (filterTho.KinhNghiem !="")
                {
                    if (exist)
                        query += " and";
                    query += string.Format(" KinhNghiem = N'{0}'", filterTho.KinhNghiem);
                    exist = true;
                }
                if (filterTho.DanhGia != 0)
                {
                    if (exist)
                        query += " and";
                    query += string.Format(" DanhGia  >= {0}", filterTho.DanhGia);
                    exist = true;
                }
                if (filterTho.ChuyenMon !="")
                {
                    if (exist)
                        query += " and";
                    query += string.Format(" ChuyenMon = N'{0}'", filterTho.ChuyenMon);
                    exist = true;
                } 
                if (filterTho.Ten !="")
                {
                    if (exist)
                        query += " and";
                    query += string.Format(" HoTen like N'%{0}%'", filterTho.Ten);
                }
                if (filterTho.Giatien != "")
                {
                    
                    if (exist)
                        query += " and";
                    query += string.Format(" GiaTien{0}", filterTho.chuyenDoiGiaTien());
                }
            }
            return dbConection.ReadDatabase(query);
        }
        public Tho ReadDBToSLTho(int id)
        {
            string query = string.Format("Select * From Tho Where Id = {0}", id);
            return dbConection.ReadDatabaseTho(query);
        }

        internal void UpDateDG(List<float> danhGiaTho)
        {
            string sql = string.Format("Update Tho Set DanhGia={0} Where Id={1}", danhGiaTho[0], danhGiaTho[1]);
            dbConection.Process(sql);
        }

        public void Sua(Tho tho)
        {
            string query = string.Format("Update Tho Set HoTen = N'{0}', CCCD = '{1}', SDT = '{2}', Dob = '{3}', KhuVuc = N'{4}', LinhVuc = N'{5}', ChuyenMon = N'{6}', KinhNghiem = N'{7}', GiaTien = {8}  Where Id={9}", 
                tho.HoTen, tho.CCCD, tho.SDT, tho.Dob.Date.ToShortDateString(), tho.Khuvuc, tho.LinhVuc, tho.ChuyenMon, tho.KinhNghiem, tho.GiaTien, tho.Id);
            dbConection.Process(query);
        }

    }
}
