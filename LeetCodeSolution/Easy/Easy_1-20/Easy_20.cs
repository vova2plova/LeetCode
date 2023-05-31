using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Easy.Easy_1_20
{
    internal class Easy_20
    {
        public bool IsValid(string s)
        {
            Stack<char> simbols = new Stack<char>();
            string parantheses = "()[]{} ";
            int i = 0;

            while (i < s.Length)
            {
                if (s[i] == '(' || s[i] == '{' || s[i] == '[')
                {
                    simbols.Push(s[i]);
                }
                if (s[i] == ')' || s[i] == '}' || s[i] == ']') 
                {
                    if (simbols.Count == 0)
                    {
                        return false;
                    }
                    var paranthes = simbols.Pop();
                    if (paranthes != parantheses[parantheses.IndexOf(s[i]) - 1])
                    {
                        return false;
                    }
                }
                i++;
            }
            if (simbols.Count == 0)
                return true;
            return false;
        }
    }
}
