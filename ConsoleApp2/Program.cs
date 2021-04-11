using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace q2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input : ");
            string input= Console.ReadLine();
            List<char> distinct = new List<char>();
            foreach (char item in input)
            {
                if (!distinct.Contains(item))
                {
                    distinct.Add(item);
                }
            }
            distinct.Remove(' ');
            Console.Write("output: ");
            foreach (char item in distinct)
            {
                int count = 0;
                Console.Write(item +" - ");
                foreach (char chr in input)
                {
                    if (chr == item)
                    {
                        count++;
                    }
                }
                Console.WriteLine(count.ToString());
            }

            Console.ReadLine();
        }
    }
}
