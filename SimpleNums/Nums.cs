using System;
using System.Collections.Generic;
using System.Diagnostics.SymbolStore;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static SimpleNums.Nums;

namespace SimpleNums
{
    public class Nums
    {
        public int N { get; set; }

        public Nums(int n)
        {
            N = n;
        }

        public static bool IsSimple(int n)
        {
            if (n == 0)
            {
                return false;

            }
            if (n > 1)
            {
                for (var i = 2; i < n; i++)
                {
                    if (n % i == 0)
                    {
                        return false;
                        break;
                    }
                }
            }
            else
            {
                return false;
            }

            return true;
        }
    }
}
