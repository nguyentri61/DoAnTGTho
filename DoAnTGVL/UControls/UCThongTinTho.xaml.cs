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
    /// Interaction logic for UCThongTinTho.xaml
    /// </summary>
    public partial class UCThongTinTho : UserControl
    {
        UserControl userControl;
        Tho tho;
        User user;
        public UCThongTinTho(Tho tho)
        {
            InitializeComponent();
            this.tho = tho;
            LoadCV();
        }

        public void LoadCV()
        {
            userControl = new UCHienThongTinTho(tho);
            userControl.Width = 400;
            userControl.Height = 600;
            userControl.Margin = new Thickness(10);
            // Thêm UserControl vào WrapPanel
            WpanelCV.Children.Add(userControl);
        }
    }
}
