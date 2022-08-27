using System;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int,int> dictionary = new Dictionary<int, int>();
            dictionary.Add(1, 10);
            dictionary.Add(2, 20); 
            dictionary.Add(3, 30);

            MyDictionary<int,int> dictionary2 = new MyDictionary<int,int>();
            dictionary2.Add(1,10);
            dictionary2.Add(2, 20);
            Console.WriteLine(dictionary2.Count);
            dictionary2.Show();
            
        }
    }
}