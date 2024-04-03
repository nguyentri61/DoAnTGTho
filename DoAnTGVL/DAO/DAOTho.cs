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
    }
}
