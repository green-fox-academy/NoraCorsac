using System;
using System.Linq;

namespace FindUpperCase
{
    class Program
    {
        static void Main(string[] args)
        {
            string myString = "dfgreASD,GmgriGd,OU";

            var upperCaseCharacter = myString.Where(s => char.IsUpper(s));
            foreach (var character in upperCaseCharacter)
            {
                Console.WriteLine(character);
            }
            Console.ReadLine();
        }
    }
}
