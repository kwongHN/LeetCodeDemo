using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeDemo
{
    class Class0416
    {
        /*
         * 
         * 给你一个非负整数 num ，请你返回将它变成 0 所需要的步数。 如果当前数字是偶数，你需要把它除以 2 ；否则，减去 1 。
         */
        public int NumberOfSteps(int num)
        {
            int count = 0;
            while (num != 0)
            {
                if (num % 2 == 0)
                {
                    num = num / 2;
                }
                else
                {
                    num = num - 1;
                }
                count++;
            }
            return count;

        }

        /*
         * 平面上有 n 个点，点的位置用整数坐标表示 points[i] = [xi, yi] 。请你计算访问所有这些点需要的 最小时间（以秒为单位）。

            你需要按照下面的规则在平面上移动：

                每一秒内，你可以：
                    沿水平方向移动一个单位长度，或者
                    沿竖直方向移动一个单位长度，或者
                    跨过对角线移动 sqrt(2) 个单位长度（可以看作在一秒内向水平和竖直方向各移动一个单位长度）。
                必须按照数组中出现的顺序来访问这些点。
                在访问某个点时，可以经过该点后面出现的点，但经过的那些点不算作有效访问。

         * 
         */
        public int MinTimeToVisitAllPoints(int[][] points)
        {
            int count = 0;
            int x = points[0][0];
            int y = points[0][1];
            for (var i = 0; i < points.Length - 1; i++)
            {
                while (x != points[i + 1][0] || y != points[i + 1][1])
                {
                    if (x != points[i + 1][0])
                    {
                        if (x < points[i + 1][0])
                        {
                            x++;
                        }
                        else
                        {
                            x--;
                        }
                    }

                    if (y != points[i + 1][1])
                    {
                        if (y < points[i + 1][1])
                        {
                            y++;
                        }
                        else
                        {
                            y--;
                        }
                    }                    
                    count++;
                }
            }

            int time = 0;
            for (int i = 1; i < points.Length; i++)
            {
                time += Math.Max(Math.Abs(points[i][0] - points[i - 1][0]), Math.Abs(points[i][1] - points[i - 1][1]));
            }
            return time;

            return count;

        }
    }
}
