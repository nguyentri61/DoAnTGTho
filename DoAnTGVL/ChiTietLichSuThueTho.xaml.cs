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
    /// Interaction logic for ChiTietLichSuThueTho.xaml
    /// </summary>
    public partial class ChiTietLichSuThueTho : Window
    {
        CongViec congviec;
        User user;
        public ChiTietLichSuThueTho(CongViec congviec, User user)
        {
            InitializeComponent();
            this.congviec = congviec;
            this.user = user;
            this.DataContext = congviec;
            if (congviec.TrangThai == "Chưa thực hiện")
            {
                cthlstItem.IsSelected = true;
                btnHuy.Visibility = Visibility.Hidden;
            }
            else if (congviec.TrangThai == "Đang thực hiện")
            {
                dthlstItem.IsSelected = true;
                btnHuy.Visibility = Visibility.Hidden;
            }
            else
            {
                btn_OK.Content = "Xem Sản Phẩm";
                btnHuy.Visibility = Visibility.Visible;
            }

        }

        private void btnHuy_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
