using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Easy.Easy_1_20
{
	internal class Easy_1
	{
		public int[] TwoSum(int[] nums, int target)
		{
			int i = 0;
			int j = nums.Count() - 1;
			while (i != j)
			{
				if (nums[i] + nums[j] == target)
					return new int[2] { i, j };
				if (j == (int)nums.Count() / 2)
				{
					j = nums.Count();
					i++;
				}
				j--;
			}
			return new int[2] { i, j };
		}

		/*  BEST SOLVE
		 *  
		 public int[] TwoSum(int[] nums, int target) 
		 {
			var dic = new Dictionary<int, int>();
			var len = nums.Length;
			for(int i = 0; i < len; i++)
			{
				if(dic.TryGetValue(target - nums[i], out int value))
					return new int[]{i, value};
				else
					dic.TryAdd(nums[i], i);

			}
			return new int[0];
		 }

		*/

	}
}
