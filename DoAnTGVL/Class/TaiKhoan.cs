using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace DoAnTGVL.Class
{
    public class TaiKhoan : INotifyPropertyChanged
    {
        private int id=0;
        private int role=1;
        private string logName="";
        private string pass = "";

        public TaiKhoan() { }   

        public TaiKhoan(int id, int role, string lognamme, string pass)
        {
            this.id = id;
            this.role = role;
            this.logName = lognamme;
            this.pass = pass;
        }

        public int Id { get => id; set => id = value; }
        public int Role { get => role; set => role = value; }
        public string LogName {
            get { return logName; }
            set
            {
                if (logName != value)
                {
                    logName = value;
                    OnPropertyChanged(nameof(LogName));
                }
            }
        }
        public string Pass {
            get { return pass; }
            set
            {
                if (pass != value)
                {
                    pass = value;
                    OnPropertyChanged(nameof(Pass));
                }
            }
        }
        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        public bool CheckEmpty()
        {
            if (LogName != "" && Pass != "")
                return true; 
            else
                return false;
        }
    }
}
