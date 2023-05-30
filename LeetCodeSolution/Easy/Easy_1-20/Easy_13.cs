using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Easy.Easy_1_20
{
    internal class Easy_13
    {
        Dictionary<char, int> RomanLetters = new Dictionary<char, int>();

        public int RomanToInt(string s)
        {
            RomanLetters.Add('I', 1);
            RomanLetters.Add('V', 5);
            RomanLetters.Add('X', 10);
            RomanLetters.Add('L', 50);
            RomanLetters.Add('C', 100);
            RomanLetters.Add('D', 500);
            RomanLetters.Add('M', 1000);

            int result = 0;
            int len = s.Length;

            for (int i = 0; i < len; i++)
            {
                var leftNum = RomanLetters.GetValueOrDefault(s[i]);
                var rightNum = 0;
                if (i + 1 < len)
                {
                    rightNum = RomanLetters.GetValueOrDefault(s[i+1]);
                }
                if (leftNum < rightNum)
                    result -= leftNum;
                else
                    result += leftNum;
            }
            return result;
        }
    }

    /* BEST SOLUTION
     private int Roman2Num(char c)
    {
        switch(c)
        {
            case 'I': return 1;
            case 'V': return 5;
            case 'X': return 10;
            case 'L': return 50;
            case 'C': return 100;
            case 'D': return 500;
            case 'M': return 1000;
        };
        return 0;
    }

    public int RomanToInt(string s)
    {
        var num = 0;
        int i, nextDigit;        
        var currDigit = Roman2Num(s[0]);

        for(i = 0; i < s.Length - 1; i++)
        {           
            nextDigit = Roman2Num(s[i + 1]);
            if(nextDigit <= currDigit)
            {
                num += currDigit;
                currDigit = nextDigit;
                continue;
            }

            num += nextDigit - currDigit;
            if(++i < s.Length - 1)
                currDigit = Roman2Num(s[i + 1]);
        }

        return s.Length == i ? num : num + Roman2Num(s[^1]);
    }
     */
}
