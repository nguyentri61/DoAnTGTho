using DoAnTGVL.BUS;
using DoAnTGVL.Class;
using DoAnTGVL.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
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
    /// Interaction logic for ChiTietCongViec.xaml
    /// </summary>
    public partial class ChiTietCongViec : Window
    {
        BaiDang baiDang;
        Tho tho;
        BUSChiTietCongViec bUSChiTiet=new BUSChiTietCongViec();
        public ChiTietCongViec(BaiDang baidang, Tho tho)
        {
            InitializeComponent();
            this.DataContext = baidang; 
            this.tho = tho;
            this.baiDang = baidang;
        }

        private void btnHuy_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void btn_Commfirm_Click(object sender, RoutedEventArgs e)
        {
            bUSChiTiet.Them(baiDang, tho);
            this.Close();
        } 
    }
}
