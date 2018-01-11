using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SayHelloToAll.Models
{
    public class Greeting
    {
        public string Content { get; set; }

        public Greeting(string name, int counter)
        {
            Content = "Hello," + name;
        }

        public Greeting(int webcounter, string name)
        {
            Content = "Hello," + name + "! This site was loaded " + webcounter + " times since last server start.";
        }

        public Greeting()
        {
        }
    }
}
