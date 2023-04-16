using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Youtube_Observer_.Views.UserControls;

namespace Youtube_Observer_.Models
{
    public class Youtuber:Entity
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public List<Video> Videos { get; set; }
    }
}
