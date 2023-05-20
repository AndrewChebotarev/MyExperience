using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main.Algorithms
{
    public class FactorialRecursion
    {
        public int factorial(int x)
        {
            if (x == 1)
                return 1;
            else
                return x * factorial(x - 1);
        }
    }
}
