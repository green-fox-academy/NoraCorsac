using System;

namespace UrlFixer
{
    public class UrlFixer
    {
        public static void Main(string[] args)
        {
            string url = "https//www.reddit.com/r/nevertellmethebots";

            string url2 = url.Replace("bots", "odds");

            Console.WriteLine(url2);
            Console.WriteLine("https//www.reddit.com/r/nevertellmetheodds");
            Console.WriteLine(url.Replace("bots", "odds"));
            Console.WriteLine(url.Substring(0,38) + "odds");
            Console.ReadLine();
        }
    }
}