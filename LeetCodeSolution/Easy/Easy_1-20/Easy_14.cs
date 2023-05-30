using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Easy.Easy_1_20
{
    internal class Easy_14
    {
        public string LongestCommonPrefix(string[] strs)
        {
            int j = 0;
            string result = "";
            while (true)
            {
                int i = 0;
                while (i < strs.Length)
                {
                    if (j >= strs[i].Length)
                    {
                        if (i != 0)
                        {
                            return result.Remove(result.Length - 1);
                        }
                        return result;
                    }
                    if (result.Length == j)
                        result += strs[i][j];
                    if (strs[i][j] != result[j])
                        return result.Remove(result.Length - 1);
                    if (j >= strs[i].Length)
                        return result;
                    i++;
                }
                j++;
                
            }
        }
    }
}
