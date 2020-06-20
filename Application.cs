using System;
using System.IO;
using System.Collections.Generic;

namespace TextAnalyser
{
    public class Application
    {
        /*
            The Main class of the program. 
            It should allow the user to pass to text files for analysis as CLI arguments. 
            Also, measure  the time of the program's execution. For example:
            >dotnet run -- text1.txt text2.txt
        */
        public static void Main ( string[] args )
        {
            View myView = new View();
            string filePath;
            FileContent sourceFile;
            StatisticalAnalysis myAnalysis;
            StatisticalAnalysis myAnalysis1;

            if ( args.Length > 0 )
            {
                for ( int index = 0; index < args.Length; index++ )
                {
                    filePath = String.Format(args[index]);
                    Console.WriteLine("Analysis Of File {0} ", filePath.ToUpper());
                    sourceFile = new FileContent( filePath );
                    myAnalysis = new StatisticalAnalysis( sourceFile.CharIterator() );
                    myAnalysis1 = new StatisticalAnalysis( sourceFile.WordIterator() );
                    myView.Print( myAnalysis.CountOf( "a", "e", "i", "o", "u" ), "Number of vowels: ");
                    myView.Print( myAnalysis1.DictionarySize(), "Number of unique Words: ");
                    myView.Print( myAnalysis.Size(), "Total number of characters: ");
                    myView.PrintList( myAnalysis1.OccurMoreThan( 5 ), "Words that repeats more than 5 times: " );
                    Console.WriteLine();
                }
            }

            // FileContent sourceFile = new FileContent( filePath );
            // StatisticalAnalysis myAnalysis = new StatisticalAnalysis( sourceFile.CharIterator() );
            // StatisticalAnalysis myAnalysis1 = new StatisticalAnalysis( sourceFile.WordIterator() );
            // myView.Print( myAnalysis1.CountOf( "it", "is" ), "Number of vowels: ");
            // myView.Print( myAnalysis1.DictionarySize(), "Number of unique elements: ");
            // myView.Print( myAnalysis1.Size(), "Total number of characters: ");
            // myView.PrintList( myAnalysis1.OccurMoreThan( 5 ), "Element that repeats 5 times: " );
        }
    }
}