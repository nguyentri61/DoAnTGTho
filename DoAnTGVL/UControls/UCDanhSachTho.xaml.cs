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
    /// Interaction logic for UCDanhSachTho.xaml
    /// </summary>
    public partial class UCDanhSachTho : UserControl
    {
        Tho tho;
        User user;
        public UCDanhSachTho(Tho tho, User user)
        {
            this.tho = tho;
            this.user = user;
            
            InitializeComponent();
            this.DataContext = tho;
        }
        public void btnXemChiTiet_Click(object sender, RoutedEventArgs e)
        {
            ChiTietTho chiTietTho = new ChiTietTho(tho, user);
            chiTietTho.Show();
        }

        private void ToggleButton_Click(object sender, RoutedEventArgs e)
        {
            BUSDanhSachTho bUSDanhSachTho = new BUSDanhSachTho();
            bUSDanhSachTho.ThemXoaDSYeuThich(tho,user);
        }
    }
}
