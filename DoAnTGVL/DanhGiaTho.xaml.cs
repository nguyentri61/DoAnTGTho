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
        DanhGia danhGia = new DanhGia();
        //BUSDanhGiaTho bUSDanhGiaTho = new BUSDanhGiaTho();
        public DanhGiaTho()
        {
            InitializeComponent();
            this.DataContext = danhGia;
        }

        private void Image_MouseDown(object sender, MouseButtonEventArgs e)
        {
            
            Image clickedImage = sender as Image;
            string solutionFilePath = FindSolutionFile();
            MessageBox.Show(solutionFilePath);
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image files|*.bmp;*.jpg;*.png";
            openFileDialog.FilterIndex = 1;
            if (openFileDialog.ShowDialog() == true)
            {
                BitmapImage btmap = new BitmapImage(new Uri(solutionFilePath+"\\DoAnTGVL\\ImageDanhGia\\cv1anh1_4d9f8ff0.jpg", UriKind.Absolute));
                MessageBox.Show(openFileDialog.FileName);
                clickedImage.Source = btmap;
                clickedImage.Height = 88;
                clickedImage.Width = 88;
                string source = openFileDialog.FileName;
                string fileName = System.IO.Path.GetFileName(source);
                string destinationFolder = "ImageDanhGia";
                string path = System.IO.Path.GetFullPath(destinationFolder);
                string folder_path = path.Substring(0, path.IndexOf("bin"));
                string destination = System.IO.Path.Combine(folder_path, destinationFolder, fileName);
                if (!System.IO.File.Exists(destination))
                {
                    System.IO.File.Copy(source, destination);
                   

                }
                else
                {
                    string fileNameWithoutExtension = System.IO.Path.GetFileNameWithoutExtension(fileName);
                    string fileExtension = System.IO.Path.GetExtension(fileName);
                    string newFileName = fileNameWithoutExtension + "_" + Guid.NewGuid().ToString().Substring(0, 8) + fileExtension;
                    destination = System.IO.Path.Combine(folder_path, destinationFolder, newFileName);
                    System.IO.File.Copy(source, destination);
                }
            }
        }

        private void ComfirmClick_Click(object sender, RoutedEventArgs e)
        {

        }
        static string FindSolutionFile()
        {
            DirectoryInfo directoryInfo = new DirectoryInfo(Directory.GetCurrentDirectory());

            while (directoryInfo != null)
            {
                FileInfo[] files = directoryInfo.GetFiles("*.sln");
                if (files.Length > 0)
                {
                    return directoryInfo.FullName;
                }
                directoryInfo = directoryInfo.Parent;
            }

            return null;
        }
    }
}
