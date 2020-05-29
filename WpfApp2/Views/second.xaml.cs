using System;
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
    /// Логика взаимодействия для second.xaml
    /// </summary>
    public partial class second : UserControl
    {
        public second()
        {
            InitializeComponent();
            DataContext = new secondViewModel();
        }
    }
}
