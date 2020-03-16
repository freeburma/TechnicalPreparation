using System;
using System.Diagnostics;
using System.Linq;

namespace DrawingDiamond
{
    class Program
    {
        bool isTrue()
        {
            return true;
        }


        

        static void Main(string[] args)
        {
            Process process = Process.GetCurrentProcess();

            var app = new Program();
            Console.WriteLine($"Is True {app.isTrue()}");

            Console.WriteLine("\n");

            var diamonShape = new DimondShape();
            diamonShape.DrawDiamondWithoutPadding(5);
            Console.WriteLine("\n\n");


            diamonShape.DrawDiamond(50);
            Console.WriteLine("\n\n");

            diamonShape.DrawMultipleDiamond(21, 3);
            Console.WriteLine("\n\n");

            for (int i = 0; i < 10; i++)
            {
                diamonShape.DrawMultipleDiamond(21, 3);

            }
            Console.WriteLine("\n\n");



            long totalMemoryByteUsed = process.WorkingSet64;
            Console.WriteLine($"Memory Usage in : {totalMemoryByteUsed / 1000000} MB");
            Console.WriteLine("\n\nProgram Finished ...");
        }
    }
}
