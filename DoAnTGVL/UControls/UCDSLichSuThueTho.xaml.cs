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
    /// Interaction logic for UCDSLichSuThueTho.xaml
    /// </summary>
    public partial class UCDSLichSuThueTho : UserControl
    {
        User user;
        BUSChiTietCongViec buschitietcv = new BUSChiTietCongViec();
        FilterDSCongViec filterDSCongViec = new FilterDSCongViec();
        List<CongViec> dataList;
        public UCDSLichSuThueTho(User user)
        {
            this.user = user;
            InitializeComponent();
            this.DataContext = filterDSCongViec;
            LoadDataIntoListView();

        }

        private void LoadDataIntoListView()
        {
            dataList = buschitietcv.LoadDSThueTho(user.Id);

            lsvDSCV.ItemsSource = dataList;
        }

        private void chboxDaHoanThanh_Click(object sender, RoutedEventArgs e)
        {
            lsvDSCV.ItemsSource = buschitietcv.FilterCV(filterDSCongViec, "IDUser", user.Id);
        }

        private void chboxDangThucHien_Click(object sender, RoutedEventArgs e)
        {
            lsvDSCV.ItemsSource = buschitietcv.FilterCV(filterDSCongViec, "IDUser", user.Id);
        }

        private void chboxChuaThucHien_Click(object sender, RoutedEventArgs e)
        {
            lsvDSCV.ItemsSource = buschitietcv.FilterCV(filterDSCongViec, "IDUser", user.Id);
        }

        private void txbTimKiem_KeyUp(object sender, KeyEventArgs e)
        {
            lsvDSCV.ItemsSource = buschitietcv.FilterCV(filterDSCongViec, "IDUser", user.Id);
        }

        private void btn_Xoa(object sender, RoutedEventArgs e)
        {
            var congviec = (sender as Button).DataContext as CongViec;
            int index = lsvDSCV.Items.IndexOf((sender as Button).DataContext);

            // Sử dụng chỉ mục index ở đây cho mục đích của bạn
            MessageBox.Show($"Chỉ mục của hàng: {index}");
            var thongbao = new ShowDialogCustom("Bạn có thật sự muốn Công việc này? ", ShowDialogCustom.YesNo);

            if (thongbao.ShowDialog() == true)
            {
                new ShowDialogCustom("Xoá thành công", ShowDialogCustom.OK).Show();
                buschitietcv.Xoa(congviec);
                LoadDataIntoListView();
            }
        }

        private void btn_XemChiTiet(object sender, RoutedEventArgs e)
        {
            var congviec = (sender as Button).DataContext as CongViec;

            ChiTietLichSuThueTho ctlstt = new ChiTietLichSuThueTho(congviec, user);
            ctlstt.ShowDialog();
            //    buschitietcv.Sua(congviec, tho);
            //    LoadDataIntoListView();
        }
    }      
}
