using System;
using System.Collections.Generic;
using System.Linq;

namespace GoldbachConjecture
{
    public class GoldbachConjecture
    {
        public Tuple<int, int> Result(int number)
        {
            if (!ValidateNumber(number))
                throw new ArgumentException("Sólo acepta numeros pares y superiores a 2");

            var primos = PrimoNumberList(number);
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

        private static bool IsPrimo(int candidate)
        {
            if ((candidate & 1) == 0)
                return (candidate == 2);

            for (int i = 3; (i * i) <= candidate; i += 2)
            {
                if ((candidate % i) == 0)
                    return false;
            }
            return candidate != 1;
        }

        private int[] PrimoNumberList(int numberMax)
        {
            List<int> primoNumberList = new List<int>();
            for (int i = 2; i <= numberMax; i++)
            {
                if (IsPrimo(i))
                    primoNumberList.Add(i);
            }
            return primoNumberList.ToArray();
        }

        private bool ValidateNumber(int number)
        {
            return number > 2 && number % 2 == 0;
        }
    }
}