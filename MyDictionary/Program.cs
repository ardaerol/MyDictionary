using System;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<string> myDictionary = new MyDictionary<string>();
            
            myDictionary.Add("Arda");
            myDictionary.Add("Erol");

            MyDictionary<int> myDictionary1 = new MyDictionary<int>();
            
            myDictionary1.Add(3);
            myDictionary1.Add(23);
        }
    }
}
