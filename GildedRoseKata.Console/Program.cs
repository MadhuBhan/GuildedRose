using System;
using System.Collections.Generic;
using System.Linq;

namespace GildedRoseKata.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO: Parse args

            var something = new GildedRose(Enumerable.Empty<Item>().ToList());
            System.Console.WriteLine(something.ToString());
        }
    }
}
