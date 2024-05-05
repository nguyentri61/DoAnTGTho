using DoAnTGVL.BUS;
using DoAnTGVL.Class;
using LiveCharts;
using System;
using System.Collections.Generic;
using System.ComponentModel;
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

namespace DoAnTGVL
{
    /// <summary>
    /// Interaction logic for UCThongKeTN.xaml
    /// </summary>
    public partial class UCThongKeTN : UserControl
    {
        BUSThongKe bUSThongKe = new BUSThongKe();
        Tho tho;
        public UCThongKeTN(Tho tho)
        {
            InitializeComponent();
            DataContext = this;
            this.tho = tho;
            LoadIncomeData();
        }

        private void LoadIncomeData()
        {

            // Tạo một danh sách chứa thu nhập của 12 tháng
            List<int> incomeData = bUSThongKe.GetThuNhap(tho);

            // Tạo danh sách nhãn cho các tháng
            Labels = new List<string> { "Tháng 1", "Tháng 2", "Tháng 3", "Tháng 4", "Tháng 5", "Tháng 6", "Tháng 7", "Tháng 8", "Tháng 9", "Tháng 10", "Tháng 11", "Tháng 12" };

            // Gán giá trị thu nhập cho biểu đồ
            IncomeValues = new ChartValues<int>(incomeData);
        }
        public event PropertyChangedEventHandler PropertyChanged;

        private List<string> _labels;
        public List<string> Labels
        {
            get { return _labels; }
            set
            {
                _labels = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Labels"));
            }
        }

        private ChartValues<int> _incomeValues;
        public ChartValues<int> IncomeValues
        {
            get { return _incomeValues; }
            set
            {
                _incomeValues = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("IncomeValues"));
            }
        }
    }
}