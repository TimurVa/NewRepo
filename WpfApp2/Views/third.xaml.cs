﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using WpfApp2.ViewModels;

namespace WpfApp2.Views
{
    /// <summary>
    /// Логика взаимодействия для third.xaml
    /// </summary>
    public partial class third : UserControl
    {
        public third()
        {
            InitializeComponent();
            DataContext = new thirdViewModel();
        }
    }
}
