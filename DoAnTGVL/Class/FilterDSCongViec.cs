using DoAnTGVL.DAO;
using DoAnTGVL.UControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnTGVL.Class
{
    public class FilterDSCongViec : INotifyPropertyChanged
    {
        private bool daHoanThanh = false;
        private bool dangThucHien = false;
        private bool chuaThucHien = false;
        private string tieuDe = "";

        public bool DaHoanThanh { get => daHoanThanh; set => daHoanThanh = value; }
        public bool DangThucHien { get => dangThucHien; set => dangThucHien = value; }
        public bool ChuaThucHien { get => chuaThucHien; set => chuaThucHien = value; }
        public string TieuDe { get => tieuDe; set { tieuDe = value; OnPropertyChanged("TieuDe"); } }

        public event PropertyChangedEventHandler? PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            if ((PropertyChanged != null))
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }

        }

        public bool checkemp()
        {
            if (daHoanThanh == false && dangThucHien == false && chuaThucHien == false && tieuDe == "")
                return true;
            return false;
        }
        public void reset()
        {
            daHoanThanh = false;
            dangThucHien = false;
            chuaThucHien = false;
            tieuDe = "";
        }
    }
}
