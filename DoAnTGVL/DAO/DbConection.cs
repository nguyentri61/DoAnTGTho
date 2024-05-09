using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Data;
using System.Data.SqlClient;
using DoAnTGVL.Class;
using System.Collections;
using System.Reflection.PortableExecutable;
using System.Windows.Markup;
using System.Linq;
using Microsoft.VisualStudio.Shell.Interop;
using System.Windows.Media.Media3D;

namespace DoAnTGVL.DAO
{
    internal class DbConection
    {
        SqlConnection conn = new SqlConnection(Properties.Settings.Default.connstring);
        public void Process(string sql)
        {
            try
            {
                conn.Open();
                string sqlStr = string.Format(sql);
                SqlCommand cmd = new SqlCommand(sqlStr, conn);
                cmd.ExecuteNonQuery();
                    
            }
            catch (Exception ex)
            {
                MessageBox.Show("That bai" + ex);
            }
            finally
            {
                conn.Close();
            }
        }

        public DataTable Update(string sqlStr)
        {
            try
            {
                conn.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(sqlStr, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                return dt;
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
            finally
            {
                conn.Close();
            }
            return null;
        }

        public List<Tho> ReadDatabase(string query)
        {
            SqlConnection conn = new SqlConnection(Properties.Settings.Default.connstring);
            List<Tho> DStho = new List<Tho>();
            using (conn)
            {
                SqlCommand command = new SqlCommand(query, conn);
                try
                {
                    conn.Open();
                    SqlDataReader dataReader = command.ExecuteReader();

                    while (dataReader.Read())
                    {
                        Tho tho = 
                            new Tho(id: (int)dataReader["Id"],
                            hoTen: dataReader["HoTen"].ToString(),
                            cCCD: dataReader["CCCD"].ToString(),
                            sDT: dataReader["SDT"].ToString(),
                            dob: (DateTime)dataReader["Dob"],
                            khuvuc: dataReader["KhuVuc"].ToString(),
                            linhVuc: dataReader["LinhVuc"].ToString(),
                            chuyenmon: dataReader["ChuyenMon"].ToString(),
                            kinhNghiem: dataReader["KinhNghiem"].ToString(),
                            giaTien: (int)dataReader["GiaTien"],
                            danhgia: Convert.ToSingle(dataReader["DanhGia"])
                            );
                        DStho.Add(tho);
                    }
                    dataReader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            return DStho;
        }

        public List<BaiDang> ReadDatabaseBaiDang(string query)
        {
            SqlConnection conn = new SqlConnection(Properties.Settings.Default.connstring);
            List<BaiDang> DSbaidang = new List<BaiDang>();
            using (conn)
            {
                SqlCommand command = new SqlCommand(query, conn);
                try
                {
                    conn.Open();
                    SqlDataReader dataReader = command.ExecuteReader();

                    while (dataReader.Read())
                    {
                        BaiDang baidang =
                            new BaiDang(
                            iD: (int)dataReader["Id"],
                            iDUser: dataReader["IDUser"].ToString(),
                            tieuDe: dataReader["TieuDe"].ToString(),
                            linhVuc: dataReader["LinhVuc"].ToString(),
                            khuVuc: dataReader["KhuVuc"].ToString(),
                            moTa: dataReader["MoTa"].ToString(),
                            date: (DateTime)dataReader["Date"],
                            kinhNghiem: dataReader["KinhNghiem"].ToString(),
                            yeuCau: dataReader["YeuCau"].ToString(),
                            ghiChu: dataReader["GhiChu"].ToString());       
                        DSbaidang.Add(baidang);
                    }
                    dataReader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            return DSbaidang;
        }
        public List<DateTime> ReadDatabaseNgayBan(string query)
        {
            SqlConnection conn = new SqlConnection(Properties.Settings.Default.connstring);
            List<DateTime> NgayBan = new List<DateTime>();
            using (conn)
            {
                SqlCommand command = new SqlCommand(query, conn);
                try
                {
                    conn.Open();
                    SqlDataReader dataReader = command.ExecuteReader();

                    while (dataReader.Read())
                    {
                        DateTime tenp = (DateTime)dataReader["DateThue"];

                        NgayBan.Add(tenp);

                    }
                    dataReader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            return NgayBan;
        }
        public bool CheckExist(string query)
        {
            SqlConnection conn = new SqlConnection(Properties.Settings.Default.connstring);            
            using (conn)
            {
                SqlCommand command = new SqlCommand(query, conn);
                conn.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
        }

        public List<CongViec> ReadDatabaseCongViec(string query)
        {
            SqlConnection conn = new SqlConnection(Properties.Settings.Default.connstring);
            List<CongViec> DSCongViec = new List<CongViec>();
            using (conn)
            {
                SqlCommand command = new SqlCommand(query, conn);
                try
                {
                    conn.Open();
                    SqlDataReader dataReader = command.ExecuteReader();

                    while (dataReader.Read())
                    {
                        CongViec data = new CongViec();                        
                        data.ID = dataReader.GetInt32("ID");
                        
                        data.IDUser = dataReader.GetInt32("IDUser");
                        data.IDTho = dataReader.GetInt32("IDTho");
                        data.TieuDe = dataReader["TieuDe"].ToString();
                        data.MoTa = dataReader["MoTa"].ToString();
                        data.LinhVuc = dataReader["LinhVuc"].ToString();
                        data.KhuVuc = dataReader["KhuVuc"].ToString();
                        data.DateThue = (DateTime)dataReader["DateThue"];
                        data.TrangThai = dataReader[9].ToString(); 
                        data.ChiTietSua = dataReader["ChiTietSua"].ToString(); 
                        data.ChiPhi = dataReader.GetInt32("ChiPhi");
                        data.GetSource(dataReader["Image"].ToString());
                        data.IDBaiDang= dataReader.GetInt32("IDBaiDang");
                        DSCongViec.Add(data);

                    }
                    dataReader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                  
                }
            }
            return DSCongViec;
        }

        public User ReadDatabaseUser(string query)
        {
            SqlConnection conn = new SqlConnection(Properties.Settings.Default.connstring);
            User user = null;
            using (conn)
            {
                SqlCommand command = new SqlCommand(query, conn);
                try
                {
                    conn.Open();
                    SqlDataReader dataReader = command.ExecuteReader();

                    while (dataReader.Read())
                    {
                        user = new(id:dataReader.GetInt32("ID"),
                           hoTen: dataReader["HoTen"].ToString(), 
                           cCCD: dataReader["CCCD"].ToString(), 
                           sDT:dataReader["SDT"].ToString(),
                           dob:(DateTime)dataReader["Dob"],
                           khuvuc:dataReader["KhuVuc"].ToString());

                    }
                    dataReader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            return user;
        }

        public List<int> ReadDatabaseYeuThich(string query)
        {
            SqlConnection conn = new SqlConnection(Properties.Settings.Default.connstring);
            List<int> DSYeuThich = new List<int>();
            using (conn)
            {
                SqlCommand command = new SqlCommand(query, conn);
                try
                {
                    conn.Open();
                    SqlDataReader dataReader = command.ExecuteReader();

                    while (dataReader.Read())
                    {
                        DSYeuThich.Add((int)dataReader["IDTho"]);
                    }
                    dataReader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            return DSYeuThich;
        }

        public List<DanhGia> ReadDatabaseDanhGia(string sqlStr)
        {
            SqlConnection conn = new SqlConnection(Properties.Settings.Default.connstring);
            List<DanhGia> DSDanhGia = new List<DanhGia>();
            using (conn)
            {
                SqlCommand command = new SqlCommand(sqlStr, conn);
                try
                {
                    conn.Open();
                    SqlDataReader dataReader = command.ExecuteReader();

                    while (dataReader.Read())
                    {
                        DanhGia temp =new DanhGia();
                        temp.TenUser = dataReader["HoTen"].ToString(); 
                        temp.MoTaDanhGia= dataReader["MoTaDanhGia"].ToString();
                        temp.GetSource(dataReader["Image"].ToString());
                        temp.NgayThue= dataReader.GetDateTime("DateThue");
                        temp.DanhGiaCV= dataReader.GetInt32("DanhGia");
                        temp.LinhVuc = dataReader["LinhVuc"].ToString();
                        temp.GiaThue = dataReader.GetInt32("ChiPhi"); 
                        DSDanhGia.Add(temp);
                    }
                    dataReader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            return DSDanhGia;
        }

        public int ReadId(string sqlStr)
        {
            SqlConnection conn = new SqlConnection(Properties.Settings.Default.connstring);
            int Id = 0;
            using (conn)
            {
                SqlCommand command = new SqlCommand(sqlStr, conn);
                try
                {
                    conn.Open();
                    SqlDataReader dataReader = command.ExecuteReader();

                    while (dataReader.Read())
                    {
                        Id = (int)dataReader["ID"];
                        return Id;
                    }
                    dataReader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            return Id;
        }

        public Tho ReadDatabaseTho(string query)
        {
            SqlConnection conn = new SqlConnection(Properties.Settings.Default.connstring);
            Tho tho = null;
            using (conn)
            {
                SqlCommand command = new SqlCommand(query, conn);
                try
                {
                    conn.Open();
                    SqlDataReader dataReader = command.ExecuteReader();

                    while (dataReader.Read())
                    {
                        //    tho = new((int)dataReader[0], dataReader[1].ToString(), dataReader[2].ToString(), dataReader[3].ToString(),
                        //(DateTime)dataReader[4], dataReader[5].ToString(), dataReader[6].ToString(), dataReader[7].ToString(), dataReader[8].ToString(), (int)dataReader[9], Convert.ToSingle(dataReader[10]));
                        tho = new(
                            id: (int)dataReader["Id"],
                            hoTen: dataReader["HoTen"].ToString(),
                            cCCD: dataReader["CCCD"].ToString(),
                            sDT: dataReader["SDT"].ToString(),
                            dob: (DateTime)dataReader["Dob"],
                            khuvuc: dataReader["KhuVuc"].ToString(),
                            linhVuc: dataReader["LinhVuc"].ToString(),
                            chuyenmon: dataReader["ChuyenMon"].ToString(),
                            kinhNghiem: dataReader["KinhNghiem"].ToString(),
                            giaTien: (int)dataReader["GiaTien"],
                            danhgia:Convert.ToSingle(dataReader["DanhGia"])
                            );
                    }
                    dataReader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            return tho;
        }

        public int CountCongViec(string query)
        {
            SqlConnection conn = new SqlConnection(Properties.Settings.Default.connstring);
            int count = 0;
            using (conn)
            {
                SqlCommand command = new SqlCommand(query, conn);               
                try
                {
                    conn.Open();
                    SqlDataReader dataReader = command.ExecuteReader();
                    while (dataReader.Read())
                    {
                        count = (int)dataReader["DemCV"];
                        return count ;
                    }
                    dataReader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            return count;
        }

        internal List<int> GetThuNhap(string query)
        {
            SqlConnection conn = new SqlConnection(Properties.Settings.Default.connstring);
            List<int> thuNhap = Enumerable.Repeat(0, 12).ToList();
            using (conn)
            {
                SqlCommand command = new SqlCommand(query, conn);
                try
                {
                    conn.Open();
                    SqlDataReader dataReader = command.ExecuteReader();

                    while (dataReader.Read())
                    {
                        int income = Convert.ToInt32(dataReader["TongChiPhi"]);
                        int thang = Convert.ToInt32(dataReader["Thang"]);
                        // Thêm giá trị thu nhập vào danh sách                        
                        thuNhap[thang-1]+=income;
                    }
                    dataReader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            return thuNhap;
        }

        internal List<float> ReadSaoDatabase(string sqlStr)
        {
            SqlConnection conn = new SqlConnection(Properties.Settings.Default.connstring);
            List<float> dgId = new List<float>();
            using (conn)
            {
                SqlCommand command = new SqlCommand(sqlStr, conn);
                try
                {
                    conn.Open();
                    SqlDataReader dataReader = command.ExecuteReader();

                    while (dataReader.Read())
                    {
                        float tong = Convert.ToInt32(dataReader["Tong"]);
                        int sl = Convert.ToInt32(dataReader["SLuong"]);
                        float idTho = Convert.ToInt32(dataReader["Id"]);
                        // Thêm giá trị thu nhập vào danh sách
                        if (sl != 0)
                            dgId.Add(tong/sl);
                        dgId.Add(idTho);
                        
                        return dgId;
                                  
                    }
                    dataReader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            return null;
        }
    }
}
