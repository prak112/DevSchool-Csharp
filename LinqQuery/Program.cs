using System;
using System.Linq;
using System.Collections.Generic;

namespace HelloLinq
{
    class Program
    {
        static void Main(string[] args)
        {
            // int array
            int[] numbers = { 0, 12, 4, 6, 8, 90 };

            // limit num
            int limit = 4;

            // query array
            var query = from item in numbers where item > limit select item;

            // display query results
            foreach (var result in query)
            {
                Console.WriteLine(result);
            }
        }
    }
}