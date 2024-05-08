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
    /// Interaction logic for ChinhSuaBaiDang.xaml
    /// </summary>
    public partial class ChinhSuaBaiDang : Window
    {
        BaiDang baidang;
        BUSBaiDang busbaidang = new BUSBaiDang();
        public ChinhSuaBaiDang(BaiDang baidang)
        {
            InitializeComponent();
            this.baidang = baidang;
            this.DataContext = baidang;
        }

        private void btnHuy_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void btn_Sua_CLick(object sender, RoutedEventArgs e)
        {
            var thongbao = new ShowDialogCustom("Bạn có thật sự muốn chỉnh sửa Bài Đăng này? ", ShowDialogCustom.YesNo);

            if (thongbao.ShowDialog() == true)
            {
                busbaidang.SuaBaiDang(baidang);
                new ShowDialogCustom("Cập nhật thành công", ShowDialogCustom.OK).Show();
            }
        }
    }
}
