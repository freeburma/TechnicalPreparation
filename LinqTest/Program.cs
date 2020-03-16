using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqTest
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] scores = new int[] { 97, 92, 81, 60, 45 };
            int[] scores2 = new int[] {1, 2, 3, 4 };

            // Search with Linq 
            IEnumerable<int> scoreQuery = from s in scores
                                          where s <= 60
                                          orderby s ascending
                                          select s;

            foreach (var s in scoreQuery)
            {
                Console.WriteLine(s);
            }


            Console.WriteLine($"Max   :  {scoreQuery.Max()}");
            Console.WriteLine($"Count :  {scoreQuery.Count()}");


            IEnumerable<int> scoreQuery2 = from s in scores
                                          orderby s ascending
                                          select s;

            Console.WriteLine($"Min     :  {scoreQuery2.Min()}");
            Console.WriteLine($"Max     :  {scoreQuery2.Max()}");
            Console.WriteLine($"Average :  {scoreQuery2.Average()}");


            IEnumerable<int> scoreQuery3 = scores.Where(s => s > 90);
            foreach (var s in scoreQuery3)
            {
                Console.WriteLine($">>> {s}");
            }

            Console.WriteLine("\n\n");

            var concatList = scores.Concat(scores2).OrderBy(s => s);
            foreach (var s in concatList)
            {
                Console.WriteLine($"*** {s}");
            }

            Console.WriteLine("\n\n");

            var getting4and60_1 = from s in concatList where s >= 4 && s <= 60 select s;
            foreach (var s in getting4and60_1)
            {
                Console.WriteLine($"*** {s}");
            }
            Console.WriteLine("\n");


            var getting4and60_2 = concatList.Where(s => s >= 4 && s <= 60);
            foreach (var s in getting4and60_2)
            {
                Console.WriteLine($"*** {s}");
            }

            Console.WriteLine("\n\nProgram Finished ...");

        }
    }
}
