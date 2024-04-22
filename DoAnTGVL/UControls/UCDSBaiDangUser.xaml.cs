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
    }
}
