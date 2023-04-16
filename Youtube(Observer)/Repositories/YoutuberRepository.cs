using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Youtube_Observer_.Helpers;
using Youtube_Observer_.Models;

namespace Youtube_Observer_.Repositories
{
    public class YoutuberRepository
    {
        public List<Youtuber> Youtubers { get; set; }

        public YoutuberRepository()
        {
            if (!File.Exists("youtubers.json"))
            {
                Youtubers = new List<Youtuber>
                {
                    new Youtuber
                    {
                        Id = 1,
                        Name="Sevil",
                        Surname="Sariyeva",
                        Email="sevilsariyeva@gmail.com",
                        Password="Sevil123",
                        Videos=new List<Video>
                        {
                            new Video
                            {
                                Id=1,
                                Name="WPF Cinema Management (ParkCinema)",
                                CoverPhoto="/Images/prestij.jpg",
                                Link="https://youtu.be/28dC547iMAc"
                            }
                        }
                    }
                };
                FileHelper.WriteYoutubers(Youtubers);
            }
            else
            {
                Youtubers=FileHelper.ReadYoutubers();
            }
        }
    }
}
