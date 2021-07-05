using System;
using System.Collections.Generic;
using System.Text;

namespace ComputerBlueprintContext
{
    public interface IPowerConsumer
    {
        int WattsConsumed { get; }
    }
}
