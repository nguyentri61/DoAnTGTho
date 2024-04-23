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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace DoAnTGVL.UControls
{
    /// <summary>
    /// Interaction logic for UCDSBaiDangUser.xaml
    /// </summary>
    public partial class UCDSBaiDangUser : UserControl
    {
        BaiDang baidang;
        User user;
        Tho tho;
        BUSBaiDang busbaidang = new BUSBaiDang();
        public UCDSBaiDangUser(BaiDang baidang, User user)
        {
            InitializeComponent();
            this.baidang = baidang;
            this.user = user;
            this.DataContext = baidang;
        }

        private void btn_XemChiTiet_Click(object sender, RoutedEventArgs e)
        {
            ChiTietCongViec chiTietCV = new ChiTietCongViec(baidang, tho);
            chiTietCV.Show();
        }

        private void btn_Sua_Click(object sender, RoutedEventArgs e)
        {
            ChinhSuaBaiDang suaBaiDang = new ChinhSuaBaiDang(baidang);
            suaBaiDang.Show();
        }

        private void btn_Xoa_Click(object sender, RoutedEventArgs e)
        {
            var thongbao = new ShowDialogCustom("Bạn có thật sự muốn Xóa Bài Đăng này? ", ShowDialogCustom.YesNo);

            if (thongbao.ShowDialog() == true)
            {
                busbaidang.XoaBaiDang(baidang);
                new ShowDialogCustom("Xóa thành công", ShowDialogCustom.OK).Show();
            }
        }
    }
}
