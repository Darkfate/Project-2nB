using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GameCore.Actors.Interfaces;

namespace GameCore.Data
{
    public class Warrior : IClass
    {
        public StatSet startingStats
        {
            get
            {
                return new StatSet(7, 4, 5);
            }
        }

        public StatGrowthRate growthRate
        {
            get
            {
                return new StatGrowthRate(190, 70, 140);
            }
        }
    }

    public class Thief : IClass
    {
        public StatSet startingStats
        {
            get
            {
                return new StatSet(4, 4, 8);
            }
        }

        public StatGrowthRate growthRate
        {
            get
            {
                return new StatGrowthRate(120, 120, 160);
            }
        }
    }

    public class Mage : IClass
    {
        public StatSet startingStats
        {
            get
            {
                return new StatSet(8, 4, 4);
            }
        }

        public StatGrowthRate growthRate
        {
            get
            {
                return new StatGrowthRate(90, 220, 90);
            }
        }
    }

    public class ClassList
    {
        public static IClass[] All
        {
            get
            {
                return new IClass[]
                {
                    new Warrior(),
                    new Mage(),
                    new Thief(),
                };
            }
        }
    }
}