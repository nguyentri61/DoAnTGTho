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
    /// Interaction logic for UCTienDoViecTho.xaml
    /// </summary>
    public partial class UCTienDoViecTho : UserControl
    {
        Tho tho;
        CongViec cv;
        BUSChiTietCongViec buschitietcv = new BUSChiTietCongViec();
        FilterDSCongViec filterDSCongViec = new FilterDSCongViec();
        List<CongViec> dataList;
        public UCTienDoViecTho(Tho tho)
        {
            this.tho = tho;
            InitializeComponent();
            this.DataContext = filterDSCongViec;
            LoadDataIntoListView();
        }

        private void LoadDataIntoListView()
        {
            dataList = buschitietcv.LoadData(tho.Id);
            lsvDSCV.ItemsSource = dataList;
        }


        private void chboxDaHoanThanh_Click(object sender, RoutedEventArgs e)
        {
            lsvDSCV.ItemsSource = buschitietcv.FilterCV(filterDSCongViec, tho.Id);
        }

        private void chboxDangThucHien_Click(object sender, RoutedEventArgs e)
        {
            lsvDSCV.ItemsSource = buschitietcv.FilterCV(filterDSCongViec, tho.Id);
        }

        private void chboxChuaThucHien_Click(object sender, RoutedEventArgs e)
        {
            lsvDSCV.ItemsSource = buschitietcv.FilterCV(filterDSCongViec, tho.Id);
        }
        private void txbTimKiem_KeyUp(object sender, KeyEventArgs e)
        {
            lsvDSCV.ItemsSource = buschitietcv.FilterCV(filterDSCongViec, tho.Id);
        }

        private void btn_Xoa(object sender, RoutedEventArgs e)
        {
            var congviec = (sender as Button).DataContext as CongViec;
            int index = lsvDSCV.Items.IndexOf((sender as Button).DataContext);

            var thongbao = new ShowDialogCustom("Bạn có thật sự muốn Xóa công việc này? ", ShowDialogCustom.YesNo);

            if (thongbao.ShowDialog() == true)
            {
                new ShowDialogCustom("Xoá thành công", ShowDialogCustom.OK).Show();
                buschitietcv.Xoa(congviec);
                LoadDataIntoListView();
            }
        }

        private void btn_Sua(object sender, RoutedEventArgs e)
        {
            var congviec = (sender as Button).DataContext as CongViec;

            ChinhSuaDSCongViec chinhSuaDSCongViec = new ChinhSuaDSCongViec(congviec, tho);
            chinhSuaDSCongViec.ShowDialog();
            buschitietcv.Sua(congviec, tho);
            LoadDataIntoListView();
        }

        private void ngayBanbutton_Click(object sender, RoutedEventArgs e)
        {
            LichBan lichban = new LichBan(tho);
            lichban.Show();
        }
    }
}
