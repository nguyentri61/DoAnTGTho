using DoAnTGVL.BUS;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
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
using EnvDTE;
using System.Runtime.InteropServices;
using DoAnTGVL.Class;

namespace DoAnTGVL
{
    /// <summary>
    /// Interaction logic for DanhGiaTho.xaml
    /// </summary>
    public partial class DanhGiaTho : System.Windows.Window
    {
        BUSDanhGiaTho bUSDanhGiaTho = new BUSDanhGiaTho();
        DanhGia danhGia = new DanhGia();
        CongViec congviec;
        public DanhGiaTho(CongViec congviec)
        {
            InitializeComponent();
            this.DataContext = danhGia;   
            this.congviec = congviec;
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
                bUSDanhGiaTho.AddImage(openFileDialog.FileName);  
            }
        }

        private void ComfirmClick_Click(object sender, RoutedEventArgs e)
        {           
            bUSDanhGiaTho.AddData(danhGia, congviec.ID);
            this.Close(); 
        }

        private void huy_Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
