using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using Youtube_Observer_.Commands;
using Youtube_Observer_.Models;
using Youtube_Observer_.Views.UserControls;
using static Youtube_Observer_.ViewModels.YoutuberUCViewModel;

namespace Youtube_Observer_.ViewModels
{
    public class AllYoutubersUCViewModel : BaseViewModel
    {
        public RelayCommand SubscribeClickCommand { get; set; }
        public RelayCommand BackClickCommand { get; set; }
        private Subscriber subscriber;

        public Subscriber Subscriber
        {
            get { return subscriber; }
            set { subscriber = value; OnPropertyChanged(); }
        }
        private Youtuber youtuber;

        public Youtuber Youtuber
        {
            get { return youtuber; }
            set { youtuber = value; OnPropertyChanged(); }
        }

        private List<Youtuber> allyoutubers;

        public List<Youtuber> AllYoutubers
        {
            get { return allyoutubers; }
            set { allyoutubers = value; OnPropertyChanged(); }
        }
        private List<Youtuber> youtubers;

        public List<Youtuber> Youtubers
        {
            get { return youtubers; }
            set { youtubers = value; OnPropertyChanged(); }
        }
        bool IsOkay = true;
        public AllYoutubersUCViewModel()
        {
            AllYoutubers = App.YoutubeRepo.Youtubers;
            SubscribeClickCommand = new RelayCommand((obj) =>
            {
                var grid = obj as Grid;
                foreach (var child in grid.Children)
                {
                    if (child is Label label)
                    {
                        foreach (var item in App.YoutubeRepo.Youtubers)
                        {
                            if (label.Content.ToString() == item.Name || label.Content.ToString() == item.Surname)
                            {
                                Youtuber = item;
                                IsOkay = true;
                                break;
                            }
                            else
                            {
                                IsOkay = false;
                            }
                        }
                    }
                }
                if (IsOkay)
                {
                    Youtuber.Add(subscriber);
                    Youtubers.Add(Youtuber);
                    MessageBox.Show("You have been subscribed!");
                }
            });
            BackClickCommand = new RelayCommand((obj) =>
            {
                var uc = new SubscriberUC();
                var vm = new SubscriberUCViewModel();
                vm.Subscriber = Subscriber;
                vm.Youtubers = Youtubers;
                uc.DataContext = vm;
                App.MyGrid.Children.RemoveAt(0);
                App.MyGrid.Children.Add(uc);
            });
        }
    }
}
