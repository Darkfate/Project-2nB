using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GameCore
{
    public static class Calculations
    {
        public static bool TrySuccess(int chance)
        {
            int benchMark = rand.Next(100);
            return chance >= benchMark;
        }

        private static Random rand = new Random();
    }
}