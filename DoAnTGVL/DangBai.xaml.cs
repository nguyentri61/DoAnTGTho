using DoAnTGVL.Class;
using DoAnTGVL.DAO;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Globalization;
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
    /// Interaction logic for DangBai.xaml
    /// </summary>
    public partial class DangBai : Window
    {
        
        public BaiDang baiDang { get; set; }
        //BaiDang baidang;
        public DangBai()
        {
            baiDang =new BaiDang();
            InitializeComponent();
            this.DataContext = baiDang;
        }

        private void click_Huy(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void click_DangBai(object sender, RoutedEventArgs e)
        {

            try
            {
                DAOBaiDang dAOBaiDang = new DAOBaiDang();
                dAOBaiDang.Them(baiDang);
                MessageBox.Show("Thêm thành công");
                this.Close();

            }
            catch
            {
                MessageBox.Show("Vui long dien day du thong tin");
            }
        }
    }
    
}
