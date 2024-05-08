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
    /// Interaction logic for ChiTietLichSuThueTho.xaml
    /// </summary>
    public partial class ChiTietLichSuThueTho : Window
    {
        CongViec congviec;
        User user;
        BUSDanhGiaTho bUSDanhGiaTho = new BUSDanhGiaTho();
        public ChiTietLichSuThueTho(CongViec congviec, User user)
        {
            InitializeComponent();
            this.congviec = congviec;
            this.user = user;
            this.DataContext = congviec;

            
            if(congviec.TrangThai== "Đã hoàn thành")
            {
                UCThoPhanHoi uCThoPhanHoi = new UCThoPhanHoi(congviec);
                uCThoPhanHoi.Width = 740;
                uCThoPhanHoi.Height = 300;
                WpanelPhanHoi.Children.Add(uCThoPhanHoi);
                btn_OK.Content = "Đánh giá";
            }
        }

        private void btnHuy_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void btnOK_Click(object sender, RoutedEventArgs e)
        {
            if (congviec.TrangThai == "Đã hoàn thành")
            {
                DanhGiaTho danhGiaTho = new DanhGiaTho(congviec);
                this.Hide();
                danhGiaTho.ShowDialog();
            }
            else
                Close();
        }
    }
}
