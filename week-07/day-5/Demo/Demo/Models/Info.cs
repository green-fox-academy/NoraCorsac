using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Demo.Models
{
    public class Info
    {
        public string Content { get; set; }

        public Info(string name)
        {
            Content = "Hello, Pista!";
        }
    }
}
