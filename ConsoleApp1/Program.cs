using System;

namespace PrintChars
{
    class Program
    {
        static void PrintChar()
        {
            int numbersStartingIndex = 48; 
            int upperCaseStartingIndex = 65; 
            int lowerCaseStartingIndex = 97;

            int numOfNumbers = 10;
            int numCharsAtoZ = 26;


            for (int j = 0; j < 10; j++)
            {
                string numString = "";


                for (int i = numbersStartingIndex; i < (numbersStartingIndex + numOfNumbers); i++)
                {
                    char c = (char)i;
                    numString += c.ToString();
                }

                for (int i = upperCaseStartingIndex; i < (upperCaseStartingIndex + numCharsAtoZ); i++)
                {
                    char c = (char)i;
                    numString += c.ToString();
                }

                for (int i = lowerCaseStartingIndex; i < (lowerCaseStartingIndex + numCharsAtoZ); i++)
                {
                    char c = (char)i;
                    numString += c.ToString();
                }

                Console.WriteLine($"{numString}");

            }



            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            PrintChar(); 

            Console.WriteLine("Program Finished ...");
            Console.ReadKey(); 
        }
    }
}
