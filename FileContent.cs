
namespace TextAnalyser
{
    /*
        This class is responsible for reading text files and providing its content through implementing **IterableText ** interface. 
        The content will be provided through methods **CharIterator() ** and **WordIterator().**
    */
    public class FileContent : IterableText
    {
        private string filename;
        public FileContent(string filename1)
        {
            filename = filename1;
        } // End of constructor

        public Iterator CharIterator() // read and return each character from the text file.
        {
            
            return new CharIterator(this);

        } // End of method CharIterator()

        public Iterator WordIterator() // read and return each word from the text file.
        {

            return new WordIterator(this);

        } // End of method WordIterator()

        public string GetFilename()
        {
            return filename;
        } // End of method GetFilename()
        
    } // End of class FileContent
} // End of namespace TextAnalyser