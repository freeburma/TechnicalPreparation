using System;
using System.IO;

namespace FileManipulation
{
    class Program
    {


        void ReadFile()
        {
            string line = "";
            int lineCount = 0, wordsCount = 0; 
            using (StreamReader reader = new StreamReader(@"E:\Programing\C#\TechnicalTestPreparation\FileManipulation\Test.txt"))
            {
                while ((line = reader.ReadLine()) != null)
                {

                    var tempArray = line.Split(' ');
                    wordsCount = tempArray.Length; 
                    Console.WriteLine(line);
                    lineCount++; 
                }// end while 
            }

            Console.WriteLine("\n\n");
            Console.WriteLine($"Total Lines: {lineCount}, Words: {wordsCount}");


        }// end ReadFile()


        static void Main(string[] args)
        {

            var app = new Program();

            app.ReadFile(); 


            Console.WriteLine("\n\nProgram Finished ...");

        }// end main()
    }// end class 
}
