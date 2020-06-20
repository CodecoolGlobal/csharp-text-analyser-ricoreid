using System;
using System.Collections;
using System.Collections.Generic;

namespace TextAnalyser
{
    public class View
    {
        /*
            This class should be responsible for presenting the data to the user. 
            You are free to implement any functions you find sensible. 
            NOTE: In case of this class you don’t have to follow the UML diagram.
        */

        public void Print(int value, string message )
        {
            Console.WriteLine( "{0}: {1}", message, value );
        } // End of method Print()

        public void PrintList(ISet<string> strList, string message)
        {
            Console.Write( message );
            foreach ( var elem in strList )
            {
                Console.WriteLine( "{0} ", elem );
            } 
        } // End of method PrintList()
    }
} // End of TextAnalyser