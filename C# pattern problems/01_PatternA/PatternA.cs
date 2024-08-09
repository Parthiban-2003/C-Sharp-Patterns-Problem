using System;

namespace Program
{
    public class PatternA
    {
        public static void Main(string[]args)
        {
            for(int i=1;i<=5;i++)
            {
                for(int j=1;j<=5;j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
        }
    }
}



/* output:


* * * * *
* * * * *
* * * * *
* * * * *                             
*/