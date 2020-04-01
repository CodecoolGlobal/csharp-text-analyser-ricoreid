using System;
using System.IO;
using System.Text;
using static System.Console;

namespace TextAnalyser
{
    /*
        This class is responsible for reading text files and providing its content through implementing **IterableText ** interface. 
        The content will be provided through methods **CharIterator() ** and **WordIterator().**
    */
    public class FileContent : IterableText
    {
        private string filename;
        StreamReader reader;
        public FileContent(string filename)
        {
            this.filename = filename;
        } // End of constructor

        public Iterator CharIterator()
        {

            return null;

        } // End of method CharIterator()

        public Iterator WordIterator()
        {

            return null;

        } // End of method WordIterator()

        public string GetFilename()
        {
            return filename;
        } // End of method GetFilename()
        
    } // End of class FileContent
} // End of namespace TextAnalyser