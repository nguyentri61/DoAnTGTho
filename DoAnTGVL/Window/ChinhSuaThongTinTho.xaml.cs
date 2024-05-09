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

namespace DoAnTGVL.Window
{
    /// <summary>
    /// Interaction logic for ChinhSuaThongTinTho.xaml
    /// </summary>
    public partial class ChinhSuaThongTinTho : Window
    {
        Tho tho;
        DAOTho daotho = new DAOTho();
        public ChinhSuaThongTinTho(Tho tho)
        {
            InitializeComponent();
            this.tho = tho;
            this.DataContext = tho;
        }

        private void btn_close_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void btn_Sua_Click(object sender, RoutedEventArgs e)
        {
            daotho.Sua(tho);
            new ShowDialogCustom("Cập nhật thành công", ShowDialogCustom.OK).Show();
        }
    }
}
