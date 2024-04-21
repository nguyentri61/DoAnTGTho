using DoAnTGVL.BUS;
using DoAnTGVL.Class;
using DoAnTGVL.DAO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
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
    /// Interaction logic for UCThueTho.xaml
    /// </summary>
    public partial class UCThueTho : UserControl
    {
        BUSThueTho bUSThueTho = new BUSThueTho();
        FilterTho filterTho = new FilterTho();
        public User user;
        public UCThueTho(User user)
        {
            InitializeComponent();
            this.user = user;
            this.DataContext = filterTho;
            bUSThueTho.CreateWrapThueTho(filterTho,user, this);
        }
        private void fil_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            filterTho.KhuVuc = (cboKhuVuc.SelectedItem != null) ? (cboKhuVuc.SelectedItem as ComboBoxItem).Content.ToString() : "";
            filterTho.KinhNghiem = (cboKinhNghiem.SelectedItem != null) ? (cboKinhNghiem.SelectedItem as ComboBoxItem).Content.ToString() : "";
            filterTho.Giatien = (cboGiaTien.SelectedItem != null) ? (cboGiaTien.SelectedItem as ComboBoxItem).Content.ToString() : "";
            bUSThueTho.CreateWrapThueTho(filterTho, user, this);
        }
        private void GetChuyenMon(object sender, RoutedEventArgs e)
        {
            MenuItem subMenuItem = sender as MenuItem;
            if (subMenuItem != null)
            {
                filterTho.ChuyenMon = subMenuItem.Header.ToString();              
            }
            bUSThueTho.CreateWrapThueTho(filterTho, user, this);
        } 
        private void reload_button_Click(object sender, RoutedEventArgs e)
        {
            filterTho.reset();
            this.Content = new UCThueTho(user);
        }
        private void txbTimKiem_KeyUp(object sender, KeyEventArgs e)
        {
            bUSThueTho.CreateWrapThueTho(filterTho, user, this);
        }
        private void click_DangBai(object sender, RoutedEventArgs e)
        {
            Window dangbai = new DangBai(user);
            dangbai.ShowDialog();
        }

        private void chboxYeuThich_Click(object sender, RoutedEventArgs e)
        {
            bUSThueTho.CreateWrapThueTho(filterTho, user, this);
        }
        private void ToggleButton_Click(object sender, RoutedEventArgs e)
        {
            Window thongbaoThue = new ThongBaoNhanTho(user);
            thongbaoThue.Show();
        }
    }
}
