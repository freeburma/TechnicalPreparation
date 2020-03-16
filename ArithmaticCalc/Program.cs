using System;
using System.Diagnostics;

namespace ArithmaticCalc
{
    class Program
    {
        int FindMin(int[] arr)
        {
            int current = arr[0]; 
            foreach (var num in arr)
            {
                if (num < current  ) 
                    current = num; 
            }

            return current;
        }// end FindMin()

        int FindMax(int[] arr)
        {
            int current = arr[0];
            foreach (var num in arr)
            {
                if (num > current)
                    current = num;
            }

            return current;
        }// end FindMax()

        double Average(int[] arr)
        {
            double total = 0.0; 
            foreach (var item in arr)
            {
                total += item;
            }

            return total / arr.Length; 
        }

        /// <summary>
        ///  Insertion Sort in Ascending Order
        /// </summary>
        void SortArrayAsc(int[] arr)
        {
            int[] tempArray = arr;

            for (int i = 0; i < tempArray.Length; i++)
            {
                for (int j = 0; j < tempArray.Length; j++)
                {
                    if (tempArray[i] < tempArray[j])
                    {
                        int temp = tempArray[i];
                        tempArray[i] = tempArray[j];
                        tempArray[j] = temp; 
                    }
                }// end for
            }// end for



            // Sorted Array
            Console.WriteLine(string.Join(' ', tempArray));
        }

        /// <summary>
        ///  Insertion Sort in Descending Order
        /// </summary>
        void SortArrayDesc(int[] arr)
        {
            int[] tempArray = arr;

            for (int i = 0; i < tempArray.Length; i++)
            {
                for (int j = 0; j < tempArray.Length; j++)
                {
                    if (tempArray[i] > tempArray[j])
                    {
                        int temp = tempArray[i];
                        tempArray[i] = tempArray[j];
                        tempArray[j] = temp;
                    }
                }// end for
            }// end for



            // Sorted Array
            Console.WriteLine(string.Join(' ', tempArray));
        }

        int Fib(int num)
        {

            if (num == 0)
            {
                return 0;
            }

            //if (num >= 1 && num <= 2)
            //{
            //    return 1;
            //}

            int fibTotal = 0;
            int[] fibHistory = new int[num];
            Array.Clear(fibHistory, 0, fibHistory.Length);


            for (int i = 0; i < num; i++)
            {
                // Console.WriteLine($"[-] {prevNum}");
                // Index: 0   1  2  3  4  5  6
                // Fib  : 0   1  1  2  3  5  8

                if (i == 0)
                {
                    fibTotal = 0;
                    fibHistory[i] = fibTotal; 
                }
                else if (i >= 1 && i <= 2)
                {
                    fibTotal = 1;
                    fibHistory[i] = fibTotal;
                }
                else
                {
                    fibTotal = fibHistory[i - 2] + fibHistory[i - 1];
                    fibHistory[i] = fibTotal;

                }


            }

            Console.WriteLine(string.Join(' ', fibHistory));

            Console.WriteLine("");
            return fibTotal; 
        }

        void TestRef(ref int num)
        {
            num = -1; 
        }

        static void Main(string[] args)
        {
            Process process = Process.GetCurrentProcess();
            DateTime startTime = DateTime.Now;

            var app = new Program();

            int[] intArray = new int[] { 6, 10, 3, 8, 2, 1, 9 };


            Console.WriteLine($"Min : {app.FindMin(intArray)}");
            Console.WriteLine($"Max : {app.FindMax(intArray)}");
            Console.WriteLine($"Avg : {app.Average(intArray).ToString("n2")}");
            app.SortArrayAsc(intArray); 
            app.SortArrayDesc(intArray);

            /// Testing ref
            int num = 10;
            app.TestRef(ref num); 
            Console.WriteLine($"Ref: {num}");

            num = 0; 
            Console.WriteLine($"Fib {num} : {app.Fib(num)}");

            num = 1;
            Console.WriteLine($"Fib {num - 1} : {app.Fib(num)}");

            num = 2;
            Console.WriteLine($"Fib {num - 1} : {app.Fib(num)}");

            num = 3;
            Console.WriteLine($"Fib {num - 1} : {app.Fib(num)}");

            num = 4;
            Console.WriteLine($"Fib {num - 1} : {app.Fib(num)}");

            num = 5;
            Console.WriteLine($"Fib {num - 1} : {app.Fib(num)}");

            num = 10;
            Console.WriteLine($"Fib {num - 1} : {app.Fib(num)}");

            num = 11;
            Console.WriteLine($"Fib {num - 1} : {app.Fib(num)}");


            num = 41;
            Console.WriteLine($"Fib {num - 1} : {app.Fib(num)}");

            DateTime endTime = DateTime.Now;
            TimeSpan timeDiff = endTime - startTime; 


            long totalMemoryByteUsed = process.WorkingSet64;


            Console.WriteLine($"Time to Execute: {timeDiff.TotalSeconds} seconds ");
            Console.WriteLine($"Memory Usage in : {totalMemoryByteUsed / 1000000} MB, ");
            Console.WriteLine("\n\nProgram Finished ...");

        }// end main()
    }
}
