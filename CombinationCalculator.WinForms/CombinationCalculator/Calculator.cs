using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CombinationCalculator
{
    public class Calculator
    {
        public static ulong Fact(int n)
        {
            ulong fact = 1;
            for (int i = 2; i <= n; i++)
                fact *= (ulong)i;
            return fact;
        }

        public static ulong GetAssignnmentCount(int n, int m)
        {
            ulong c = 1;
            for (int i = 1; i <= m; i++)
                c *= (ulong)n--;
            return c;
        }

        public static ulong GetAssignmentCountWithRetries(int n, int m)
        {
            ulong c = 1;
            for (int i = 1; i <= m; i++)
                c *= (ulong)n;
            return c;
        }

        public static ulong GetBinomCoefficient(int n, int m)
        {
            if (m > n) throw new ArgumentException();
            if (m == n) return 1;
            if (m > n - m) m = n - m;
            ulong c = 1;
            for (int i = 1; i <= m; i++)
            {
                c *= (ulong)n--;
                c /= (ulong)i;
            }
            return c;
        }
    }
}
