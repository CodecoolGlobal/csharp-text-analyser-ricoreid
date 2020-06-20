using System;
using System.IO;

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
            string filePath = @"test.txt";
            FileContent sourceFile = new FileContent( filePath );
            StatisticalAnalysis myAnalysis = new StatisticalAnalysis( sourceFile.CharIterator() );
            StatisticalAnalysis myAnalysis1 = new StatisticalAnalysis( sourceFile.WordIterator() );
            Console.WriteLine("Number of vowels: " + myAnalysis1.CountOf( "it", "is" ));
            Console.WriteLine("Number of unique elements: " + myAnalysis1.DictionarySize());
            Console.WriteLine("Total number of characters: " + myAnalysis1.Size());           
        }
    }
}