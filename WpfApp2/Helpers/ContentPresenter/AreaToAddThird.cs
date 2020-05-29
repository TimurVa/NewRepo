using Prism.Events;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Controls;
using WpfApp2.Helpers.SubscriberClasses;

namespace WpfApp2.Helpers
{
    public class AreaToAddThird : Canvas, INotifyPropertyChanged
    {
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
            }
        }

        private TextBlock _text;
        public TextBlock TextBlock
        {
            get
            {
                return _text;
            }
            set
            {
                _text = value;
            }
        }
        public ObservableCollection<TextBlock> textBlocks;
        public ObservableCollection<Image> images;

        public StackPanel stack = new StackPanel();

        public AreaToAddThird(IEventAggregator eventAggregator)
        {
            this.Children.Add(stack);

            textBlocks = new ObservableCollection<TextBlock>();
            textBlocks.CollectionChanged += TextBlocks_CollectionChanged;

            images = new ObservableCollection<Image>();
            images.CollectionChanged += Images_CollectionChanged;

            eventAggregator.GetEvent<SubscriberTextThird>().Subscribe(ReciveText);
            eventAggregator.GetEvent<SubscriberImageThird>().Subscribe(ReciveImage);
            eventAggregator.GetEvent<SubscriberClearAllThird>().Subscribe(ClearAll);
        }

        private void Images_CollectionChanged(object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        {
            switch (e.Action)
            {
                case System.Collections.Specialized.NotifyCollectionChangedAction.Add:
                    {
                        this.stack.Children.Add((Image)e.NewItems[0]);
                    }
                    break;
                case System.Collections.Specialized.NotifyCollectionChangedAction.Remove:
                    {
                        this.stack.Children.Remove((Image)e.OldItems[0]);
                    }
                    break;
            }
        }

        private void TextBlocks_CollectionChanged(object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        {
            switch (e.Action)
            {
                case System.Collections.Specialized.NotifyCollectionChangedAction.Add:
                    {
                        this.stack.Children.Add((TextBlock)e.NewItems[0]);
                    }
                    break;
                case System.Collections.Specialized.NotifyCollectionChangedAction.Remove:
                    {
                        this.stack.Children.Remove((TextBlock)e.OldItems[0]);
                    }
                    break;
            }
        }

        public void ReciveText(string parameter)
        {
            if (parameter != "")
            {

                TextBlock = new TextBlock();
                TextBlock.Text = parameter;
                this.textBlocks.Add(TextBlock);
            }
            else
            {
                this.textBlocks.Remove(TextBlock);
            }
        }
        public void ReciveImage(Image parameter)
        {
            if (parameter != null)
            {
                Image = parameter;
                this.images.Add(Image);
            }
            else
            {
                this.images.Remove(Image);
            }
        }

        public void ClearAll()
        {
            var j = this.textBlocks.Count;
            var k = this.images.Count;
            for (var i = 0; i < j; i++)
            {
                this.textBlocks.RemoveAt(i);
            }
            for (var i = 0; i < k; i++)
            {
                this.images.RemoveAt(0);
            }
        }

        #region INOTIFY members
        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName]string prop = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
        }
        #endregion
    }
}
