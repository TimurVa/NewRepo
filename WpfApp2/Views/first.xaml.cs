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
    /// Логика взаимодействия для first.xaml
    /// </summary>
    public partial class first : UserControl
    {
        public first()
        {
            InitializeComponent();
            DataContext = new firstViewModel(ApplicationService.Instance.EventAggregator);
        }
    }
}
