using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeDemo
{
    class Class0403
    {
        /*给你一个整数数组 nums 。

            如果一组数字 (i,j) 满足 nums[i] == nums[j] 且 i < j ，就可以认为这是一组 好数对 。

            返回好数对的数目
        */
        public int NumIdenticalPairs(int[] nums)
        {
            int count = 0;
            for (var i = 0; i < nums.Length; i++)
            {
                for (var j = i + 1; j < nums.Length; j++) 
                {
                    if (nums[i] == nums[j])
                    {
                        count++;
                    }
                }
            }
            return count;
        }

        /*
         * 给你一个数组 candies 和一个整数 extraCandies ，其中 candies[i] 代表第 i 个孩子拥有的糖果数目。

            对每一个孩子，检查是否存在一种方案，将额外的 extraCandies 个糖果分配给孩子们之后，此孩子有 最多 的糖果。注意，允许有多个孩子同时拥有 最多 的糖果数目。

        */
        public IList<bool> KidsWithCandies(int[] candies, int extraCandies)
        {
            IList<bool> blist = new List<bool>();

            int max = candies.Max();
            foreach (var item in candies)
            {
                if (item + extraCandies >= max)
                {
                    blist.Add(true);
                }
                else 
                {
                    blist.Add(false);
                }
            }

            return blist;
        }

    }
}
