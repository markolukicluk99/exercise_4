using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace exercise_4
{
    class StringStatistics
    {
        public string initialString;

        public string[] words;
        //Constructor (Has to be the same name as the Class itself.)
        public StringStatistics(string text)
        {
            initialString = text;
            words = splitToWords(text);
        }

        public string[] splitToWords(string text)
        {
            // Define the separators, such as whitespaces, commas, dots, etc.
            char[] separators = new char[] { ' ', '.', ',', '?', '!', ';', '\n', '(', ')', '/' };

            // Split the words without the empty entries, in our case that could be an empty string, just with whitespaces.
            string[] words = text.Split(separators, StringSplitOptions.RemoveEmptyEntries).Where(word => word != "-").ToArray();
            return words;
        }

        public int CountWords()
        {
            // Just return the length of words array.
            return words.Length;
        }

        public int CountRows()
        {
            // Count the rows, by using the splitter ( We're using '\n' as a reference, to cut the String up. )
            return initialString.Split('\n').Length;
        }

        public int CountSentences()
        {
            // Define the requisits for Regex
            string regex = @"(\.|\?|!)\s[A-Z]";
            // Find the matches using MathCollection & Regex from RegularExpressions package. (Instructions can be found in Microsoft Docs for C#)
            MatchCollection matches = Regex.Matches(initialString, regex);

            return matches.Count + 1;
        }

        public string[] LongestWord()
        {
            int length = 0;

            // Scan for words
            foreach (string word in words)
            {
                if (word.Length > length) length = word.Length;
            }

            // Store the words we found into an array of strings.
            string[] longwords = words.Where(word => word.Length == length).ToArray();

            return longwords;

        }

        public string[] ShortestWord()
        {
            // Use the integrated functionality in C#, so called as MaxValue
            int lowest = int.MaxValue;
            // Check for the shortest word in the whole string
            foreach (string word in words)
            {
                if (word.Length < lowest) lowest = word.Length;
            }

            // Store the result and return it
            string[] shortestword = words.Where(word => word.Length == lowest).ToArray();

            return shortestword;
        }

        public string[] MostCommonWord()
        {
            Dictionary<string, int> dictionary = new Dictionary<string, int>();

            // Iterate through the Dictionary of strings, check for the most commong word, and then save it.
            foreach (string word in words)
            {
                if (dictionary.ContainsKey(word))
                {
                    dictionary[word]++;
                }
                else
                {
                    dictionary.Add(word, 1);
                }
            }

            // Count the number of times this word appears in the Dictionary.
            int occasions = 0;
            foreach (var item in dictionary)
            {
                if (item.Value > occasions)
                {
                    occasions = item.Value;
                }
            }

            // Store the result into an Array of strings and display it.
            string[] result = dictionary.Where(word => word.Value == occasions).Select(word => word.Key).ToArray();

            return result;

        }
        public string[] AlphabethicSorting()
        {
            string[] result = words;

            // Simply use the Array.Sort functionallity and return the result.

            Array.Sort(result);

            return result;
        }
    }
}
