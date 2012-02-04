using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GameCore.Actors.Interfaces
{
    public interface ICharacter : INamable, IClassable
    {
        AutomatedStatCore Status { get; set; }
    }
}