using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _LeetCode_Easy.Concrete.DesignOOP
{
    public class ParkingSystem
    {
        public int[] CarSpace { get; set; } = new int[3];

        public ParkingSystem(int big, int medium, int small)
        {
            CarSpace[0] = big;
            CarSpace[1] = medium;
            CarSpace[2] = small;
        }

        public bool AddCar(int carType)
        {
            var isAvailable = false;

            if (CarSpace[carType] > 0) isAvailable = true;

            return isAvailable;
        }
    }
}