using Prism.Events;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Text;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using WpfApp2.Commands.BaseCommand;
using WpfApp2.Helpers;

namespace WpfApp2.ViewModels
{
    public class thirdViewModel : BaseViewModel
    {

        #region Properties
        public IEventAggregator eventAggregator;
        private AreaToAddThird _areaToAddThird;
        public AreaToAddThird AreaToAddThird
        {
            get
            {
                return _areaToAddThird;
            }
            set
            {
                _areaToAddThird = value;
                OnPropertyChanged();
            }
        }
        #endregion

        #region Constructor
        public thirdViewModel()
        {
            AreaToAddThird = new AreaToAddThird(ApplicationService.Instance.EventAggregator);
        }

        #endregion

        #region Command initialize
        private ICommand _resetCommand;
        public ICommand ResetCommand => _resetCommand ?? (new RelayCommand(ResetCommand_Executed));
        private ICommand _addTextCommand;
        public ICommand AddTextCommand => _addTextCommand ?? (new RelayCommand(AddTextCommand_Executed));
        private ICommand _resetTextOnMouseDownCommand;
        public ICommand ResetTextOnMouseDownCommand => _resetTextOnMouseDownCommand ?? (new RelayCommand(ResetTextOnMouseDownCommand_Executed));
        private ICommand _addImageCommand;
        public ICommand AddImageCommand => _addImageCommand ?? (new RelayCommand(AddImageCommand_Executed));
        #endregion

        #region Command Methods
        private void ResetCommand_Executed(object obj)
        {
           // AreaToAdd.stack.Children.Clear();
        }
        private void AddTextCommand_Executed(object obj)
        {
            //AreaToAdd.stack.Children.Clear();
            TextBlock text1 = new TextBlock();
           // text1.Text = this.text;
          //  AreaToAdd.stack.Children.Add(text1);
        }
        private void ResetTextOnMouseDownCommand_Executed(object obj)
        {
         //   this.text = "";
        }
        private void AddImageCommand_Executed(object obj)
        {

            Image image = new Image();
            image.Source = new BitmapImage(new Uri(@"/resources/test.jpg", UriKind.Relative));
            image.Width = 50;
            image.Height = 50;
           // AreaToAdd.stack.Children.Add(image);
        }
        #endregion
    }
}
