using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_28_Regex__Patterns__and_Intro_to_DBs
{
    class Program
    {
        static void Main(String[] args)
        {
            int N = Convert.ToInt32(Console.ReadLine());
            List<string> Names = new List<string>();
            for (int a0 = 0; a0 < N; a0++)
            {
                string[] tokens_firstName = Console.ReadLine().Split(' ');
                string firstName = tokens_firstName[0];
                string emailID = tokens_firstName[1];
                if (emailID.Contains("@gmail.com"))
                {
                    Names.Add(firstName);
                }
            }
            Names.Sort();
            for (int i = 0; i < Names.Count(); i++)
            {
                Console.WriteLine(Names.ElementAt(i));
            }
        }
    }
}
