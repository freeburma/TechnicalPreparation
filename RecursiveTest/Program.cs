using System;
using System.Diagnostics;

namespace RecursiveTest
{
    class Program
    {

        int RecursiveForLopp(int num)
        {
            if (num == 0)
                return 0;

            Console.WriteLine(num);
            return RecursiveForLopp(num - 1);
        }// end RecursiveForLopp()

        void RecursiveForLoppWithCondiction(int numOfLoop, int startingNumber)
        {
            if (numOfLoop == 0)
                return;

            Console.WriteLine($">> {startingNumber}");
            RecursiveForLoppWithCondiction(numOfLoop - 1, startingNumber + 1);
        }// end RecursiveForLopp()

        void AddStarsUp(int numOfLoop, string starString)
        {
            if (numOfLoop == 0)
                return;

            Console.Write($"{starString}");
            AddStarsUp(numOfLoop - 1, starString);

        }

        void AddStarsDown(int numOfLoop, int startingNumber, string starString)
        {
            if (numOfLoop == 0)
                return;

            Console.Write($"{starString}");
            AddStarsDown(numOfLoop - 1, startingNumber + 1, starString);

        }

        void RecursiveDrawStarUp(int numOfLoop, int startingNumber, int numOfHorizontal)
        {
            if (numOfLoop == 0)
                return;

            // Show stars
            if (startingNumber % 2 == 1)
            {
                int numberOfSpacesUp = (numOfLoop) / 2;

                for (int i = 0; i < numOfHorizontal; i++)
                {

                    // Drawing the stars upward
                    AddStarsUp(numberOfSpacesUp, " ");
                    AddStarsUp(startingNumber, "*");
                    AddStarsUp(numberOfSpacesUp, " ");
                }


                Console.WriteLine("");
            }

            RecursiveDrawStarUp(numOfLoop - 1, startingNumber + 1, numOfHorizontal);
        }// end RecursiveDrawStarUp()



        void RecursiveDrawStar(int numOfLoop, int startingNumber, int numOfHorizontal)
        {
            RecursiveDrawStarUp(numOfLoop, startingNumber, numOfHorizontal);
            RecursiveDrawStarDown(numOfLoop, startingNumber, numOfHorizontal);
        }// RecursiveDrawStar()

        void RecursiveDrawStarDown(int numOfLoop, int startingNumber, int numOfHorizontal)
        {
            if (numOfLoop == 0)
                return;

            // Show stars
            if (startingNumber % 2 == 1)
            {
                int numberOfSpacesDown = (startingNumber) / 2;

                for (int i = 0; i < numOfHorizontal; i++)
                {
                    // Drawing the stars downward
                    AddStarsDown(numberOfSpacesDown, startingNumber, " ");
                    AddStarsDown(numOfLoop, startingNumber, "*");
                    AddStarsDown(numberOfSpacesDown, startingNumber, " ");
                }

                Console.WriteLine("");
            }

            RecursiveDrawStarDown(numOfLoop - 1, startingNumber + 1, numOfHorizontal);
        }// end RecursiveDrawStarDown()

        int Fib(int num)
        {
            if (num  == 0)
                return 0; 
            else if (num == 1)
                return 1;
            else
                return Fib(num - 1) + Fib(num - 2); 
        }

        static void Main(string[] args)
        {
            DateTime startTime = DateTime.Now;

            Process process = Process.GetCurrentProcess();

            var app = new Program();
            var num = 0; 
            Console.WriteLine($"Fib: {num} => {app.Fib(num)}");

            num = 1;
            Console.WriteLine($"Fib: {num} => {app.Fib(num)}");

            num = 2;
            Console.WriteLine($"Fib: {num} => {app.Fib(num)}");

            num = 3;
            Console.WriteLine($"Fib: {num} => {app.Fib(num)}");

            num = 4;
            Console.WriteLine($"Fib: {num} => {app.Fib(num)}");

            num = 5;
            Console.WriteLine($"Fib: {num} => {app.Fib(num)}");

            num = 10;
            Console.WriteLine($"Fib: {num} => {app.Fib(num)}");

            num = 40;
            Console.WriteLine($"Fib: {num} => {app.Fib(num)}");

            app.RecursiveForLopp(10);

            Console.WriteLine("\n");
            app.RecursiveForLoppWithCondiction(10, 0);

            Console.WriteLine("\n");

            app.RecursiveDrawStar(21, 1, 1);

            for (int i = 1; i < 5; i++)
            {
                app.RecursiveDrawStar(21, 1, i);
            }


            for (int i = 0; i < 10; i++)
            {
                app.RecursiveDrawStar(21, 1, 5);
            }


            DateTime endTime = DateTime.Now;
            TimeSpan timeDiff = endTime - startTime;


            long totalMemoryByteUsed = process.WorkingSet64;


            Console.WriteLine($"Time to Execute: {timeDiff.TotalSeconds} seconds ");
            Console.WriteLine($"Memory Usage in : {totalMemoryByteUsed / 1000000} MB, ");
            Console.WriteLine("\n\nProgram Finished ...");

        }
    }
}
