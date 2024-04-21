using DoAnTGVL.BUS;
using DoAnTGVL.Class;
using Microsoft.VisualStudio.Shell.Interop;
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
    /// Interaction logic for ThongBaoNhanTho.xaml
    /// </summary>
    public partial class ThongBaoNhanTho : Window
    {
        BUSThongBaoNhanTho bUSThongBaoNhanTho = new BUSThongBaoNhanTho();
        public ThongBaoNhanTho(User user)
        {
            InitializeComponent();
            bUSThongBaoNhanTho.CreateWrapThongBao(user,this);
        }
    }
}
