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
using System.Diagnostics;
using System.Data.SqlClient;
using DoAnTGVL.BUS;
using DoAnTGVL.Class;

namespace DoAnTGVL
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Window window;
        SqlConnection conn = new SqlConnection(Properties.Settings.Default.connstring);
        TaiKhoan taikhoan= new TaiKhoan();
        BUSTaiKhoan bUSTaiKhoan = new BUSTaiKhoan();
        public MainWindow()
        {
            InitializeComponent();
            this.DataContext = taikhoan;
        }
        public void btn_Close_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
        public void click_DangNhap(object sender, RoutedEventArgs e)
        {
            
            taikhoan.Pass = passBox.Password;
            taikhoan.Role = ((bool)rdbTho.IsChecked) ? 1 : 0;
            BUSDangNhap busDangNhap=new BUSDangNhap();
            window = busDangNhap.Login(taikhoan);
            if (window != null)
            {
                this.Hide();
                window.ShowDialog();
            }

        }
        private void Hyperlink_RequestNavigate(object sender, System.Windows.Navigation.RequestNavigateEventArgs e)
        {
            try
            {
                Process.Start(new ProcessStartInfo(e.Uri.AbsoluteUri) { UseShellExecute = true });
                e.Handled = true;
            }
            catch (Exception ex)
            {
                // Xử lý nếu có lỗi
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
        }

       
    }
}
