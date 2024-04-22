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
    /// Interaction logic for UCDanhSachCongViec.xaml
    /// </summary>
    public partial class UCDanhSachCongViec : UserControl
    {
        BaiDang baidang;
        Tho tho;
        public UCDanhSachCongViec(BaiDang baidang,Tho tho)
        {
            this.baidang = baidang;
            this.tho = tho;
            InitializeComponent();
            this.DataContext = baidang;
        }


        private void btnXemChiTiet_Click(object sender, RoutedEventArgs e)
        {
            ChiTietCongViec chiTietCV = new ChiTietCongViec(baidang,tho);
            chiTietCV.Show();
        }
    }
}
