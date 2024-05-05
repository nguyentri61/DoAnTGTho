using DoAnTGVL.BUS;
using DoAnTGVL.Class;
using LiveCharts;
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
    /// Interaction logic for UCThongKeCV.xaml
    /// </summary>
    public partial class UCThongKeCV : UserControl
    {
        BUSThongKe bUSThongKe = new BUSThongKe();
        List<int> tkCongViec;
        string thang = DateTime.Now.Month.ToString();
        Tho tho;
        public UCThongKeCV(Tho tho)
        {
            InitializeComponent();
            DataContext = this;
            this.tho= tho;
            LoadChart();
        }

        public Func<ChartPoint, string> PointLabel { get; set; }
        private void cboThang_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            thang = (cboThang.SelectedItem != null) ? (cboThang.SelectedItem as ComboBoxItem).Content.ToString() : DateTime.Now.Month.ToString();
            LoadChart();
        }
        private void LoadChart()
        {
            tkCongViec = bUSThongKe.GetCongViec(tho, thang);
            ChartValues<int> pieValues = new ChartValues<int> { tkCongViec[0] };
            pieCth.Values = pieValues;
            pieValues = new ChartValues<int> { tkCongViec[1] };
            pieDangth.Values = pieValues;
            pieValues = new ChartValues<int> { tkCongViec[2] };
            pieDath.Values = pieValues;

            PointLabel = chartPoint =>
                string.Format("{0} ({1:P})", chartPoint.Y, chartPoint.Participation);
        }
    }
}
