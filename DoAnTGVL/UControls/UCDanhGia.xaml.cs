﻿using DoAnTGVL.Class;
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
    /// Interaction logic for UCDanhGia.xaml
    /// </summary>
    /// 
    public partial class UCDanhGia : UserControl
    {
        DanhGia danhGia=new DanhGia();
        public UCDanhGia()
        {
            InitializeComponent();
            
            DataContext = danhGia;
        }
    }
}
