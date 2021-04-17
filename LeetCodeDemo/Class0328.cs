using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeDemo
{
    //字符串的左旋转操作是把字符串前面的若干个字符转移到字符串的尾部。请定义一个函数实现字符串左旋转操作的功能。比如，输入字符串"abcdefg"和数字2，该函数将返回左旋转两位得到的结果"cdefgab"。
    class Class0328
    {
        public static string ReverseLeftWords()
        {
            string s = "lrloseumgh";
            int n = 6;
            string result = "";

            result = s.Substring(n, s.Length - n) + s.Substring(0, n);

            //最优解 三次翻转
            

            return result;
        }
    }
}
