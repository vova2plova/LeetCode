using System;
using System.Collections.Generic;
using System.Diagnostics.SymbolStore;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Easy.Easy_700_720
{
    internal class Easy_705
    {

        Object[] HS;
        public Easy_705()
        {
            HS = new Object[0];
        }

        public void Add(int key)
        {
            var len = HS.Length;
            if (key > len - 1)
            {
                var temp = new Object[key+1];
                HS.CopyTo(temp, 0);
                HS = temp;
            }
            HS[key] = key;
            
        }

        public void Remove(int key)
        {
            var len = HS.Length;
            if (key > len - 1)
                return;
            HS[key] = null;
        }

        public bool Contains(int key)
        {
            var len = HS.Length;
            if (key > len - 1)
                return false;
            if (HS[key] != null)
                return true;
            return false;
        }
    }
}
