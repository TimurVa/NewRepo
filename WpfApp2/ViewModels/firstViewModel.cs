using Prism.Events;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media.Imaging;
using WpfApp2.Commands.BaseCommand;
using WpfApp2.Helpers;
using WpfApp2.Models;

namespace WpfApp2.ViewModels
{
    public class firstViewModel : BaseViewModel
    {
        #region Properties

        public IEventAggregator eventAggregator;

        private AreaToAdd _areaToAdd;
        public AreaToAdd AreaToAdd
        {
            get
            {
                return _areaToAdd;
            }
            set
            {
                _areaToAdd = value;
                OnPropertyChanged();
            }
        }
        #endregion

        #region Constructor

        public firstViewModel(IEventAggregator eventAggregator)
        {
            AreaToAdd = new AreaToAdd(eventAggregator);
            //text = "Dummy text";
        }
        #endregion

        #region Commands init
        private ICommand _resetCommand;
        public ICommand ResetCommand => _resetCommand ?? (new RelayCommand(ResetCommand_Executed));

        private ICommand _addTextCommand;
        public ICommand AddTextCommand => _addTextCommand ?? (new RelayCommand(AddTextCommand_Executed));

        private ICommand _resetTextOnMouseDownCommand;
        public ICommand ResetTextOnMouseDownCommand => _resetTextOnMouseDownCommand ?? (new RelayCommand(ResetTextOnMouseDownCommand_Executed));
        
        private ICommand _addImageCommand;
        public ICommand AddImageCommand => _addImageCommand ?? (new RelayCommand(AddImageCommand_Executed));
        #endregion

        #region Commands Methods
        private void ResetCommand_Executed(object obj)
        {
            AreaToAdd.stack.Children.Clear();
        }

        private void AddTextCommand_Executed(object obj)
        {
            AreaToAdd.stack.Children.Clear();
            TextBlock text1 = new TextBlock();
           // text1.Text = this.text;
            AreaToAdd.stack.Children.Add(text1);
        }

        private void ResetTextOnMouseDownCommand_Executed(object obj)
        {
          //  _text = "";
        }
        private void AddImageCommand_Executed(object obj)
        {
            AreaToAdd.stack.Children.Clear();
            Image image = new Image();

            image.Source = new BitmapImage(new Uri(@"/Resources/test.jpg", UriKind.Relative));

            image.Width = 50;
            image.Height = 50;
            AreaToAdd.stack.Children.Add(image);
        }

        #endregion
    }
}
