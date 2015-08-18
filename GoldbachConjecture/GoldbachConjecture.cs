using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoldbachConjecture
{
    public class GoldbachConjecture
    {

        public Tuple<int, int> Result(int number)
        {
            var primos = new int[] { 2, 3, 5, 7, 11, 17 };

            var first = primos[0];
            int second = 0;

            
            if (primos.Contains(number - first))
                second = number - first;
            else
            {
                first = primos[1];
                second = number - first;
            }
            if (primos.Contains(number - first))
            {
                second = number - first;
            }
            else
            {
                first = primos[2];
                second = number - first;
            }
            return new Tuple<int, int>(first, second);
        }

    }
}
