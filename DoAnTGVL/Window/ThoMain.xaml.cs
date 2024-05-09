using DoAnTGVL.Class;
using DoAnTGVL.UControls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
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
    /// Interaction logic for ThoMain.xaml
    /// </summary>
    /// 

    public partial class ThoMain : Window
    {
        private UserControl PreUC = new UCHome();
        private UserControl CurUC = new UCHome();
        Tho tho;
        public ThoMain(Tho tho)
        {
            this.tho= tho;
            InitializeComponent();
            gridMainWin.Children.Add(CurUC);
        } 
        public void MnuLogout_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            Close();
        }
        public void mnuSuaCV_Click(object sender, RoutedEventArgs e)
        {
            CurUC = new UCSuaCV();
            gridMainWin.Children.Remove(PreUC);
            PreUC = CurUC;
            gridMainWin.Children.Add(CurUC);
        }
        private void ButtonOpenMenu_Click(object sender, RoutedEventArgs e)
        {
            ButtonCloseMenu.Visibility = Visibility.Visible;
            ButtonOpenMenu.Visibility = Visibility.Collapsed;
        }

        private void ButtonCloseMenu_Click(object sender, RoutedEventArgs e)
        {
            ButtonCloseMenu.Visibility = Visibility.Collapsed;
            ButtonOpenMenu.Visibility = Visibility.Visible;
        }
        private void gridMainmenu_MouseLeave(object sender, MouseEventArgs e)
        {
            ButtonCloseMenu.Visibility = Visibility.Collapsed;
            ButtonOpenMenu.Visibility = Visibility.Visible;
        }

        private void MnuTrangChu_Click(object sender, RoutedEventArgs e)
        {
            CurUC = new UCHome();
            gridMainWin.Children.Clear();   
            gridMainWin.Children.Add(CurUC);
        }
        private void MnuTimViec_Click(object sender, RoutedEventArgs e)
        {
            CurUC = new UCTimViec(tho);
            gridMainWin.Children.Clear();
            gridMainWin.Children.Add(CurUC);
        }

        private void mnuDSVL_Click(object sender, RoutedEventArgs e)
        {
            CurUC = new UCTienDoViecTho(tho);
            gridMainWin.Children.Clear();
            gridMainWin.Children.Add(CurUC);
        }

        private void mnLuotDGia_Click(object sender, RoutedEventArgs e)
        {
            CurUC = new UCDSDanhGiaTho(tho);
            gridMainWin.Children.Clear();
            gridMainWin.Children.Add(CurUC);
        }
        
        private void mnuThongKe_Click(object sender, RoutedEventArgs e)
        {
            CurUC = new UCThongKe(tho);
            gridMainWin.Children.Clear();
            gridMainWin.Children.Add(CurUC);
        }

        private void mnuLichSu_Click(object sender, RoutedEventArgs e)
        {
            CurUC = new UCDSCongViecTho(tho);
            gridMainWin.Children.Clear();
            gridMainWin.Children.Add(CurUC);
        }

        private void btn_ThongTin_Click(object sender, RoutedEventArgs e)
        {
            CurUC = new UCThongTinTho(tho);
            gridMainWin.Children.Clear();
            gridMainWin.Children.Add(CurUC);
        }
    }
}
