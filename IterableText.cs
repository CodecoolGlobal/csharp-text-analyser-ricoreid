namespace TextAnalyser
{
    public interface IterableText
    {
        public Iterator CharIterator();
        public Iterator WordIterator();
    }
} // End of namespace TextAnalyser