using System;
using System.Collections.Generic;
using System.Text;

namespace DrawingDiamond
{
    public class DimondShape
    {
        public void DrawStars(string star)
        {
            Console.Write(star);
        }

        /* 
                * 
                **
                ***
                ****
                ******
                ****
                ***
                **
                *



                 *         1   10
                ***        3   8
               *****       5   6
              *******      7   4
             *********     9   2
            ***********    11  0
             *********     9
              *******      7
               *****       5
                ***        3
                 *         1


        */

        public void DrawDiamondWithoutPadding(int numLoop)
        {
            // int numLoop = 5;

            for (int i = 1; i <= numLoop; i++)
            {
                var tempStr = "";
                for (int j = 1; j <= i; j++)
                {

                    tempStr += "*";
                }
                DrawStars(tempStr);
                Console.WriteLine("");

            }

            for (int i = numLoop - 1; i >= 1; i--)
            {
                for (int j = 1; j <= i; j++)
                {
                    DrawStars("*");

                }
                Console.WriteLine("");

            }
        }

        public void DrawDiamond(int numLoop)
        {


            /* 
                          Number
                 *          1            10
                ***         3             8
               *****        5             6
              *******       7             4
             *********      9             2
            ***********    11             0
             *********      9
              *******       7
               *****        5
                ***         3
                 *          1


        */


            //Console.WriteLine("\n\n");
            // numLoop = 50;
            for (int i = 0; i <= numLoop; i++)
            {
                var tempStr = "";



                if (i % 2 == 1)
                {
                    for (int k = 0; k < (numLoop - i) / 2; k++)
                    {
                        tempStr += ' ';
                    }

                    //Console.WriteLine("Odd Number");
                    for (int j = 1; j <= i; j++)
                    {
                        tempStr += "*";
                    }


                    DrawStars(tempStr);

                    Console.WriteLine("");

                }
            }

            for (int i = (numLoop - 1); i >= 1; i--)
            {
                var tempStr = "";
                if (i % 2 == 1)
                {
                    for (int k = 0; k < (numLoop - i) / 2; k++)
                    {
                        tempStr += " ";
                    }

                    //Console.WriteLine("Odd Number");
                    for (int j = 1; j <= i; j++)
                    {
                        tempStr += "*";
                    }

                    DrawStars(tempStr);

                    Console.WriteLine("");

                }
            }

        }// end DrawDiamond()

        public void DrawMultipleDiamond(int numLoop, int numOfVerticalDimonds)
        {


            /* 
                          Number
                 *           *           *          1            10
                ***         ***         ***         3             8
               *****       *****       *****        5             6
              *******     *******     *******       7             4
             *********   *********   *********      9             2
            ***********@***********@***********    11             0
             *********   *********   *********      9
              *******     *******     *******       7
               *****       *****       *****        5
                ***         ***         ***         3
                 *           *           *          1


        */


            //Console.WriteLine("\n\n");
            // numLoop = 50;
            for (int i = 0; i <= numLoop; i++)
            {
                var tempStr = "";

                for (int d = 1; d <= numOfVerticalDimonds; d++)
                {


                    if (i % 2 == 1)
                    {
                        // Spaces Before
                        for (int k = 0; k < (numLoop - i) / 2; k++)
                        {
                            tempStr += ' ';
                        }

                        //Console.WriteLine("Odd Number");
                        for (int j = 1; j <= i; j++)
                        {
                            tempStr += "*";
                        }

                        // Spaces After
                        for (int k = 0; k < (numLoop - i) / 2; k++)
                        {
                            tempStr += ' ';
                        }

                        

                        DrawStars(tempStr);

                        if (d == numOfVerticalDimonds) Console.WriteLine("");


                    }// end if 


                }// end for



            }// end for

            for (int i = numLoop - 1; i >= 1; i--)
            {
                var tempStr = "";

                for (int d = 1; d <= numOfVerticalDimonds; d++)
                {

                    if (i % 2 == 1)
                    {
                        // Space Before
                        for (int k = 0; k < (numLoop - i) / 2; k++)
                        {
                            tempStr += " ";
                        }

                        //Console.WriteLine("Odd Number");
                        for (int j = 1; j <= i; j++)
                        {
                            tempStr += "*";
                        }

                        // Spaces After
                        for (int k = 0; k < (numLoop - i) / 2; k++)
                        {
                            tempStr += ' ';
                        }

                        DrawStars(tempStr);

                        if (d == numOfVerticalDimonds) Console.WriteLine("");


                    }// end if 
                }// end for 
            }// end for

        }// end DrawDiamond()


    }// end class 
}
