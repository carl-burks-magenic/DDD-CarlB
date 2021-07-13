using System.Collections.Generic;
using System.Linq;
using Events.ComputerFulfilmentEvents;
using SharedKernel;

namespace ComputerFulfilment
{
    public class ReturnablePart: IEventContainer
    {
        public string PartId { get;  }
        public string VendorId { get;  }
        public string VendorIncidentTrackingCode { get;  }
        public string ShippingTrackingCode { get;  }
        public string Notes { get;  }

        public IEnumerable<DocumentReference> DocumentReference { get; }
        public ILocation Location { get;  }
        public ReturnStatus ReturnStatus { get;  }


        public void ShipToVendor(string VendorIncidentTrackingCode, IEnumerable<System.IO.Stream> documentation)
        {
            //Send to imaging system
            //print shipping label and assign
            //update status
            AddDomainEvent(new BrokenPartShippedToVendorEvent(PartId, VendorId, VendorIncidentTrackingCode, ShippingTrackingCode, Notes ));
        }
        public void VendorClaimsNotDefective(IEnumerable<System.IO.Stream> documentation )
        {
            //Send documents to imaging
            List<DocumentReference> documentReferences = new List<DocumentReference>();
            //Set Status to Loss
            AddDomainEvent(new VendorClaimsPartNotDefectiveEvent(PartId, documentReferences.Select(dr=>dr.DocumentId)));
        }
        public void ProcessVendorRefund(IEnumerable<System.IO.Stream> documentation)
        {
            //send documents to imaging
            List<DocumentReference> documentReferences = new List<DocumentReference>();
            //set status refunded
            AddDomainEvent(new VendorRefundedBrokenPartEvent(documentReferences.Select(dr => dr.DocumentId)));
        }

        public void AddDomainEvent(IDomainEvent domainEvent)
        {
        }

        public void PublishEvents()
        {
        }
    }
}
