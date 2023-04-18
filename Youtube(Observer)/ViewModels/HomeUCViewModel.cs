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
    public class HomeUCViewModel : BaseViewModel
    {
        public RelayCommand YoutuberClickCommand { get; set; }
        public RelayCommand SubscriberClickCommand { get; set; }
        public HomeUCViewModel()
        {
            YoutuberClickCommand = new RelayCommand((obj) =>
            {
                var uc = new ChoiceUC();
                var vm = new ChoiceUCViewModel();
                vm.Youtuber = new Youtuber();
                uc.DataContext = vm;
                App.MyGrid.Children.RemoveAt(0);
                App.MyGrid.Children.Add(uc);
            });
            SubscriberClickCommand = new RelayCommand((obj) =>
            {
                var uc = new ChoiceUC();
                var vm = new ChoiceUCViewModel();
                vm.Subscriber = new Subscriber();
                uc.DataContext = vm;
                App.MyGrid.Children.RemoveAt(0);
                App.MyGrid.Children.Add(uc);
            });
        }
    }
}
