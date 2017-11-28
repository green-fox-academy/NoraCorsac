using System;

namespace AppendA
{
    class Program
    {
        static void Main(string[] args)
        {
            string am = "kuty";
            AppendA(am);


            

            // - Write a function called `appendA` that gets a string as an input
            //   and appends an 'a' character to its end
            // - Print the result of `appendA(am)`
            Console.ReadLine();
        }
        public static void AppendA(string word)
        {
            Console.WriteLine(word + "a");
        }
    }
}