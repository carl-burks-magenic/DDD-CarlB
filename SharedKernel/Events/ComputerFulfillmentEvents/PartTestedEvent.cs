using SharedKernel;
using System;
using System.Collections.Generic;
using System.Text;

namespace Events.ComputerFulfilmentEvents
{
    public class PartTestedEvent : IDomainEvent
    {
        public PartTestedEvent(string Tester, DateTime testedOnDate, string computerId, string partId)
        {

        }
        public string Tester { get;  }
        public DateTime TestedOnDate { get;  }
    }
}
