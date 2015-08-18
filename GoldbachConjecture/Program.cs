using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoldbachConjecture
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var goldbach = new GoldbachConjecture();
            int number = 34567890;
            var result = goldbach.Result(number);
            Console.WriteLine("{0} = {1} + {2}", number, result.Item1, result.Item2);
        }
    }
}
