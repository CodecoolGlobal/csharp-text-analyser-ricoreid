namespace TextAnalyser
{
    public class WordIterator : Iterator
    {
        /*
            successively iterates over words of the text. 
            Words in the text are separated with white-spaces. 
            Implements MoveNext() and HasNext() from **Iterator ** interface.
        */
        public WordIterator(FileContent content)
        {

        } // End of constructor

        public bool HasNext()
        {
            return false;
        } // End of method HasNext()

        public string MoveNext()
        {
            return null;
        } // End of method MoveNext()

        public void Remove()
        {

        }
    } // End class WordIterator
} // End of namespace TextAnalyser