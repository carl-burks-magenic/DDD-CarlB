using SharedKernel;
using System;
using System.Collections.Generic;
using System.Text;

namespace Events.ComputerFulfilmentEvents
{
    class PartTestedEvent : IDomainEvent
    {
        public PartTestedEvent(string Tester, DateTime testedOnDate, string computerId, string partId)
        {

        }
        public string Tester { get;  }
        public DateTime TestedOnDate { get;  }
    }
}
