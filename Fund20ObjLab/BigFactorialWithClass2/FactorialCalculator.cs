using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace BigFactorialWithClass2
{
    class FactorialCalculator
    {
        public FactorialCalculator(int n)
        {
            N = n;
        }

        public int N { get; set; }

        public BigInteger Calculate()
        {

            BigInteger factoriel = 1;
            for (int i = 2; i <= N; i++)
            {
                factoriel *= i;
            }
            return factoriel;
        }
    }
}
