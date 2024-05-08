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
using System.Windows.Shapes;

namespace DoAnTGVL
{
    /// <summary>
    /// Interaction logic for ProfileTho.xaml
    /// </summary>
    public partial class ProfileTho : Window
    {
        Tho tho;
        DAOTho daotho = new DAOTho();
        public ProfileTho(Tho tho)
        {
            InitializeComponent();
            this.tho = tho;
            this.DataContext = tho;
        }

        private void click_Huy(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void btn_Luu_Click(object sender, RoutedEventArgs e)
        {
            daotho.Sua(tho);
            new ShowDialogCustom("Lưu thành công", ShowDialogCustom.OK).Show();
        }
    }
}
