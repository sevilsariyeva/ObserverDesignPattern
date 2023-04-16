using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Youtube_Observer_.Commands;

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

            });
            SubscriberClickCommand = new RelayCommand((obj) =>
            {

            });
        }
    }
}
