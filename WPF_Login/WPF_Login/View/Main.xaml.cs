﻿using System;
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
using WPF_Login.BL;
using WPF_Login.ViewModel;

namespace WPF_Login.View
{
    /// <summary>
    /// Main.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class Main : Window
    {
        //public PassWordCmd pswCmd { get; set; }
        public Main()
        {
            InitializeComponent();
            //pswCmd = new PassWordCmd();
            this.DataContext = new LoginViewModel();
        }
    }
}
