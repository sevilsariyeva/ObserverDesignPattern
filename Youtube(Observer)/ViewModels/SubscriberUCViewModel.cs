﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using Youtube_Observer_.Commands;
using Youtube_Observer_.Models;
using Youtube_Observer_.Views.UserControls;

namespace Youtube_Observer_.ViewModels
{
    public class SubscriberUCViewModel : BaseViewModel
    {
        public RelayCommand ExploreClickCommand { get; set; }
        public RelayCommand UnsubscribeClickCommand { get; set; }
        public RelayCommand LogoClickCommand { get; set; }
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
        private List<Youtuber> youtubers = new List<Youtuber>();

        public List<Youtuber> Youtubers
        {
            get { return youtubers; }
            set { youtubers = value; OnPropertyChanged(); }
        }

        bool IsOkay = true;
        public SubscriberUCViewModel()
        {
            ExploreClickCommand = new RelayCommand((obj) =>
            {
                var uc = new AllYoutubersUC();
                var vm = new AllYoutubersUCViewModel();
                vm.Subscriber = Subscriber;
                vm.Youtubers = Youtubers;
                uc.DataContext = vm;
                App.MyGrid.Children.RemoveAt(0);
                App.MyGrid.Children.Add(uc);
                ;
            });
            UnsubscribeClickCommand = new RelayCommand((obj) =>
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
                    Youtuber.Remove(subscriber);
                    Youtubers.Remove(Youtuber);
                    MessageBox.Show("You have been unsubscribed!");
                }
            });
            LogoClickCommand = new RelayCommand((obj) =>
            {
                var uc = new HomeUC();
                var vm = new HomeUCViewModel();
                uc.DataContext = vm;
                App.MyGrid.Children.RemoveAt(0);
                App.MyGrid.Children.Add(uc);
            });
        }
    }
}
