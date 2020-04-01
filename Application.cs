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
        static readonly string textFile = @"/test.txt";
        public static void main(string[] args)
        {
            
            if(File.Exists(textFile))
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }

        }
    }
}