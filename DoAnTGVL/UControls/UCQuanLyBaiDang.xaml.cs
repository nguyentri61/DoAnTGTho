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
    /// Interaction logic for UCQuanLyBaiDang.xaml
    /// </summary>
    public partial class UCQuanLyBaiDang : UserControl
    {
        BUSTimViec bustimviec = new BUSTimViec();
        FilterBaiDang filterBaiDang = new FilterBaiDang();
        public Tho tho;
        public User user;
        public UCQuanLyBaiDang(User user)
        {
            InitializeComponent();
            this.user = user;
            this.DataContext = filterBaiDang;
            bustimviec.CreateWrapBaiDang(filterBaiDang, this);
        }
        private void fil_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            filterBaiDang.KhuVuc = (cboKhuVuc.SelectedItem != null) ? (cboKhuVuc.SelectedItem as ComboBoxItem).Content.ToString() : "";
            filterBaiDang.KinhNghiem = (cboKinhNghiem.SelectedItem != null) ? (cboKinhNghiem.SelectedItem as ComboBoxItem).Content.ToString() : "";
            bustimviec.CreateWrapBaiDang(filterBaiDang, this); ;
        }
        private void txbTimKiem_KeyUp(object sender, KeyEventArgs e)
        {
            bustimviec.CreateWrapBaiDang(filterBaiDang, this);
        }
        private void btn_reload_Click(object sender, RoutedEventArgs e)
        {
            filterBaiDang.reset();
            this.Content = new UCQuanLyBaiDang(user);
        }
    }
}
