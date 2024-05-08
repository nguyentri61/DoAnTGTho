using DoAnTGVL.BUS;
using DoAnTGVL.Class;
using DoAnTGVL.DAO;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace DoAnTGVL
{
    /// <summary>
    /// Interaction logic for XacNhanThueTho.xaml
    /// </summary>
    public partial class XacNhanThueTho : Window
    {
        Tho tho;
        User user;
        CongViec congViec=new CongViec();
        BUSXacNhanThueTho bUSXacNhan=new BUSXacNhanThueTho();   
        public XacNhanThueTho(Tho tho, User user)
        {
            InitializeComponent();
            this.tho = tho;
            this.user = user;
            
            congViec = new CongViec(tho.Id, user.Id, tho.LinhVuc, user.Khuvuc);
            this.DataContext= congViec;
        }

        private void click_Huy(object sender, RoutedEventArgs e)
        {
            Close();
            
        }

        private void calenNgayThue_Loaded(object sender, RoutedEventArgs e)
        {
            List<DateTime> dates = bUSXacNhan.Load_Calender(tho.Id);
            foreach (DateTime dateTime in dates)
            {
                    calenNgayThue.BlackoutDates.Add(new CalendarDateRange(dateTime));
                
            }
        }

        private void btn_Xacnhan_Click(object sender, RoutedEventArgs e)
        {
            bUSXacNhan.Them(congViec);
            this.Close();
        }
    }
}
