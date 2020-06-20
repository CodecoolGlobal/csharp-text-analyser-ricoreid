using System;
using System.Collections;
using System.Collections.Generic;

namespace TextAnalyser
{
    public class StatisticalAnalysis
    {
        /*
            It's the dataset. 
            It is initialized with Iterator< and provides functions for statistical analysis of the text elements (Strings). 
            NOTE: You may choose any data structure to store the processed data. 
            The choice will affect the amount of code you will have to write.
        */
        View myView = new View();
        Iterator iterator;
        public StatisticalAnalysis(Iterator sourceFile)
        {
            iterator = sourceFile;            
        } // end of constructor

        public int CountOf( params string[] _elems )
        {
            /*
                Returns sum of all occurrences (in the dataset) of the elements given as arguments ( _elems)_. 
                Note: One string may be given as well. 
                NOTE: To clarify - read how params keyword works 
            */
            string letter;
            int sumOfElements = 0;
            while ( this.iterator.HasNext() )
            {
                letter = this.iterator.MoveNext().ToLower();
                for ( int index = 0; index < _elems.Length - 1; index++ )
                {
                    if ( letter == _elems[index] )
                        sumOfElements++;
                }

            }
            return sumOfElements;
        } // end of method CountOf()

        public int DictionarySize()
        {
            /*
                Returns the number of unique elements of the dataset. 
                It’s the size so-called Author’s Dictionary - the set of different words the author of the text uses.
            */
            List<string> elementSet = new List<string>();
            string element;

            while ( this.iterator.HasNext() )
            {
                element = this.iterator.MoveNext().ToLower();

                if ( elementSet.Contains( element ) || string.IsNullOrWhiteSpace( element ) )
                {
                    continue;
                }
                else
                {
                    elementSet.Add( element );
                }

            }
            return elementSet.Count;
        } // end of method DictionarySize()

        public int Size()
        {
            /*
                Returns the total number of all elements in the dataset. 
                This will be total number of words or total number of characters.
            */
            int total = 0;
            
            while ( this.iterator.HasNext() )
            {
                this.iterator.MoveNext();
                total++;
            }
            return total;
        } // end of method Size()

        public ISet<string> OccurMoreThan(int _n_)
        {
            /*
                Returns all the elements that occur more than _n __times _ in the dataset
            */
            return null;
        } // end of method OccurMoreThan()

    } // end of class StatisticalAnalysis
} // end of namespace TextAnalyser