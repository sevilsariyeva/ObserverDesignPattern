using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Xml;
using Youtube_Observer_.Models;
using Formatting = Newtonsoft.Json.Formatting;

namespace Youtube_Observer_.Helpers
{
    public class FileHelper
    {
        public static void WriteYoutubers(List<Youtuber> youtubers)
        {
            var serializer = new JsonSerializer();

            using (var sw = new StreamWriter("youtubers.json"))
            {
                using (var jw = new JsonTextWriter(sw))
                {
                    jw.Formatting = Formatting.Indented;
                    serializer.Serialize(jw, youtubers);
                }
            }
        }
        public static List<Youtuber> ReadYoutubers()
        {
            List<Youtuber> youtubers = null;
            var serializer = new JsonSerializer();
            using (var sr = new StreamReader("youtubers.json"))
            {
                using (var jr = new JsonTextReader(sr))
                {
                    youtubers = serializer.Deserialize<List<Youtuber>>(jr);
                }
            }
            return youtubers;
        }
        public static void WriteSubscribers(List<Subscriber> subscribers)
        {
            var serializer = new JsonSerializer();

            using (var sw = new StreamWriter("subscribers.json"))
            {
                using (var jw = new JsonTextWriter(sw))
                {
                    jw.Formatting = Formatting.Indented;
                    serializer.Serialize(jw, subscribers);
                }
            }
        }
        public static List<Subscriber> ReadSubscribers()
        {
            List<Subscriber> subscribers = null;
            var serializer = new JsonSerializer();
            using (var sr = new StreamReader("subscribers.json"))
            {
                using (var jr = new JsonTextReader(sr))
                {
                    subscribers = serializer.Deserialize<List<Subscriber>>(jr);
                }
            }
            return subscribers;
        }
    }
}
