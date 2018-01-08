using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_26_Nested_Logic
{
    class Program
    {
        static void Main(String[] args)
        {
            string[] acArr_temp = Console.ReadLine().Split(' ');
            int[] acArr = Array.ConvertAll(acArr_temp, Int32.Parse);
            string[] arr_temp = Console.ReadLine().Split(' ');
            int[] arr = Array.ConvertAll(arr_temp, Int32.Parse);
            int fine = 0;
            if (acArr[2] < arr[2])
            { // year less
                fine = 0;
            }
            else if (acArr[0] > arr[0] && acArr[1] == arr[1])
            {
                //day greater but month the same
                if (acArr[2] > arr[2])
                {
                    fine = 10000; // year fixed fine
                }
                else
                { // same month
                    int numOfDaysLate = acArr[0] - arr[0];
                    fine = numOfDaysLate * 15;
                }
            }
            else if (acArr[1] > arr[1])
            {
                //month greater
                if (acArr[2] > arr[2])
                {
                    fine = 10000; // year fixed fine
                }
                else if (acArr[1] > arr[1])
                {
                    int numOfMonthsLate = acArr[1] - arr[1];
                    fine = numOfMonthsLate * 500;
                }
            }
            else if (acArr[2] > arr[2])
            {
                //year greater
                fine = 10000; // year fixed fine
            }
            Console.WriteLine(fine);
        }
    }
}
