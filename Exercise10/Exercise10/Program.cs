using System;
using System.IO;
using System.Text.RegularExpressions;

/* * * * * * * * * * * * *
 * Warren Peterson * * * *
 * This is my own work * *
 * 5/4/2021  CST-117 * * *
 * Exercise 10 * * * * * *
 * Read File word checker*
 * * * * * * * * * * * * */

namespace Exercise10
{
    class Program
    {
        static void Main(string[] args)
        {
            // Variables
            string text = ""; // Declares the variable text, sets it to type string, sets value to blank
            // Loop that reads the text from the test file and returns the results to the variable text
            // as long as there is text in the file
            if (args.Length == 0)
            {
                text = File.ReadAllText(@"../../TextFile.txt");
            }
            else
            {
                text = File.ReadAllText(args[0]);
            }
            // Displays the location of the saved file
            //Console.WriteLine(Directory.GetCurrentDirectory());
            // declares variable matchCount to hold any word that matches the specified end of word letters we are looking for
            Int64 matchCount = Regex.Matches(text, "([te])(?![a-z])", RegexOptions.Multiline | RegexOptions.IgnoreCase).Count;
            Console.WriteLine(text + "\n"); // Shows the text in the file and how many matches there should be
            Console.WriteLine("There are " + matchCount + " words that end in t or e\n");
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }
    }
}
