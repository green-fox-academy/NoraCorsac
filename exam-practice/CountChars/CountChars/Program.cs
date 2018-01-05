using System;
using System.Collections.Generic;
using System.IO;

namespace CountChars
{
    class Program
    {
        // Create a function that takes the filepath (e.g. "da_vinci_code.txt") as an input, reads the given file, and counts the occurences of 0, 1 and x characters in it.
        // The function should return a dictionary in which the searched characters are the keys and the number of their occurences are the values.
        // Use the uploaded da_vinci_code.txt file in this folder on GitHub to test your program.
        // For example:
        //
        // var countedLetters = CountLetters("da_vinci_code.txt");
        // Console.WriteLine("0 occured {0} times in the file.", countedLetters["0"]);
        // Console.WriteLine("1 occured {0} times in the file.", countedLetters["1"]);
        // Console.WriteLine("x occured {0} times in the file.", countedLetters["x"]);
        // 
        // Should print:
        // 0 occured 3393 times in the file.
        // 1 occured 3375 times in the file.
        // x occured 3232 times in the file.
        static void Main(string[] args)
        {
            string path = @"C:\Users\Zoli\greenfox\NoraCorsac\exam-practice\CountChars\CountChars\da_vinci_code.txt";    //elérési út, be kell másolnom a saját mappájába a fájlt (countChars/CountChars-ba)
            Reader(path); //létrehozom? hivatkozom? valamit csinálok, hogy boldog legyen..+                                                                                                                                                                                                                                                                                                                                                            
            Console.ReadLine();
        }
        public static void Reader(string path)
        {
            Dictionary<string, int> document = new Dictionary<string, int>();
            string text = File.ReadAllText(path);
            string[] characters = text.Split(' '); //elválasztja a szóközöknél a cuccot

            foreach (string character in characters) //átmegy a tömb elemein és ha a document nevű dictionary tartalmazza a kulcsot, ami itt a character,
            {                                        //akkor az elemeket növeli egyel a dictionaryben.
                if (document.ContainsKey(character)) //egyéb esaetben viszont marad ???
                {
                document[character]++;
                }
                else
                {
                    document[character] = 1;
                }
            }

            foreach (KeyValuePair<string, int> vocable in document) //ha a szavak a dokumentumban 1000-nél többször vannak, akkor kiírja.
            {
                if (vocable.Value > 1000)
                {
                    Console.WriteLine("\"" + vocable.Key + "\"" + " " + vocable.Value);
                }
            }
        }
    }
}
