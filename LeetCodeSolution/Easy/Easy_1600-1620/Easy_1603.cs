using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Easy.Easy_1600_1620
{
    internal class Easy_1603
    {
        public Easy_1603(int big, int medium, int small)
        {
            CarLotList.Add(0);
            CarLotList.Add(big);
            CarLotList.Add(medium);
            CarLotList.Add(small);
        }

        public bool AddCar(int carType)
        {
            if (CarLotList[carType]-- > 0)
                return true;
            return false;
        }

        List<int> CarLotList = new List<int>();
    }
}
