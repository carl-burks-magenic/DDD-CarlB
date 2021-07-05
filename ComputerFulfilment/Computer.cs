using ComputerFulfilment.Events;
using SharedKernel;
using System;
using System.Linq;
using System.Collections.Generic;

namespace ComputerFulfilment
{
    public class Computer : IEventContainer
    {
        public string Id { get; } //wordId vs guid for ease of human interaction
        public IEnumerable<Part> Parts { get; }
        private ComputerStatus computerStatus;
        public ComputerStatus ComputerStatus { get => computerStatus; }

        public string InstallationNotes { get; }        
        public void RecordOrderedParts(
                string PurchaserName,
                IEnumerable<Part> parts,
                System.IO.Stream receipt
                )
        {
            //Implementation here
            //send the receipt to imaging solution
            DocumentReference documentReference = new DocumentReference();
            //Loop the parts and event
            foreach (Part p in parts)
            {
                AddDomainEvent(new PartOrderedEvent(this.Id, documentReference.DocumentId, p.SerialNumber, p.ShippingInfo.ShippingProvider,p.ShippingInfo.ShippingProviderTrackingId, PurchaserName));

            }
        }
        public void RecordInitialShippingInfo(Part part, ShippingInfo shippingInfo)
        {
            //Implementation here
            AddDomainEvent(new PartShippingInformationAvailableEvent(this.Id, part.Id, part.ShippingInfo.ShippingProvider, part.ShippingInfo.ShippingProviderTrackingId));
        }
        public void RecordPartsReceived(IEnumerable<Part> parts,
                System.IO.Stream manifest)
        {

            //send the manifest to imaging solution
            DocumentReference documentReference = new DocumentReference();
            //put it in the warehouse
            foreach(Part part in parts)
            {
                //Implementation here
                AddDomainEvent(new PartReceivedEvent(this.Id, part.Id, documentReference.DocumentId, part.WarehouseLocation.Aisle, part.WarehouseLocation.ShelfNumber));
            }
        }
        public void RecordPartTested(string tester, DateTime testedOnDate, Part part)
        {
            //Implementation here
            AddDomainEvent(new PartTestedEvent(tester, testedOnDate, this.Id, part.Id));
        }
        public void RecordPartBlocked(string setBlockedBy, DateTime blockedOnDate, Part part, string notes)
        {
            AddDomainEvent(new PartBlockedEvent(setBlockedBy, blockedOnDate, this.Id, part.Id, notes));
        }
        public void RecordPartInstalled(string installedBy, DateTime installedOnDate, Part part, string notes)
        {
            AddDomainEvent(new PartInstalledEvent(installedBy, installedOnDate, this.Id, part.Id, notes));
            if(Parts.All(p=>p.status== PartStatus.Installed)){
                computerStatus = ComputerStatus.PhysicallyComplete;
                AddDomainEvent(new ComputerPhysicallyCompletedEvent(this.Id));
            }
        }
        public void AddNotes(string notes)
        {
            // Add notes
            AddDomainEvent(new NewNotesEvent(this.Id, notes));

        }
        public void ReplacePart(Part badPart, Part newPart)
        {
            // computer should be blocked to perform this action
            AddDomainEvent(new ReplacementPartInstalledEvent(this.Id, badPart, newPart));
        }
        public void RecordComputerFailedDiagnostics(string notes)
        {
            //Implementation here
            // set status to blocked
            // set installation notes
            AddDomainEvent(new ComputerFailedDiagnosticsEvent(this.Id));
        }
        public void RecordComputerPassedDiagnostics()
        {
            //Implementation here
            AddDomainEvent(new ComputerPassedDiagnosticsEvent(this.Id));
        }
        public void PublishEvents()
        {
            //Implementation here

        }

        public void AddDomainEvent(IDomainEvent domainEvent)
        {
            //Implementation here

        }
    }
}
