using System;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<int, string> myDictionary = new MyDictionary<int, string>();
            myDictionary.add(1, "naber");
            myDictionary.add(2, "iyi");
            myDictionary.show();
            Console.ReadKey();
        }
    }
}
