using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_10_Binary_Numbers
{
    class Program
    {
        private static List<int> countList = new List<int>();
        private static int counter = 0;
        static int numOfOnes(List<int> binary)
        {
            if (binary.ElementAt(0) == 1)
            {
                counter++;
            }
            else
            {
                countList.Add(counter);
                counter = 0;
            }
            binary.RemoveAt(0);
            if (binary.Count == 0)
            {
                countList.Add(counter);
                countList.Sort();
                return countList.ElementAt((countList.Count() - 1));
            }
            else
            {
                return numOfOnes(binary);
            }
        }

        static void Main(String[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            var binary = new List<int>();
            binary = toBinary(n);
            Console.WriteLine(numOfOnes(binary));
        }
        static List<int> toBinary(int n)  
        {
            var binaryList = new List<int>();
            bool done = false;
            while (done == false)
            {
                if (n / 2 == 0)
                {
                    done = true;
                }
                int toAdd = n % 2;
                binaryList.Add(toAdd);
                n = n / 2;
            }
            return binaryList;
        }
    }
}
