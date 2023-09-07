using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoveEstimator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const decimal baseCost = 200.00m;
            Console.WriteLine("How many hours will you expect to need for the job?");
            decimal hours = Convert.ToDecimal(Console.ReadLine());
            decimal totalHours = hours * 150;
            Console.WriteLine("How many miles do you expect to move?");
            decimal miles = Convert.ToInt32(Console.ReadLine());
            decimal totalMiles = (miles * 2);
            decimal totalEstimate = (baseCost + totalHours + totalMiles);
            Console.WriteLine("Your estimate for this move is $" + totalEstimate);
            Console.ReadLine();
        }
    }
}
