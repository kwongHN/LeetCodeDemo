using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //foreach (var num in Class03217.RunningSum())
            //{
            //    Console.WriteLine(num);
            //}

            int[] p1= new int[] { 1, 1 };
            int[] p2 = new int[] { 3, 4 };
            int[] p3 = new int[] { -1, 0 };
            int[][] points = new int[][] { p1, p2, p3 };

            Console.WriteLine(new Class0416().MinTimeToVisitAllPoints(points));

            Console.ReadLine();
        }
    }
}
