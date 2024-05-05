using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
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
using DoAnTGVL.DAO;
using DoAnTGVL.Class;
using DoAnTGVL.BUS;
using System.Collections.ObjectModel;

namespace DoAnTGVL.UControls
{
    /// <summary>
    /// Interaction logic for UCDSCongViecTho.xaml
    /// </summary>
    public partial class UCDSCongViecTho : UserControl
    {
        Tho tho;
        CongViec cv;
        BUSChiTietCongViec buschitietcv = new BUSChiTietCongViec();
        FilterDSCongViec filterDSCongViec = new FilterDSCongViec();
        List<CongViec> dataList;
        public UCDSCongViecTho(Tho tho)
        {
            this.tho = tho;
            InitializeComponent();
            this.DataContext = filterDSCongViec;
            LoadDataIntoListView();
        }
 
        private void LoadDataIntoListView()
        {
            dataList = buschitietcv.LoadDataHT(tho.Id);
            lsvDSCV.ItemsSource = dataList;
        }

        private void txbTimKiem_KeyUp(object sender, KeyEventArgs e)
        {
            lsvDSCV.ItemsSource = buschitietcv.FilterCVHT(filterDSCongViec, tho.Id);
        }

        private void btn_XemChiTiet(object sender, RoutedEventArgs e)
        {
            var congviec = (sender as Button).DataContext as CongViec;
            ChiTietLichSuViecTho chitiet = new ChiTietLichSuViecTho(congviec, tho);
            chitiet.ShowDialog();
        }
    }
}
