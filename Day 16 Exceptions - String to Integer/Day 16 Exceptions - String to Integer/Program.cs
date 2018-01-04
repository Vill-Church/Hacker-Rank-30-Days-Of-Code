using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_16_Exceptions___String_to_Integer
{
    class Program
    {
        static void Main(String[] args)
        {
            string S = Console.ReadLine();
            try
            {
                int number = int.Parse(S);
                Console.WriteLine(number);
            }
            catch (Exception)
            {
                Console.WriteLine("Bad String");
            }
        }
    }
}
