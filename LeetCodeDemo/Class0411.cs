using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeDemo
{
    class Class0411
    {
        //这是第二次测试提交gitHub

        /*
         * 给你一个以行程长度编码压缩的整数列表 nums 。

            考虑每对相邻的两个元素 [freq, val] = [nums[2*i], nums[2*i+1]] （其中 i >= 0 ），每一对都表示解压后子列表中有 freq 个值为 val 的元素，你需要从左到右连接所有子列表以生成解压后的列表。

            请你返回解压后的列表。

            输入：nums = [1,2,3,4]
            输出：[2,4,4,4]
            解释：第一对 [1,2] 代表着 2 的出现频次为 1，所以生成数组 [2]。
            第二对 [3,4] 代表着 4 的出现频次为 3，所以生成数组 [4,4,4]。
            最后将它们串联到一起 [2] + [4,4,4] = [2,4,4,4]。

         */
        public int[] DecompressRLElist(int[] nums)
        {
            List<int> result = new List<int>();
            for (int i = 0; i < nums.Length; i += 2)
            {
                for (var j = 0; j < nums[i]; j++)
                {
                    result.Add(nums[i+1]);
                }                
            }
            return result.ToArray();
        }
    }
}
