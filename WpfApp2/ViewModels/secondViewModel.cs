using Prism.Events;
using System;
using System.Collections.Generic;
using System.Text;
using WpfApp2.Helpers.ContentPresenter;

namespace WpfApp2.ViewModels
{
    public class secondViewModel : BaseViewModel
    {
        public IEventAggregator eventAggregator;
        private AreaToAddSecond _areaToAddSecond;
        public AreaToAddSecond AreaToAddSecond
        {
            get
            {
                return _areaToAddSecond;
            }
            set
            {
                _areaToAddSecond = value;
                OnPropertyChanged();
            }
        }
        public secondViewModel()
        {
            AreaToAddSecond = new AreaToAddSecond(ApplicationService.Instance.EventAggregator);
        }
    }
}
