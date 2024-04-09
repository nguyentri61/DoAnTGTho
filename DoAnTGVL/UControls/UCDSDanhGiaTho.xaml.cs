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
    /// Interaction logic for UCDSDanhGiaTho.xaml
    /// </summary>
    public partial class UCDSDanhGiaTho : UserControl
    {
        Tho tho;
        User user;
        BUSDanhGiaTho bUSDanhGiaTho = new BUSDanhGiaTho();
        public UCDSDanhGiaTho(Tho tho, User user)
        {
            InitializeComponent();
            this.DataContext = tho;
            this.user = user;
            this.tho = tho;
            bUSDanhGiaTho.CreateWrapDanhGia(tho, user, this);
        }
    }
}
