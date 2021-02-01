using System;
using System.Collections.Generic;

namespace MyDictionary
{
    class Program
    {

        static void Main(string[] args)
        {
            MyDictionary<int, string> country = new MyDictionary<int, string>();
            country.Add(16,"Bursa");
            country.Add(10, "Balıkesir");
            country.Add(34, "İstanbul");
        }
     
     
    }
}
