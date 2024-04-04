using DoAnTGVL.BUS;
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
        public ThoHoanThanhCongViec()
        {
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
                //solutionFilePath + "\\DoAnTGVL\\ImageDanhGia\\cv1anh1_4d9f8ff0.jpg", UriKind.Absolute
                clickedImage.Source = btmap;
                clickedImage.Height = 108;
                clickedImage.Width = 108;
                //bUSDanhGiaTho.AddImage(openFileDialog.FileName);
            }
        }

        private void btn_Huy_Click(object sender, RoutedEventArgs e)
        {
            Close();    
        }
    }
}
