using System;

namespace Pattern_problem
{
    public class PatternC
    {
        public static void Main(string[]args)
        {
            for(int i=0;i<=5;i++)
            {
                for(int j=0;j<=5-i;j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
        }
    }
}




output:


*****
****
***
**
*