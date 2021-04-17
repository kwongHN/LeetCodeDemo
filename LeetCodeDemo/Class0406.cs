using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeDemo
{
    class Class0406
    {
        /*测试同步*/
        /*
         * 请你设计一个可以解释字符串 command 的 Goal 解析器 。command 由 "G"、"()" 和/或 "(al)" 按某种顺序组成。Goal 解析器会将 "G" 解释为字符串 "G"、"()" 解释为字符串 "o" ，"(al)" 解释为字符串 "al" 。然后，按原顺序将经解释得到的字符串连接成一个字符串。

            给你字符串 command ，返回 Goal 解析器 对 command 的解释结果。
         */

        public string Interpret(string command)
        {
            return command.Replace("()", "o").Replace("(al)", "al");
        }

        /*
         * 给你两个整数数组 nums 和 index。你需要按照以下规则创建目标数组：

            目标数组 target 最初为空。
            按从左到右的顺序依次读取 nums[i] 和 index[i]，在 target 数组中的下标 index[i] 处插入值 nums[i] 。
            重复上一步，直到在 nums 和 index 中都没有要读取的元素。
            请你返回目标数组。

            题目保证数字插入位置总是存在。
         */
        public int[] CreateTargetArray(int[] nums, int[] index)
        {
            int[] ans = nums.Clone() as int[];
            for (int i = 0; i < index.Length; i++)
            {
                var value = index[i];
                if (i == 0 && index[i] == 0) continue;
                for (int j = 0; j < i; j++)
                {
                    if (index[j] >= value)
                    {
                        index[j]++;

                    }
                }

            }
            for (int i = 0; i < nums.Length; i++)
            {
                ans[index[i]] = nums[i];
            }
            return ans;      
        }
    }
}
