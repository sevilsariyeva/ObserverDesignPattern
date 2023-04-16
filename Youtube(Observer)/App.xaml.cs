using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using Youtube_Observer_.Repositories;

namespace Youtube_Observer_
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public static Grid MyGrid { get; set; }
        public static YoutuberRepository YoutubeRepo { get; set; }
        public static SubscriberRepository SubscriberRepo { get; set; }
        public App()
        {
            YoutubeRepo=new YoutuberRepository();
            SubscriberRepo = new SubscriberRepository();
        }
    }
}
