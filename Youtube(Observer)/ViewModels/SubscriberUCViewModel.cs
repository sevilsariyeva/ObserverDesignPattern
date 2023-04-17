using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Youtube_Observer_.Commands;
using Youtube_Observer_.Models;

namespace Youtube_Observer_.ViewModels
{
    public class SubscriberUCViewModel:BaseViewModel
    {
        private Subscriber subscriber;

        public Subscriber Subscriber
        {
            get { return subscriber; }
            set { subscriber = value; OnPropertyChanged(); }
        }

        public SubscriberUCViewModel()
        {

        }
    }
}
