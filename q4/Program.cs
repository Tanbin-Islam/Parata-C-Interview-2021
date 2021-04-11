using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace q4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number : ");
            int n=Convert.ToInt32(Console.ReadLine());
            int res= dbl_linear(n);
            Console.WriteLine(res);
            Console.ReadLine();
        }

        private static int dbl_linear(int n)
        {
            return seq().Skip(n).First(); ;
        }

        private static IEnumerable<int> seq()
        {
            var pending = new List<int>();
            var buffer = new List<int>();
            buffer.Add(1);
            pending.Add(1);

            while (true)
            {
                var batch = new List<int>();
                foreach (var n in buffer.Distinct())
                {
                    batch.Add(2 * n + 1);
                    batch.Add(3 * n + 1);
                }
                buffer.Clear();
                var batchMin = batch.Min();
                var readyToReturn = pending
                    .Where(x => x <= batchMin)
                    .Distinct()
                    .OrderBy(x => x)
                    .ToList();
                if (readyToReturn.Count > 0)
                {
                    foreach (var x in readyToReturn)
                        yield return x;
                    pending.RemoveAll(x => readyToReturn.Contains(x));
                    batch.RemoveAll(x => readyToReturn.Contains(x));
                }
                pending.AddRange(batch);
                buffer.AddRange(batch);
            }
        }

    }
}
