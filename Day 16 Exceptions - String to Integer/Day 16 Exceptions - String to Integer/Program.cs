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
        /*
         * AlternativeSolution fails the challenge because it does not include a try catch statement
         * AlternativeSolution still works the same and I find it to be a nicer way
         * to convert strings to integers in c#.
         */
        static void AlternativeSolution() 
        {
            string S = Console.ReadLine();
            int number;
            bool canParse = Int32.TryParse(S, out number);
            if (canParse)
            {
                Console.WriteLine(number);
            }
            else
            {
                Console.WriteLine("Bad String");
            }
        }
    }
}
