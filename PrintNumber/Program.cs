using System;

namespace PrintNumber
{
    class Program
    {
        /// <summary>
        /// Main: will print the lines in multiple of 3, 5 and both
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            // Printing the number 1 to 100
            for (int i = 0; i < 100; i++)
            {
                // Printing Multiple of 3 
                if (i%3 == 0)
                {
                    Console.WriteLine("Site");
                }

                // Printing Multiple of 5

                if (i % 5 == 0)
                {
                    Console.WriteLine("Host");
                }

                // Printing Multiple of 3 and 5
                int multipleOf3And5 = 3 * 5; 
                if ((i >= multipleOf3And5) && (i % 3 == 0) && (i % 5 == 0))
                {
                    Console.WriteLine("SiteHost");
                }
            }
        }
    }
}
