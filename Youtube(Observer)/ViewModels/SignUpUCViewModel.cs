using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using Youtube_Observer_.Commands;
using Youtube_Observer_.Models;
using Youtube_Observer_.Views.UserControls;

namespace Youtube_Observer_.ViewModels
{
    public class SignUpUCViewModel : BaseViewModel
    {
        private Youtuber youtuber;

        public Youtuber Youtuber
        {
            get { return youtuber; }
            set { youtuber = value; OnPropertyChanged(); }
        }
        private Subscriber subscriber;

        public Subscriber Subscriber
        {
            get { return subscriber; }
            set { subscriber = value; OnPropertyChanged(); }
        }

        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; OnPropertyChanged(); }
        }

        private string surname;

        public string Surname
        {
            get { return surname; }
            set { surname = value; OnPropertyChanged(); }
        }
        private string email;

        public string Email
        {
            get { return email; }
            set { email = value; OnPropertyChanged(); }
        }
        private string password;

        public string Password
        {
            get { return password; }
            set { password = value; OnPropertyChanged(); }
        }

        public RelayCommand SignInClickCommand { get; set; }
        public RelayCommand LogoClickCommand { get; set; }
        public RelayCommand SubmitClickCommand { get; set; }
        public SignUpUCViewModel()
        {
            SignInClickCommand = new RelayCommand((obj) =>
            {
                var uc = new SignInUC();
                var vm = new SignInUCViewModel();
                uc.DataContext = vm;
                App.MyGrid.Children.RemoveAt(0);
                App.MyGrid.Children.Add(uc);
            });
            LogoClickCommand = new RelayCommand((obj) =>
            {
                var uc = new HomeUC();
                var vm = new HomeUCViewModel();
                uc.DataContext = vm;
                App.MyGrid.Children.RemoveAt(0);
                App.MyGrid.Children.Add(uc);
            });
            SubmitClickCommand = new RelayCommand((obj) =>
            {
                try
                {
                    if (Youtuber != null)
                    {
                        Youtuber.Name = Name;
                        Youtuber.Surname = Surname;
                        Youtuber.Email = Email;
                        Youtuber.Password = Password;
                        App.YoutubeRepo.Youtubers.Add(Youtuber);
                        MessageBox.Show("You are registered successfully!");
                    }
                    else
                    {
                        Subscriber.Name = Name;
                        Subscriber.Surname = Surname;
                        Subscriber.Email = Email;
                        Subscriber.Password = Password;
                        App.SubscriberRepo.Subscribers.Add(Subscriber);
                        MessageBox.Show("You are registered successfully!");
                    }

                }
                catch (Exception)
                {
                }
            });
        }
    }
}
