using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GameCore.Actors.Interfaces
{
    public interface IClassable
    {
        IClass Class { get; }
    }

    public interface IClass
    {
        StatSet startingStats { get; }

        StatGrowthRate growthRate { get; }
    }
}