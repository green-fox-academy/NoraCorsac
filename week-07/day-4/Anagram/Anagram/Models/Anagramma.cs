using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Anagram.Models
{
    public class Anagramma
    {
        public string Word1 { get; set; }
        public string Word2 { get; set; }

        public Anagramma()
        {
        }

        public bool AnagrammChecker()
        {
            bool IsItAnagramm = true;

            char[] firstWord = Word1.ToCharArray().OrderBy(x => x).ToArray();
            char[] secondWord = Word2.ToCharArray().OrderBy(x => x).ToArray();

            if (firstWord.Length == secondWord.Length)
            {
                for (int i = 0; i < firstWord.Length; i++)
                {
                    if (firstWord[i] != secondWord[i])
                    {
                        IsItAnagramm = false;
                        break;
                    }
                }
            }
            else
            {
                IsItAnagramm = false;
            }
            return IsItAnagramm;
        }
    }
}
