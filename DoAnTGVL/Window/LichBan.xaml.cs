using DoAnTGVL.BUS;
using DoAnTGVL.Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace DoAnTGVL
{
    /// <summary>
    /// Interaction logic for LichBan.xaml
    /// </summary>
    public partial class LichBan : Window
    {
        BUSLichBan bUSLichBan=new BUSLichBan();
        Tho tho;
        public LichBan(Tho tho)
        {
            this.tho = tho;
            InitializeComponent();
        }
        private void calenNgayThue_Loaded(object sender, RoutedEventArgs e)
        {
            List<DateTime> dates =bUSLichBan.Load_Calender(tho.Id);
            foreach (DateTime dateTime in dates)
            {
                calenNgayThue.BlackoutDates.Add(new CalendarDateRange(dateTime));

            }
        }

        private void xnhanButton_Click(object sender, RoutedEventArgs e)
        {
            
            bUSLichBan.Them(tho.Id,calenNgayThue.SelectedDate);
            calenNgayThue.SelectedDate = null;
            calenNgayThue_Loaded(sender,e);
        }
    }
}
