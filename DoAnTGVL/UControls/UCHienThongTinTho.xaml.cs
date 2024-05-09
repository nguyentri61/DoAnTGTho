using DoAnTGVL.Class;
using DoAnTGVL.Window;
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
    /// Interaction logic for UCHienThongTinTho.xaml
    /// </summary>
    public partial class UCHienThongTinTho : UserControl
    {
        Tho tho;
        public UCHienThongTinTho(Tho tho)
        {
            this.tho = tho;
            InitializeComponent();
            this.DataContext = tho;
        }

        private void btn_ChiTietTho_Click(object sender, RoutedEventArgs e)
        {
            ChinhSuaThongTinTho chinhsua = new ChinhSuaThongTinTho(tho);
            chinhsua.Show();
        }
    }
}
