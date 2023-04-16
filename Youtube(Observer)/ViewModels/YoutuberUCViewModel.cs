using Microsoft.Web.WebView2.Wpf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using Youtube_Observer_.Commands;
using Youtube_Observer_.Models;

namespace Youtube_Observer_.ViewModels
{
    public class YoutuberUCViewModel : BaseViewModel
    {
        private Visibility webViewVisibility;

        public Visibility WebViewVisibility
        {
            get { return webViewVisibility; }
            set { webViewVisibility = value; OnPropertyChanged(); }
        }
        private Visibility listboxVisibility;

        public Visibility ListBoxVisibility
        {
            get { return listboxVisibility; }
            set { listboxVisibility = value;OnPropertyChanged(); }
        }

        public RelayCommand MovieClickCommand { get; set; }

        private Youtuber youtuber;

        public Youtuber Youtuber
        {
            get { return youtuber; }
            set { youtuber = value; OnPropertyChanged(); }
        }
        public YoutuberUCViewModel()
        {
            WebViewVisibility = Visibility.Hidden;
            MovieClickCommand = new RelayCommand((obj) =>
            {
                WebViewVisibility = Visibility.Visible;
                ListBoxVisibility = Visibility.Hidden;
            });

        }
    }
}
