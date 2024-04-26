using DoAnTGVL.BUS;
using DoAnTGVL.Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Automation.Peers;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace DoAnTGVL.UControls
{
    /// <summary>
    /// Interaction logic for UCTBaoNhanViec.xaml
    /// </summary>
    public partial class UCTBaoNhanViec : UserControl
    {
        Tho tho;
        User user;
        CongViec congViec;
        BUSThongBaoNhanTho bUSThongBaoNhanTho = new BUSThongBaoNhanTho();
        public UCTBaoNhanViec(User user,CongViec congViec, Tho tho)
        {
            InitializeComponent();
            this.user = user;
            this.congViec = congViec;
            this.tho = tho;
            DataContext = tho;
            TxtTieuDe.Text=congViec.TieuDe;
        }

        private void btnHuy_Click(object sender, RoutedEventArgs e)
        {
            var thongbao = new ShowDialogCustom("Bạn có thật sự muốn Hủy công việc này? ", ShowDialogCustom.YesNo);

            if (thongbao.ShowDialog() == true)
            {
                bUSThongBaoNhanTho.Xoa(congViec, tho);
                new ShowDialogCustom("Hủy việc thành công!", ShowDialogCustom.OK).Show();
            }
            Window parentWindow = Window.GetWindow(this);

            // Kiểm tra xem cửa sổ cha có tồn tại không
            if (parentWindow != null)
            {
                // Đóng cửa sổ cha
                parentWindow.Close();
            }
        }

        private void btnChiTiet_Click(object sender, RoutedEventArgs e)
        {
            ChiTietTho chiTietTho = new ChiTietTho(tho,user);
            chiTietTho.btnThue.Visibility = System.Windows.Visibility.Collapsed;
            chiTietTho.Show();
        }

        private void btnXacNhan_Click(object sender, RoutedEventArgs e)
        {
            var thongbao = new ShowDialogCustom("Xác nhận công việc này? ", ShowDialogCustom.YesNo);

            if (thongbao.ShowDialog() == true)
            {
                bUSThongBaoNhanTho.XacNhan(congViec, tho);
                new ShowDialogCustom("Xác nhận thành công!", ShowDialogCustom.OK).Show();
            }
            Window parentWindow = Window.GetWindow(this);

            // Kiểm tra xem cửa sổ cha có tồn tại không
            if (parentWindow != null)
            {
                // Đóng cửa sổ cha
                parentWindow.Close();
            }
        }

        
    }
}
