using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Youtube_Observer_.Commands;
using Youtube_Observer_.Views.UserControls;

namespace Youtube_Observer_.ViewModels
{
    public class SignUpUCViewModel:BaseViewModel
    {
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value;OnPropertyChanged(); }
        }

        private string surname;

        public string Surname
        {
            get { return surname; }
            set { surname = value;OnPropertyChanged(); }
        }
        private string email;

        public string Email
        {
            get { return email; }
            set { email = value;OnPropertyChanged(); }
        }
        private string password;

        public string Password
        {
            get { return password; }
            set { password = value;OnPropertyChanged(); }
        }

        public RelayCommand SignInClickCommand { get; set; }
        public RelayCommand LogoClickCommand { get; set; }
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
        }
    }
}
