using Prism.Events;
using System;
using System.Collections.Generic;
using System.ComponentModel;
//using System.Drawing;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Controls;
using System.Windows.Markup;
using WpfApp2.Helpers.SubscriberClasses;

namespace WpfApp2.Models
{
    public class ApiModel : INotifyPropertyChanged
    {
        private string _text;
        public string Text
        {
            get
            {
                return _text;
            }
            set
            {
                _text = value;
                OnPropertyChanged();
            }
        }
        private Image _image;
        public Image Image
        {
            get
            {
                return _image;
            }
            set
            {
                _image = value;
                OnPropertyChanged();
            }
        }

        public ApiModel()
        {
        }


        #region First view
        public void ClearTextInFirstView()
        {
            this.Text = string.Empty;
            ApplicationService.Instance.EventAggregator.GetEvent<SubscriberFirst>().Publish(this.Text);
        }

        public void AddTextInFirstView(string Text)
        {
            this.Text = Text;
            ApplicationService.Instance.EventAggregator.GetEvent<SubscriberFirst>().Publish(this.Text);
            //this.Text = string.Empty;
        }

        public void ClearImageInFirstView()
        {
            this.Image = null;
            ApplicationService.Instance.EventAggregator.GetEvent<SubscriberImageFirst>().Publish(this.Image);
        }

        public void AddImageInFirstView(Image image)
        {
            this.Image = image;
            ApplicationService.Instance.EventAggregator.GetEvent<SubscriberImageFirst>().Publish(this.Image);
           // this.Image = null;
        }

        public void ClearAllInFirstView()
        {
            ApplicationService.Instance.EventAggregator.GetEvent<SubscriberClearAllFirst>().Publish();
        }
        #endregion First view


        #region Second view

        public void ClearTextInSecondView()
        {
            this.Text = string.Empty;
            ApplicationService.Instance.EventAggregator.GetEvent<SubscriberTextSecond>().Publish(this.Text);
        }

        public void AddTextInSecondView(string Text)
        {
            this.Text = Text;
            ApplicationService.Instance.EventAggregator.GetEvent<SubscriberTextSecond>().Publish(this.Text);
            //this.Text = string.Empty;
        }

        public void ClearImageInSecondView()
        {
            this.Image = null;
            ApplicationService.Instance.EventAggregator.GetEvent<SubscriberImageSecond>().Publish(this.Image);
        }

        public void AddImageInSecondView(Image image)
        {
            this.Image = image;
            ApplicationService.Instance.EventAggregator.GetEvent<SubscriberImageSecond>().Publish(this.Image);
            // this.Image = null;
        }

        public void ClearAllInSecondView()
        {
            ApplicationService.Instance.EventAggregator.GetEvent<SubscriberClearAllSecond>().Publish();
        }
            #endregion


        #region Third view 
        public void ClearTextInThirdView()
        {
            this.Text = string.Empty;
            ApplicationService.Instance.EventAggregator.GetEvent<SubscriberTextThird>().Publish(this.Text);
        }

        public void AddTextInThirdView(string Text)
        {
            this.Text = Text;
            ApplicationService.Instance.EventAggregator.GetEvent<SubscriberTextThird>().Publish(this.Text);
            //this.Text = string.Empty;
        }

        public void ClearImageInThirdView()
        {
            this.Image = null;
            ApplicationService.Instance.EventAggregator.GetEvent<SubscriberImageThird>().Publish(this.Image);
        }

        public void AddImageInThirdView(Image image)
        {
            this.Image = image;
            ApplicationService.Instance.EventAggregator.GetEvent<SubscriberImageThird>().Publish(this.Image);
            this.Image = null;
        }

        public void ClearAllInThirdView()
        {
            ApplicationService.Instance.EventAggregator.GetEvent<SubscriberClearAllThird>().Publish();
        }
        #endregion


        #region INOTIFY

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName]string prop = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
        }
        #endregion
    }
}
