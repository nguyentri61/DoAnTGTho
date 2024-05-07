using DoAnTGVL.BUS;
using DoAnTGVL.Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
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
    /// Interaction logic for UCDSDanhGiaTho.xaml
    /// </summary>
    public partial class UCDSDanhGiaTho : UserControl
    {
        Tho tho;
        FilterDanhGia filterDanhGia=new FilterDanhGia();
        BUSDanhGiaTho bUSDanhGiaTho = new BUSDanhGiaTho();
        public UCDSDanhGiaTho(Tho tho)
        {
            InitializeComponent();
            this.DataContext = tho;
            this.tho = tho;
            DataContext = filterDanhGia;
            bUSDanhGiaTho.CreateWrapDanhGia(tho,filterDanhGia, this);
        }

        private void ListBoxItem_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            if (sender is ListBoxItem listBoxItem)
            {
                filterDanhGia.DanhGia = listBoxItem.Content.ToString();
            }
            bUSDanhGiaTho.CreateWrapDanhGia(tho, filterDanhGia, this);
        }

        private void CheckBox_Click(object sender, RoutedEventArgs e)
        {
            bUSDanhGiaTho.CreateWrapDanhGia(tho, filterDanhGia, this);
        }

        
    }
}
