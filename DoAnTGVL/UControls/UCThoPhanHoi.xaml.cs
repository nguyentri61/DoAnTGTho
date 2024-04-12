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
    /// Interaction logic for UCThoPhanHoi.xaml
    /// </summary>
    public partial class UCThoPhanHoi : UserControl
    {
        CongViec congviec;
        BUSChiTietCongViec buschitietcongviec = new BUSChiTietCongViec();
        public UCThoPhanHoi(CongViec congviec)
        {
            InitializeComponent();
            this.congviec = congviec;
            this.DataContext = congviec;

            StackPanel stackPanel = new StackPanel();
            stackPanel.Orientation = Orientation.Horizontal;
            stackPanel.HorizontalAlignment = HorizontalAlignment.Center;
            stackPanel.VerticalAlignment = VerticalAlignment.Center;

            foreach (string source in congviec.Image)
            {
                string solutionFilePath = buschitietcongviec.FindSolutionFile();

                BitmapImage bitmapImage = new BitmapImage(new Uri(solutionFilePath + "\\DoAnTGVL\\ImageCongViec\\" + source, UriKind.Absolute));

                // Tạo một Image và đặt BitmapImage làm nguồn
                Image image = new Image();
                image.Source = bitmapImage;
                image.Width = 150;
                image.Height = 150;
                image.Margin = new Thickness(5);
                stackPanel.Children.Add(image);
            }
            this.ImagePanel.Children.Add(stackPanel);
        }
    }
}
