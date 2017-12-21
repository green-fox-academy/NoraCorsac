using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreenFoxOrganization
{
    class Mentor : Person
    {
        public Mentor(string name, int age, string gender, string level) : base(name, age, gender)
        {
            public string Level { get; set; }
        }

    }
}
    public override void GetGoal()
        {
            Console.WriteLine("Educate brilliant junior software developers.");
        }

        public override void Introduce()
        {
            Console.WriteLine("Hi, I'm {0}, a {1} year old {2} {3} mentor."  );
        }
    
}
