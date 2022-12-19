using System;

/*
 
    *
   ***
  *****
 *******
*********

ACCEPTANCE CRITERIA:
Write a script to output this pyramid on console (with leading spaces)

*/
namespace Pyramid
{
    public class Program
    {
        private static void Pyramid(int height)
        {

            for (int i = 1; i <= height; i++)
            {
                Console.WriteLine(
                   (new string(' ', height - i)) + (new string('*', i * 2 - 1))
                );
            }
        }

        public static void Main(string[] args)
        {
            Pyramid(5);
            Console.ReadKey();
        }
    }
}