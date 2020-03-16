using System;
using System.Collections.Generic;

namespace ListTest
{
    class Program
    {
        static void PrintList<T>(List<T> list)
        {
            foreach (var item in list)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            var originalList = new List<int>() { 1, 2, 3 }; 
            var backupList = new List<int>();

            foreach (var item in originalList)
            {
                backupList.Add(item);
            }
            //backupList = originalList;

            Console.WriteLine("==================================");
            PrintList(originalList);
            PrintList(backupList);
            Console.WriteLine("\n==================================");

            /// Adding new items 
            Console.WriteLine("==================================");
            originalList.Add(4);
            originalList.Add(5);

            PrintList(originalList);
            PrintList(backupList);
            Console.WriteLine("\n==================================");

            /// Restoring to original 
            Console.WriteLine("==================================");
            originalList = backupList;

            PrintList(originalList);
            PrintList(backupList);
            Console.WriteLine("\n==================================");




            Console.WriteLine("Program Finished ...");
        }
    }
}
