namespace TextAnalyser
{
    public interface IterableText
    {
        Iterator CharIterator();
        Iterator WordIterator();
    }
} // End of namespace TextAnalyser