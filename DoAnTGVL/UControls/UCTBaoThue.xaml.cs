using DoAnTGVL.BUS;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace DoAnTGVL.UControls
{
    /// <summary>
    /// Interaction logic for UCTBaoThue.xaml
    /// </summary>
    public partial class UCTBaoThue : UserControl
    {
        BUSThongBaoThue bUSThongBaoThue = new BUSThongBaoThue();
        CongViec congviec;
        Tho tho;
        public UCTBaoThue(CongViec congviec, Tho tho)
        {
            this.DataContext = congviec;
            this.congviec = congviec; 
            this.tho = tho;
            InitializeComponent();
        }

        private void nvButton_Click(object sender, RoutedEventArgs e)
        {
            bUSThongBaoThue.NhanViec(congviec, tho);
            Window parentWindow = Window.GetWindow(this);

            // Kiểm tra xem cửa sổ cha có tồn tại không
            if (parentWindow != null)
            {
                // Đóng cửa sổ cha
                parentWindow.Close();
            }
        }

        private void Huy_Click(object sender, RoutedEventArgs e)
        {
            bUSThongBaoThue.HuyViec(congviec, tho);
            Window parentWindow = Window.GetWindow(this);

            // Kiểm tra xem cửa sổ cha có tồn tại không
            if (parentWindow != null)
            {
                // Đóng cửa sổ cha
                parentWindow.Close();
            }
        }
    }
}
