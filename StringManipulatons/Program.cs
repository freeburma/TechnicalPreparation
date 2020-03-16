using System;
using System.Collections.Generic;

namespace StringManipulatons
{
    class Program
    {
        struct CharObj
        {
            public char charApp; 
            public int num;

            public CharObj(char charApp, int num)
            {
                this.charApp = charApp;
                this.num = num; 
            }
        }


        public class Pair<TFirst, TSecond>
        {
            public TFirst First;
            public TSecond Second; 
        }

        private class AlphaCount
        {
            public char CharValue { get; set; }
            public int Count { get; set; }
        }

        private bool IsContainCharAndUpdate(List<AlphaCount> alphaCount, char searchChar)
        {
            bool isFound = false;
            foreach (var c in alphaCount)
            {
                if (c.CharValue == searchChar)
                {
                    c.Count += 1; // Updating the value
                    isFound = true;
                    break;
                }
            }

            return isFound;
        }// end IsContainChar()

      
       


        Dictionary<char, int> SplitStringDictionary(string str)
        {
            Dictionary<char, int> alphaCounts = new Dictionary<char, int>();

            var stringArray = str.ToCharArray();

            foreach (var c in stringArray)
            {
                //Console.WriteLine(c.ToString());
                if (!alphaCounts.ContainsKey(c))
                {
                    alphaCounts.Add(c, 1); 
                }
                else
                {
                    // Updating the count 
                    // alphaCounts[c] += 1;


                    int tempSum = 0; 
                    alphaCounts.TryGetValue(c, out tempSum);

                    alphaCounts[c] = tempSum + 1;

                }

            }




            return alphaCounts;


        }// end SplitStringDictionary()

        static void Main(string[] args)
        {
            string testString = "Hello world";
            var app = new Program();

            

            Console.WriteLine("\n\n");
            var countChars = app.SplitStringDictionary(testString);

            foreach (var item in countChars)
            {
                Console.WriteLine($"{item.Key} : {item.Value} ");
            }



            Console.WriteLine("\n\n");

            List<AlphaCount> alphaCountList = new List<AlphaCount>();

            foreach (var c in testString.ToCharArray())
            {
                if (!app.IsContainCharAndUpdate(alphaCountList, c))
                {
                    alphaCountList.Add(new AlphaCount { CharValue = c, Count = 1 }); 
                }
            }

            foreach (var item in alphaCountList)
            {
                Console.WriteLine($">>> {item.CharValue} : {item.Count} ");
            }

            Console.WriteLine("\n\n");
            List<int> integerList = new List<int>();
            List<int> integerList2 = new List<int>();
            integerList.Add(1); 
            integerList.Add(2); 
            integerList.Add(3); 
            integerList.Add(4);

            foreach (var item in integerList)
            {
                integerList2.Add(item); 
                Console.WriteLine($"### {item} ");
            }

            Console.WriteLine("\n");
            integerList.Add(5); 
            foreach (var item in integerList2)
            {
                Console.WriteLine($"*** {item} ");
            }

            Console.WriteLine("\n");

            // Restoring the list
            integerList.Clear();
            foreach (var item in integerList2)
            {
                integerList.Add(item);
                Console.WriteLine($"Adding {item} ");
            }

            Console.WriteLine("\n");

            foreach (var item in integerList)
            {
                integerList2.Add(item);
                Console.WriteLine($"Restored: {item} ");
            }


            Console.WriteLine("\n\n");
            List<Pair<char, int>> pairList = new List<Pair<char, int>>();
            pairList.Add(new Pair<char, int>() { First = 'h', Second = 1 }); 
            pairList.Add(new Pair<char, int>() { First = 'e', Second = 1 }); 
            pairList.Add(new Pair<char, int>() { First = 'l', Second = 2 }); 
            pairList.Add(new Pair<char, int>() { First = 'o', Second = 1 });

            foreach (var item in pairList)
            {
                Console.WriteLine($"==> {item.First}, {item.Second}");
            }

            List<Pair<int, int>> pairList2 = new List<Pair<int, int>>();
            pairList2.Add(new Pair<int, int>() { First = 1, Second = 1 });
            pairList2.Add(new Pair<int, int>() { First = 2, Second = 1 });
            pairList2.Add(new Pair<int, int>() { First = 3, Second = 2 });
            pairList2.Add(new Pair<int, int>() { First = 4, Second = 1 });

            foreach (var item in pairList2)
            {
                Console.WriteLine($"==> {item.First}, {item.Second}");
            }

            CharObj[] charObjs = new CharObj[testString.Length];

            var count = 0; 
            foreach (var c in testString.ToCharArray())
            {
                charObjs[count] = new CharObj(c, 1); 
                count ++; 
            }

            count = 0;

            Console.WriteLine("\n\n");
            foreach (var item in charObjs)
            {
                Console.WriteLine($"==> {item.charApp}, {item.num}");
            }

            Console.WriteLine("\n\nProgram Finished ...");

        }
    }
}
