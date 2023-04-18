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
    public class ChoiceUCViewModel:BaseViewModel
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
        public RelayCommand SignInClickCommand { get; set; }
        public RelayCommand SignUpClickCommand { get; set; }
        public RelayCommand LogoClickCommand { get; set; }
        public ChoiceUCViewModel()
        {
            SignInClickCommand = new RelayCommand((obj) =>
            {
                var uc = new SignInUC();
                var vm = new SignInUCViewModel();
                uc.DataContext = vm;
                App.MyGrid.Children.RemoveAt(0);
                App.MyGrid.Children.Add(uc);
            });
            SignUpClickCommand = new RelayCommand((obj) =>
            {
                var uc = new SignUpUC();
                var vm = new SignUpUCViewModel();
                vm.Subscriber = Subscriber;
                vm.Youtuber = Youtuber;
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
        }
    }
}
