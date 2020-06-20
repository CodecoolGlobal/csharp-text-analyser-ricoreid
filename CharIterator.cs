using System.IO;
using System;

namespace TextAnalyser
{
    public class CharIterator : Iterator
    {
        /*
         successively iterates over alphabetic characters (single letters) of the text.
         It skips all other characters (like white-spaces). Implements MoveNext() and HasNext() from **Iterator ** interface. 
         NOTE: Chars are represented as Strings for the sake of simplicity.
         Remember that characters’ case (UPPER or lower) should be consistent in our analysis.
        */
        private int currentPosition = 0;
        private string data = null;
        public CharIterator(FileContent content)
        {
            if(File.Exists(content.GetFilename()))
            {
                data = File.ReadAllText(content.GetFilename());
            }
            else
            {
                Console.WriteLine("File does not exists");
            }
        } // End of constructor

        public bool HasNext()
        {
            if ( currentPosition > data.Length - 1)
            {
                Remove();
                return false;
            }
            else
            {
                return true;
            }
        } // End of method HasNext()

        public string MoveNext()
        {
            return data[currentPosition++].ToString();
        } // End of method MoveNext()

        public void Remove()
        {
            currentPosition = 0;
        }
    } // End class WordIterator
} // End of namespace TextAnalyse