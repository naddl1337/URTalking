using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using Iveonik.Stemmers;


namespace Iveonik.Stemmers
{
    class StemmerAndTokenizer
    {
        static void Main(string[] args)
        {
            iveonikStemmer(new GermanStemmer());
            Console.ReadKey();
        }

        private static void iveonikStemmer(IStemmer stemmer)
        {
            while (true)
            {
                String userInput = Console.ReadLine();
                String[] userInputAsArray = userInput.Split();
                char[] delimiterChars = { ' ', ',', '.', ':', '\t' };
                foreach (string word in userInputAsArray)
                {
                    String stemmedWord = stemmer.Stem(CleanInput(word));
                    Console.WriteLine("Stemmed: " + stemmedWord);
                }
            }
        }

        static string CleanInput(string strIn)
        {
            try
            {
                String newstr = new Regex("([!@#$%^&*()]|(?:[.](?![a-z0-9]+$)))", RegexOptions.IgnoreCase).Replace(strIn, "");
                return Regex.Replace(newstr, @"[^\w\.@-]", "",
                                     RegexOptions.None, TimeSpan.FromSeconds(1.5));
            }
            catch (RegexMatchTimeoutException)
            {
                return String.Empty;
            }
        }

    }
}
