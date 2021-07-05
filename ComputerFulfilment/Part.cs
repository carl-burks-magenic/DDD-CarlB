using SharedKernel;
using System;
using System.Collections.Generic;
using System.Text;

namespace ComputerFulfilment
{
    public class Part
    {
        public string Id { get; } //wordId vs guid for ease of human interaction
        public string Name { get; }
        public string SerialNumber { get; }
        public ShippingInfo ShippingInfo { get; }
        public VendorInfo VendorInfo { get; }
        public string PartTester { get; }
        public PartStatus status { get; }
        public WarehouseLocation WarehouseLocation { get; }
    }
}
