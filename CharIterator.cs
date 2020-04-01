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
        public CharIterator(FileContent content)
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
} // End of namespace TextAnalyse