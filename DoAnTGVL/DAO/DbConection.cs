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
                        Tho tho = new Tho((int)dataReader[0], dataReader[1].ToString(), dataReader[2].ToString(), dataReader[3].ToString(),
                    (DateTime)dataReader[4], dataReader[5].ToString(), dataReader[6].ToString(), dataReader[7].ToString(), dataReader[8].ToString(), (int)dataReader[9], Convert.ToSingle(dataReader[10]));
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
                        BaiDang baidang = new BaiDang((int)dataReader[0], dataReader[1].ToString(), dataReader[2].ToString(), dataReader[3].ToString(), dataReader[4].ToString(),
                    dataReader[5].ToString(), ((DateTime)dataReader[6]).Date, dataReader[7].ToString(), dataReader[8].ToString(), dataReader[9].ToString());
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
                        DateTime tenp = ((DateTime)dataReader[8]).Date;
                    
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
                        data.TieuDe = dataReader.GetString(3);
                        data.MoTa = dataReader.GetString(4);
                        data.GhiChu = dataReader.GetString(5);
                        data.LinhVuc = dataReader.GetString(6);
                        data.KhuVuc = dataReader.GetString(7);
                        data.DateThue = dataReader.GetDateTime(8);
                        data.TrangThai = dataReader.GetString(9);

                        // Set other properties if needed
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
                        user = new((int)dataReader[0], dataReader[1].ToString(), dataReader[2].ToString(), dataReader[3].ToString(),
                    (DateTime)dataReader[4], dataReader[5].ToString());

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
                        DSYeuThich.Add((int)dataReader[1]);
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
                        temp.TenUser = dataReader[0].ToString(); 
                        temp.MoTaDanhGia= dataReader[1].ToString();
                        temp.GetSource(dataReader[2].ToString());
                        temp.NgayThue= dataReader.GetDateTime(3);
                        temp.DanhGiaCV= dataReader.GetInt32(4);
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
    }
}
