using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Youtube_Observer_.Models
{
    public class Video:Entity
    {
        public string Name { get; set; }
        public string Link { get; set; }
        public string CoverPhoto { get; set; }
        
    }
}
