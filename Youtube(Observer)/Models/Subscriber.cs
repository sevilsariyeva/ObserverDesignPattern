﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Youtube_Observer_.ViewModels;
using static Youtube_Observer_.ViewModels.YoutuberUCViewModel;

namespace Youtube_Observer_.Models
{
    public class Subscriber:Entity,ISubscriber
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public List<Youtuber> Youtubers { get; set; } = new List<Youtuber>{};

        public void Update(string videoTitle)
        {
            throw new NotImplementedException();
        }
    }
}
