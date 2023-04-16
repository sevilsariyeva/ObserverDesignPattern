using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Youtube_Observer_.Commands;
using Youtube_Observer_.Models;
using Youtube_Observer_.Views.UserControls;

namespace Youtube_Observer_.ViewModels
{
    public class SignInUCViewModel : BaseViewModel
    {
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
        //private Youtuber youtuber;

        //public Youtuber Youtuber
        //{
        //    get { return youtuber; }
        //    set { youtuber = value; OnPropertyChanged(); }
        //}

        public RelayCommand SubmitClickCommand { get; set; }
        public RelayCommand SignUpClickCommand { get; set; }
        public SignInUCViewModel()
        {
            SignUpClickCommand = new RelayCommand((obj) =>
            {
                var uc = new SignUpUC();
                var vm = new SignUpUCViewModel();
                uc.DataContext = vm;
                App.MyGrid.Children.RemoveAt(0);
                App.MyGrid.Children.Add(uc);
            });
            SubmitClickCommand = new RelayCommand((obj) =>
            {
                foreach (var item in App.YoutubeRepo.Youtubers)
                {
                    if (item.Email == Email && item.Password == Password)
                    {
                        var uc = new YoutuberUC();
                        var vm = new YoutuberUCViewModel();
                        vm.Youtuber = item;
                        uc.DataContext = vm;
                        App.MyGrid.Children.RemoveAt(0);
                        App.MyGrid.Children.Add(uc);
                    }
                }
                
            });
        }
    }
}
