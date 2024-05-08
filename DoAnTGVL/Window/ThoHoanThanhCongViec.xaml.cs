using DoAnTGVL.BUS;
using DoAnTGVL.Class;
using Microsoft.Win32;
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
    /// Interaction logic for ThoHoanThanhCongViec.xaml
    /// </summary>
    public partial class ThoHoanThanhCongViec : Window
    {
        BUSChiTietCongViec buschitietcv = new BUSChiTietCongViec();
        DanhGia danhGia = new DanhGia();
        CongViec congviec;
        public ThoHoanThanhCongViec(CongViec congviec)
        {
            this.congviec=congviec;
            DataContext = congviec;
            InitializeComponent();
        }

        private void Image_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Image clickedImage = sender as Image;
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image files|*.bmp;*.jpg;*.png";
            openFileDialog.FilterIndex = 1;
            if (openFileDialog.ShowDialog() == true)
            {
                BitmapImage btmap = new BitmapImage(new Uri(openFileDialog.FileName));
                clickedImage.Source = btmap;
                clickedImage.Height = 108;
                clickedImage.Width = 108;
                buschitietcv.AddImage(openFileDialog.FileName);
            }
        }
        private void btn_Huy_Click(object sender, RoutedEventArgs e)
        {
            Close();    
        }

        private void ComfirmClick_Click(object sender, RoutedEventArgs e)
        {
            buschitietcv.Add(congviec);
            Close();
        }
    }
}
