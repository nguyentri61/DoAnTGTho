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
    /// Interaction logic for ChiTietLichSuViecTho.xaml
    /// </summary>
    public partial class ChiTietLichSuViecTho : Window
    {
        CongViec congviec;
        Tho tho;
        public ChiTietLichSuViecTho(CongViec congviec, Tho tho)
        {
            InitializeComponent();
            this.DataContext = congviec;
            this.tho = tho;
            this.congviec = congviec;
        }

        private void btnCapNhat_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
