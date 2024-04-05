using DoAnTGVL.BUS;
using DoAnTGVL.Class;
using DoAnTGVL.DAO;
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
    /// Interaction logic for UCDSThueTho.xaml
    /// </summary>
    public partial class UCDSThueTho : UserControl
    {
        User user;
        BUSChiTietCongViec buschitietcv = new BUSChiTietCongViec();
        FilterDSCongViec filterDSCongViec = new FilterDSCongViec();
        List<CongViec> congviecList;
        public UCDSThueTho(User user)
        {
            this.user = user;
            InitializeComponent();
        }

        private void Tab_Loaded(object sender, RoutedEventArgs e)
        {
            UserControl userControl;
            congviecList =buschitietcv.LoadDSThueTho(user.Id);
            
            foreach (CongViec congViec in congviecList)
            {
                userControl = new UCDSThue(congViec);
                userControl.Width = 620;
                userControl.Height = 370;
                userControl.Margin = new Thickness(10);
                // Thêm UserControl vào WrapPanel
                staHoanThanh.Children.Add(userControl);
            }
        }

       
    }
}
