using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BlogPost;

namespace BlogPost
{
    class Program
    {
        static void Main(string[] args)
        {
            var BlogPost1 = new BlogPost();
            BlogPost1.Title = "Lorem Ipsum";
            BlogPost1.AuthorName = "John Doe";
            BlogPost1.PublicationDate = "2010.05.04.";
            BlogPost1.Text = "Lorem ipsum dolor sit amet";

            var BlogPost2 = new BlogPost();
            BlogPost2.Title = "Wait but why";
            BlogPost2.AuthorName = "Tim Urban";
            BlogPost2.PublicationDate = "2010.10.10.";
            BlogPost2.Text = "A popular long-form, stick-figure-illustrated blog about almost everything.";

            var BlogPost3 = new BlogPost();
            BlogPost3.Title = "One Engineer Is Trying to Get IBM to Reckon With Trump";
            BlogPost3.AuthorName = "William Turton";
            BlogPost3.PublicationDate = "2017.03.28.";
            BlogPost3.Text = "Daniel Hanley, a cybersecurity engineer at IBM, doesn’t want to be the center of attention. When I asked to take his picture outside one of IBM’s New York City offices, he told me that he wasn’t really into the whole organizer profile thing.";

        }
    }
}
