using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_2_Operators
{
    class Program
    {
        static void Main(String[] args)
        {
            double mealCost = double.Parse(Console.ReadLine());
            double tipPercent = double.Parse(Console.ReadLine());
            double taxPercent = double.Parse(Console.ReadLine());
            double tip = mealCost * (tipPercent / 100);
            double tax = mealCost * (taxPercent / 100);
            double Cost = mealCost + tip + tax;
            double totalCost = Math.Round(Cost);
            Console.WriteLine("The total meal cost is " + totalCost + " dollars.");
        }
    }
}
