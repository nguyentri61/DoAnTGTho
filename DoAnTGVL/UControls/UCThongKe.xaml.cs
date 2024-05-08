using DoAnTGVL.Class;
using LiveCharts.Wpf;
using LiveCharts;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
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
using System.Windows.Media.Media3D;
using System.Windows.Navigation;
using System.Windows.Shapes;
using DoAnTGVL.BUS;

namespace DoAnTGVL.UControls
{
    /// <summary>
    /// Interaction logic for UCThongKe.xaml
    /// </summary>
    public partial class UCThongKe : UserControl
    {
        
        public UCThongKe(Tho tho)
        {
            InitializeComponent();
            //MessageBox.Show(tho.HoTen);
            UCThongKeCV uCThongKeCV = new UCThongKeCV(tho);
            grdTkCongViec.Children.Add(uCThongKeCV);
            UCThongKeTN uCThongKeTN = new UCThongKeTN(tho);
            grdTkThuNhap.Children.Add(uCThongKeTN);

        }    
    }
}