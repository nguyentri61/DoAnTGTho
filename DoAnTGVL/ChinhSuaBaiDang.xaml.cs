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
using System.Windows.Shapes;

namespace DoAnTGVL
{
    /// <summary>
    /// Interaction logic for ChinhSuaBaiDang.xaml
    /// </summary>
    public partial class ChinhSuaBaiDang : Window
    {
        BaiDang baidang;
        public ChinhSuaBaiDang(BaiDang baidang)
        {
            InitializeComponent();
            this.baidang = baidang;
            this.DataContext = baidang;
        }

        private void btnHuy_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
