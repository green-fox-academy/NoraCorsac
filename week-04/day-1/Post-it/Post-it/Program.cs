using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Post_it;

namespace Post_it
{
    class Program
    {
        static void Main(string[] args)
        {
            var PostIt1 = new PostIt();

            PostIt1.TextColor = "blue";
            PostIt1.BackgroundColor = "orange";
            PostIt1.Text = "Idea 1";

            var PostIt2 = new PostIt();

            PostIt2.TextColor = "black";
            PostIt2.BackgroundColor = "pink";
            PostIt2.Text = "Awesome";

            var PostIt3 = new PostIt();

            PostIt3.TextColor = "green";
            PostIt3.BackgroundColor = "Yellow";
            PostIt3.Text = "Superb!";
        }
    }
}
