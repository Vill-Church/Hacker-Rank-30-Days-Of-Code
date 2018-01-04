using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_14_Scope
{
    class Difference
    {
        private int[] elements;
        public int maximumDifference;
        public Difference(int[] elements)
        {
            this.elements = elements;
        }
        public void computeDifference()
        {
            int absDiff = 0;
            int n = elements.Length - 1;
            for (int i = 0; i < n; i++)
            {
                for (int j = (i + 1); j < n + 1; j++)
                {
                    int abs = Math.Abs(elements[i] - elements[j]);
                    if (abs > absDiff)
                    {
                        absDiff = abs;
                    }
                }
            }
            this.maximumDifference = absDiff;
        }
    }
        class Program
    {
        static void Main(string[] args)
        {
            Convert.ToInt32(Console.ReadLine());

            int[] a = Console.ReadLine().Split(' ').Select(x => Convert.ToInt32(x)).ToArray();

            Difference d = new Difference(a);

            d.computeDifference();

            Console.Write(d.maximumDifference);
        }
    }
}
