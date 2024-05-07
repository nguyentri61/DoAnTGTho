using DoAnTGVL.Class;
using DoAnTGVL.DAO;
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
    /// Interaction logic for UCThongTinUser.xaml
    /// </summary>
    public partial class UCThongTinUser : UserControl
    {
        User user;
        DAOUser daouser = new DAOUser();
        public UCThongTinUser(User user)
        {
            InitializeComponent();
            this.user = user;
            this.DataContext = user;
        }

        private void btn_ChinhSua_Click(object sender, RoutedEventArgs e)
        {
            daouser.Sua(user);
            new ShowDialogCustom("Cập nhật thành công", ShowDialogCustom.OK).Show();
        }
    }
}
