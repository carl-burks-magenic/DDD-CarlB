using System;
using System.Collections.Generic;
using System.Text;

namespace ComputerBlueprintContext
{
    public interface IPinoutProvider
    {
        public Pinout Pinout { get; }
    }
}
