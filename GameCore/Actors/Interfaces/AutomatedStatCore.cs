using System;
using System.Collections.Generic;
using System.Linq;

namespace GameCore.Actors.Interfaces
{
    public class AutomatedStatCore : LevelCore
    {
        public AutomatedStatCore()
        {
            Stats = new StatSet();
            StatGrowthRate = new StatGrowthRate();
        }

        public AutomatedStatCore(StatSet statSet, StatGrowthRate growthRate)
        {
            Stats = statSet;
            StatGrowthRate = growthRate;
        }

        protected override void _levelUpEvent()
        {
            Stats.Strength = Stats.Strength + _increaseAmount(StatGrowthRate.StrGrowthRate);
            Stats.Intelligence = Stats.Intelligence + _increaseAmount(StatGrowthRate.IntGrowthRate);
            Stats.Speed = Stats.Speed + _increaseAmount(StatGrowthRate.SpdGrowthRate);
        }

        private int _increaseAmount(int growthRate)
        {
            int amount = 0;
            int tempGrowthRate = growthRate;

            while (tempGrowthRate > 100)
            {
                amount++;
                tempGrowthRate = tempGrowthRate - 100;
            }

            if (Calculations.TrySuccess(tempGrowthRate))
            {
                amount++;
            }

            return amount;
        }

        public StatSet Stats;
        protected StatGrowthRate StatGrowthRate;
    }

    public class StatSet
    {
        public StatSet()
        {
            Strength = 5;
            Intelligence = 5;
            Speed = 5;
        }

        public StatSet(int str, int intel, int spd)
        {
            Strength = str;
            Intelligence = intel;
            Speed = spd;
        }

        public int Strength { get; set; }

        public int Intelligence { get; set; }

        public int Speed { get; set; }
    }

    public class StatGrowthRate
    {
        public StatGrowthRate()
        {
            StrGrowthRate = 100;
            IntGrowthRate = 100;
            SpdGrowthRate = 100;
        }

        public StatGrowthRate(int strGrowth, int intGrowth, int spdGrowth)
        {
            StrGrowthRate = strGrowth;
            IntGrowthRate = intGrowth;
            SpdGrowthRate = spdGrowth;
        }

        public int StrGrowthRate { get; private set; }

        public int IntGrowthRate { get; private set; }

        public int SpdGrowthRate { get; private set; }
    }
}