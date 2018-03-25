using System;
using System.Collections.Generic;
using System.Text;

namespace FindFox
{
    class Fox
    {
        public string Name { get; set; }
        public string Color { get; set; }
        public string Type { get; set; }

        public Fox(string name, string color, string type)
        {
            Name = name;
            Color = color;
            Type = type;
        }
    }
}
