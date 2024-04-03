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
    /// Interaction logic for ChinhSuaDSCongViec.xaml
    /// </summary>
    public partial class ChinhSuaDSCongViec : Window
    {
        CongViec congviec;
        Tho tho;
        public ChinhSuaDSCongViec(CongViec congviec, Tho tho)
        {
            InitializeComponent();
            this.DataContext = congviec;
            this.tho = tho;
            this.congviec = congviec;
            if(congviec.TrangThai=="Chưa thực hiện")
                cthlstItem.IsSelected = true;
            else if(congviec.TrangThai=="Đang thực hiện")
                dthlstItem.IsSelected = true;
            
        }

        private void btnHuy_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
