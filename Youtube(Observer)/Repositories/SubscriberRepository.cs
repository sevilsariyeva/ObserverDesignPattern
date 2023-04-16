using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Youtube_Observer_.Helpers;
using Youtube_Observer_.Models;

namespace Youtube_Observer_.Repositories
{
    public class SubscriberRepository
    {
        public List<Subscriber> Subscribers { get; set; }

        public SubscriberRepository()
        {
            if (!File.Exists("subscribers.json"))
            {
                Subscribers = new List<Subscriber>
                {
                    new Subscriber
                    {
                        Id = 1,
                        Name="Aysel",
                        Surname="Mammadli",
                        Email="ayselmammadli@gmail.com",
                        Password="Aysel123"
                    }
                };
                FileHelper.WriteSubscribers(Subscribers);
            }
            else
            {
                Subscribers = FileHelper.ReadSubscribers();
            }
        }
    }
}
