using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_1_Data_Types
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 4;
            double d = 4.0;
            string s = "HackerRank ";
            int i2 = int.Parse(Console.ReadLine());
            double d2 = double.Parse(Console.ReadLine());
            string s2 = Console.ReadLine();
            Console.Out.WriteLine(i + i2);
            Console.Out.WriteLine((d + d2).ToString("0.0"));
            Console.Out.WriteLine(s + s2);
        }
    }
}
