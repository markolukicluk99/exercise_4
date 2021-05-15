using System;

namespace exercise_4
{
    class Program
    {
        static void Main(string[] args)
        {
            string testovaciText = "Toto je retezec predstavovany nekolika radky,\n"
                + "ktere jsou od sebe oddeleny znakem LF (Line Feed).\n"
                + "Je tu i nejaky ten vykricnik! Pro ucely testovani i otaznik?\n"
                + "Toto je jen zkratka zkr. ale ne konec vety. A toto je\n"
                + "posledni veta!";
            // New instance
            StringStatistics text = new StringStatistics(testovaciText);

            Console.WriteLine(testovaciText);
            Console.WriteLine("Number of words in the String: {0}", text.CountWords());
            Console.WriteLine("Number of rows in the String: {0}", text.CountRows());
            Console.WriteLine("Number of sentences in the String: {0}", text.CountSentences());
            Console.WriteLine("Longest word: {0}", text.LongestWord());
            Console.WriteLine("Shortest word: {0}", text.ShortestWord());
            Console.WriteLine("Most common word: {0}", text.MostCommonWord());
            Console.WriteLine("Sorted alphabetically: {0}", String.Join(", ", text.AlphabethicSorting()));


            Console.WriteLine();
        }   
    }
}
