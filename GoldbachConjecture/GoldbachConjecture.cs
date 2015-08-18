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
            var first = 0;
            for (int i = 0; i < primos.Length; i++)
            {
                first = primos[i];
                if (primos.Contains(number - first))
                {
                    break;
                }

            }
            return new Tuple<int, int>(first, number - first);
        }

        private int[] PrimoNumberList(int numberMax)
        {
            List<int> primoNumberList = new List<int>();
            for (int i = 2; i < numberMax; i++)
            {
                if (IsPrimo(i))
                    primoNumberList.Add(i);
            }
            return primoNumberList.ToArray();
        }

        private bool IsPrimo(int num)
        {
            bool primo = false;

            for (int i = 1; i < (num / 2) + 1; i = i + 2)
            {
                if (i != 1)
                {
                    if (num % i == 0)
                    {
                        primo = true;
                        break;
                    }
                }

            }
            return primo;
        }

    }


}
