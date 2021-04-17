using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeDemo
{
    class Class0405
    {
        /*
         * 给你一个数组 items ，其中 items[i] = [typei, colori, namei] ，描述第 i 件物品的类型、颜色以及名称。

            另给你一条由两个字符串 ruleKey 和 ruleValue 表示的检索规则。

            如果第 i 件物品能满足下述条件之一，则认为该物品与给定的检索规则 匹配 ：

            ruleKey == "type" 且 ruleValue == typei 。
            ruleKey == "color" 且 ruleValue == colori 。
            ruleKey == "name" 且 ruleValue == namei 。
            统计并返回 匹配检索规则的物品数量 。

         */
        public int CountMatches(IList<IList<string>> items, string ruleKey, string ruleValue)
        {            
            int count = 0;

            int ruleIndex = -1;
            switch (ruleKey)
            {
                case "type":
                    ruleIndex = 0;
                    break;
                case "color":
                    ruleIndex = 1;
                    break;
                case "name":
                    ruleIndex = 2;
                    break;
            }
            if (ruleIndex < 0)
            {
                return count;
            }
            foreach (var item in items)
            {
                if (item[ruleIndex] == ruleValue)
                {
                    count++;
                }
            }
            return count;
        }

        /*
         * 未知 整数数组 arr 由 n 个非负整数组成。

            经编码后变为长度为 n - 1 的另一个整数数组 encoded ，其中 encoded[i] = arr[i] XOR arr[i + 1] 。例如，arr = [1,0,2,1] 经编码后得到 encoded = [1,2,3] 。

            给你编码后的数组 encoded 和原数组 arr 的第一个元素 first（arr[0]）。

            请解码返回原数组 arr 。可以证明答案存在并且是唯一的。
         */
        public int[] Decode(int[] encoded, int first)
        {
            int[] arr = new int[encoded.Length + 1];
            arr[0] = first;
            for (int i = 0; i < encoded.Length; i++)
            {
                arr[i + 1] = arr[i] ^ encoded[i];
            }
            return arr;
        }


        /*
         * 桌上有 n 堆力扣币，每堆的数量保存在数组 coins 中。我们每次可以选择任意一堆，拿走其中的一枚或者两枚，求拿完所有力扣币的最少次数。

            示例 1：

            输入：[4,2,1]

            输出：4

            解释：第一堆力扣币最少需要拿 2 次，第二堆最少需要拿 1 次，第三堆最少需要拿 1 次，总共 4 次即可拿完。

         */
        public int MinCount(int[] coins)
        {
            int count = 0;

            for (var i = 0; i < coins.Length; i++)
            {
                count += coins[i] / 2 + coins[i] % 2;
            }

            return count;
        }


        /*
         * 给你一个整数 n，请你帮忙计算并返回该整数「各位数字之积」与「各位数字之和」的差。
         */
        public int SubtractProductAndSum(int n)
        {
            int ji = n % 10;
            int sum = n % 10;            
            while (n >= 10) 
            {
                n = n / 10;
                ji = ji * (n % 10);
                sum = sum + (n % 10);                
            }

            return ji - sum;
        }
    }
}
