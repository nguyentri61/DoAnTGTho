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
    /// Interaction logic for ChiTietThongBao.xaml
    /// </summary>
    public partial class ChiTietThongBao : Window
    {
        CongViec congviec;
        public ChiTietThongBao(CongViec congviec)
        {
            InitializeComponent();
            this.congviec = congviec;
            this.DataContext = congviec;
        }

        private void btnOK_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
