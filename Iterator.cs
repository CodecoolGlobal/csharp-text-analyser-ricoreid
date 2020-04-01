namespace TextAnalyser
{
    public interface Iterator 
    {
        bool HasNext();
        string MoveNext();
        void Remove();
    }
} // end of namespace TextAnalyzer