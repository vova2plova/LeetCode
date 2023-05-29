using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Easy.Easy_1_20
{
    internal class Easy_9
    {
        public bool IsPalindrome(int x)
        {
            int num = x;
            int result = 0;

            if (x < 0)
                return false;

            while (num != 0)
            {
                result = result * 10;
                result += (num % 10);
                num /= 10;
            }

            return x == result;
        }
    }
}
