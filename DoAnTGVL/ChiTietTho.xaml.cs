using DoAnTGVL.BUS;
using DoAnTGVL.Class;
using DoAnTGVL.UControls;
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
    /// Interaction logic for ChiTietTho.xaml
    /// </summary>
    public partial class ChiTietTho : Window
    {
        Tho tho;
        User user;
        List<DanhGia> danhGias = new List<DanhGia>();
        BUSDanhGiaTho bUSDanhGiaTho = new BUSDanhGiaTho();
        public ChiTietTho(Tho tho, User user)
        {
            
            InitializeComponent();
            this.DataContext = tho;
            this.user = user;
            this.tho = tho;
            bUSDanhGiaTho.CreateWrapDanhGia(tho,user,this); 
            
        }
           
        private void Thue_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            Window xacnhan = new XacNhanThueTho(tho, user);
            xacnhan.ShowDialog();
            this.Show();
        }

        private void btn_close_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
