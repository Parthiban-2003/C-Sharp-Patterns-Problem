using System;

namespace Pattern_problem
{
    public class PatternB
    {
        public static void Main(string[]args)
        {
            for(int i=1;i<=5;i++)
            {
                for(int j=0;j<=i;j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
        }
    }
}




output:


*
**
***
****
*****