using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace question3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("input : ");
            string input = Console.ReadLine();
            string[] time = input.Split(' ');
            int hour= Convert.ToInt32(time[0]);
            int minute= Convert.ToInt32(time[1]);

            if (hour>11)
            {
                hour -= 12;
            }
            double output;
            if (hour*5 > minute)
            {
                output = ((30 * hour) - (11 * minute / 2));
            }
            else
            {
                output = ( (11 * minute / 2)- (30 * hour));
            }

            Console.WriteLine("output : the angle between two hand is {0} degree",output);
            Console.ReadLine();
        }
    }
}
