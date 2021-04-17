using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeDemo
{
    partial class Class0401
    {
        /*
         * 给你一个 m x n 的整数网格 accounts ，其中 accounts[i][j] 是第 i​​​​​​​​​​​​ 位客户在第 j 家银行托管的资产数量。返回最富有客户所拥有的 资产总量 。

            客户的 资产总量 就是他们在各家银行托管的资产数量之和。最富有客户就是 资产总量 最大的客户。

         */
        public int MaximumWealth(int[][] accounts)
        {
            int maxCount = 0;
            foreach (var line in accounts)
            {
                maxCount = Math.Max(maxCount, line.Sum());
            }
            return maxCount;
        }
    }


    partial class ParkingSystem
    {
        /*
         * 请你给一个停车场设计一个停车系统。停车场总共有三种不同大小的车位：大，中和小，每种尺寸分别有固定数目的车位。

            请你实现 ParkingSystem 类：

            ParkingSystem(int big, int medium, int small) 初始化 ParkingSystem 类，三个参数分别对应每种停车位的数目。
            bool addCar(int carType) 检查是否有 carType 对应的停车位。 carType 有三种类型：大，中，小，分别用数字 1， 2 和 3 表示。一辆车只能停在  carType 对应尺寸的停车位中。如果没有空车位，请返回 false ，否则将该车停入车位并返回 true 。
        */
        private int _big;
        private int _medium;
        private int _small;

        public ParkingSystem(int big, int medium, int small)
        {
            this._big = big;
            this._medium = medium;
            this._small = small;
        }

        public bool AddCar(int carType)
        {
            switch (carType)
            {
                case 1:
                    if (this._big > 0)
                    {
                        _big--;
                        return true;
                    }
                    else {
                        return false;
                    }
                case 2:
                    if (this._medium > 0)
                    {
                        _medium--;
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                case 3:
                    if (this._small > 0)
                    {
                        _small--;
                        return true;
                    }
                    else
                    {
                        return false;
                    }
            }
            return false;
        }

    }
}
