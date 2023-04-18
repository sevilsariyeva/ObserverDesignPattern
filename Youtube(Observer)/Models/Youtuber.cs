using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Youtube_Observer_.Views.UserControls;
using static Youtube_Observer_.ViewModels.YoutuberUCViewModel;

namespace Youtube_Observer_.Models
{
    public class Youtuber : Entity, ISubject
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public List<Video> Videos { get; set; }
        public List<Subscriber> Subscribers { get; set; } = new List<Subscriber>();

        public void Add(Subscriber subscriber)
        {
            Subscribers.Add(subscriber);
        }

        public void Notify()
        {
            throw new NotImplementedException();
        }

        public void Remove(Subscriber subscriber)
        {
            Subscribers.Remove(subscriber);
        }

        public void Update(string videoTitle)
        {
            throw new NotImplementedException();
        }
    }
}
