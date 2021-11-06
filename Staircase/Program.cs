/*
    # 
   ## 
  ### 
 ####

 Observe that its base and height are both equal to n, and the image is drawn using # symbols and spaces. The last line is not preceded by any spaces.

Write a program that prints a staircase of size .
*/

//FINISHED IT IN 6 MIN

using System;

namespace Staircase
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());

            staircase(n);
        }

        static void staircase(int n)
        {
            for(int i = 1; i<=n; i++)
            {
                for (int temp = n; temp >= 1; temp--)
                {
                    if (temp <= i)
                        Console.Write('#');
                    else
                        Console.Write(' ');
                }
                Console.WriteLine();
            }

        }
    }
}
