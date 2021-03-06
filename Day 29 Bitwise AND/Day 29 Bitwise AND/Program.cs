﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_29_Bitwise_AND
{
    class Program
    {
        static void Main(String[] args)
        {
            int t = Convert.ToInt32(Console.ReadLine());
            for (int a0 = 0; a0 < t; a0++)
            {
                string[] tokens_n = Console.ReadLine().Split(' ');
                int n = Convert.ToInt32(tokens_n[0]);
                int k = Convert.ToInt32(tokens_n[1]);
                int maxNum = 0;
                for (int i = 1; i <= n; i++)
                {
                    for (int j = i + 1; j <= n; j++)
                    {
                        int result = i & j;
                        if (result < k && maxNum < result)
                        {
                            maxNum = result;
                        }
                    }
                }
                Console.WriteLine(maxNum);
            }
        }
    }
}
