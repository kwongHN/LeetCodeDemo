using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeDemo
{
    class Class03217
    {
        public static int[] RunningSum()
        {
            int[] nums = new int[]{3, 1, 2, 10, 1 };
            for (int i = 0; i < nums.Length; i++)
            {
                if (i != 0)
                {
                    nums[i] = nums[i - 1] + nums[i];
                }                
            }
            return nums;
        }
    }
}
