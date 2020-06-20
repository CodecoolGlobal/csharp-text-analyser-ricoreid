using System;
using System.IO;

namespace TextAnalyser
{
    public class WordIterator : Iterator
    {
        /*
            successively iterates over words of the text. 
            Words in the text are separated with white-spaces. 
            Implements MoveNext() and HasNext() from **Iterator ** interface.
        */
        private static int currentPosition = 0;
        private static string[] data = null;
        public WordIterator(FileContent content)
        {
            if(File.Exists(content.GetFilename()))
            {
                StreamReader reader = new StreamReader(content.GetFilename());
                // data = File.ReadAllLines(content.GetFilename());
                data = reader.ReadToEnd().Split(' ');
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
            return data[currentPosition++];
        } // End of method MoveNext()

        public void Remove()
        { 
            currentPosition = 0;
        }
    } // End class WordIterator
} // End of namespace TextAnalyser