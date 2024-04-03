using DoAnTGVL.UControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnTGVL.Class
{
    public class Filter : INotifyPropertyChanged
    {
        private string khuVuc = "";
        private string kinhNghiem = "";
        private string ten = "";
        private string giatien = "";

        public string KhuVuc { get => khuVuc; set => khuVuc = value; }
        public string KinhNghiem { get => kinhNghiem; set => kinhNghiem = value; }
        public string Ten { get => ten; set { ten = value; OnPropertyChanged("Ten"); } }
        public string Giatien { get => giatien; set => giatien = value; }

        public event PropertyChangedEventHandler? PropertyChanged;

        virtual public bool checkemp()
        {
            if(khuVuc == "" && kinhNghiem == "" && Ten=="" && Giatien=="")
                return true;
            return false;
        }

        
        protected virtual void OnPropertyChanged(string propertyName)
        {
            if ((PropertyChanged != null))
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }

        }
        virtual public void reset()
        {
            KhuVuc = "";
            KinhNghiem = "";
            Ten = "";

        }
        public  string chuyenDoiGiaTien()
        {
            string converted = Giatien;

            // Chuyển đổi 'dưới' thành '<'
            converted = converted.Replace("Dưới 200.00đ", " < 200000");

            // Chuyển đổi 'Trên' thành '>'
            converted = converted.Replace("Trên 800.000đ", " > 800000");

            // Chuyển đổi 'between and'
            converted = converted.Replace("200.000đ - 400.000đ", " between 200000 and 400000");
            converted = converted.Replace("400.000đ - 600.000đ", " between 400000 and 600000");
            converted = converted.Replace("600.000đ - 800.000đ", " between 600000 and 800000");

            return converted;
        }
    }
}
