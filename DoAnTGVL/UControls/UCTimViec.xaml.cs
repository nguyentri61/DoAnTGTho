using DoAnTGVL.BUS;
using DoAnTGVL.Class;
using DoAnTGVL.DAO;
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
    /// Interaction logic for UCTimViec.xaml
    /// </summary>
    public partial class UCTimViec : UserControl
    {
        BUSTimViec bustimviec = new BUSTimViec();
        FilterBaiDang filterBaiDang=new FilterBaiDang();
        public Tho tho;
        public UCTimViec(Tho tho)
        {
            InitializeComponent();
            this.DataContext = filterBaiDang;
            this.tho = tho;
            bustimviec.CreateWrapBaiDang(filterBaiDang, this);    
        }

        private void fil_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            filterBaiDang.KhuVuc = (cboKhuVuc.SelectedItem != null) ? (cboKhuVuc.SelectedItem as ComboBoxItem).Content.ToString() : "";
            filterBaiDang.KinhNghiem = (cboKinhNghiem.SelectedItem != null) ? (cboKinhNghiem.SelectedItem as ComboBoxItem).Content.ToString() : "";
            bustimviec.CreateWrapBaiDang(filterBaiDang, this); ;
        }
        private void btnUploadProfile_Click(object sender, RoutedEventArgs e)
        {
            Window profile = new ProfileTho(tho);
            profile.Show();
        }
        private void txbTimKiem_KeyUp(object sender, KeyEventArgs e)
        {
            bustimviec.CreateWrapBaiDang(filterBaiDang, this);
        }

        private void btn_reload_Click(object sender, RoutedEventArgs e)
        {
            filterBaiDang.reset();
            this.Content = new UCTimViec(tho);
        }

        private void ToggleButton_Click(object sender, RoutedEventArgs e)
        {
            Window thongbaoThue = new ThongBaoThue(tho);
            thongbaoThue.Show();
        }
    }
}
