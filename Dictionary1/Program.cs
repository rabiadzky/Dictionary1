using System;

namespace Dictionary1
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<int, string> myDictionary = new MyDictionary<int, string>();
            myDictionary.Add(1, "Ayşe");
            myDictionary.Add(2, "Rabia");
            myDictionary.Add(3, "Selin");
            myDictionary.DictionaryList();
        }
    }
}
