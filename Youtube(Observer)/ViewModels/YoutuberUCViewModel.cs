using Microsoft.Web.WebView2.Wpf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using Youtube_Observer_.Commands;
using Youtube_Observer_.Models;
using Youtube_Observer_.Views.UserControls;
using static Youtube_Observer_.ViewModels.YoutuberUCViewModel;

namespace Youtube_Observer_.ViewModels
{
    public class YoutuberUCViewModel : BaseViewModel
    {
        public RelayCommand LogoClickCommand { get; set; }
        public RelayCommand ShowClickCommand { get; set; }
        public RelayCommand VideosClickCommand { get; set; }
        private Youtuber youtuber;
        public Youtuber Youtuber
        {
            get { return youtuber; }
            set { youtuber = value; OnPropertyChanged(); }
        }
        private Visibility listBoxVisibility=Visibility.Visible;

        public Visibility ListBoxVisibility
        {
            get { return listBoxVisibility; }
            set { listBoxVisibility = value; OnPropertyChanged(); }
        }

        private Visibility allVisibility=Visibility.Hidden;

        public Visibility AllVisibility
        {
            get { return allVisibility; }
            set { allVisibility = value; OnPropertyChanged(); }
        }

        private List<Subscriber> subscribers1;

        public List<Subscriber> Subscribers
        {
            get { return subscribers1; }
            set { subscribers1 = value; OnPropertyChanged(); }
        }

        private List<ISubscriber> subscribers = new List<ISubscriber>();

        // Subscribe a new user
        public void Subscribe(ISubscriber subscriber)
        {
            subscribers.Add(subscriber);
        }

        // Unsubscribe a user
        public void Unsubscribe(ISubscriber subscriber)
        {
            subscribers.Remove(subscriber);
        }

        // Notify all subscribers when a new video is uploaded
        public void NotifySubscribers(string videoTitle)
        {
            foreach (ISubscriber subscriber in subscribers)
            {
                subscriber.Update(videoTitle);
            }
        }

        // Define the observer (user)
        public interface ISubscriber
        {
            void Update(string videoTitle);
        }
        public interface ISubject : ISubscriber
        {
            void Add(Subscriber subscriber);
            void Remove(Subscriber subscriber);
            void Notify();
        }
        public YoutuberUCViewModel()
        {
            ListBoxVisibility = Visibility.Visible;
            AllVisibility = Visibility.Hidden;
            LogoClickCommand = new RelayCommand((obj) =>
            {
                var uc = new HomeUC();
                var vm = new HomeUCViewModel();
                uc.DataContext = vm;
                App.MyGrid.Children.RemoveAt(0);
                App.MyGrid.Children.Add(uc);
            });
            ShowClickCommand = new RelayCommand((obj) =>
            {
                ListBoxVisibility = Visibility.Hidden;
                AllVisibility = Visibility.Visible;
            });
            VideosClickCommand = new RelayCommand((obj) =>
            {
                ListBoxVisibility = Visibility.Visible;
                AllVisibility = Visibility.Hidden;
            });
            
        }
    }
}
