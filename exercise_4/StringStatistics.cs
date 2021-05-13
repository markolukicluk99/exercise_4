using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

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
            //Split the words without the empty entries, in our case that could be an empty string, just with whitespaces.
            string[] words = text.Split(separators, StringSplitOptions.RemoveEmptyEntries).Where(word => word != "-").ToArray();
            return words;
        }

        public int CountWords()
        {
            return words.Length;
        }

        public int CountRows()
        {
            // Count the rows, by using the splitter ( We're using '\n' as a reference, to cut the String up. )
            return initialString.Split('\n').Length;
        }
    }
}
