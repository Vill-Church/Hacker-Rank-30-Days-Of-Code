using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_25_Running_Time_and_Complexity
{
    class Program
    {
        static void Main(String[] args)
        {
            /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */
            int T = int.Parse(Console.ReadLine());
            for (int i = 0; i < T; i++)
            {
                int n = int.Parse(Console.ReadLine());
                if (n > 2)
                {
                    if (isPrime(n) == true)
                    {
                        Console.WriteLine("Prime");
                    }
                    else
                    {
                        Console.WriteLine("Not prime");
                    }
                }
                else if (n == 2)
                {
                    Console.WriteLine("Prime");
                }
                else
                {
                    Console.WriteLine("Not prime");
                }

            }

        }
        public static bool isPrime(int n)
        {
            int nSqrt = (int)Math.Round(Math.Sqrt(n));
            for (int i = 2; i <= nSqrt; i++)
            {
                if (n % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
