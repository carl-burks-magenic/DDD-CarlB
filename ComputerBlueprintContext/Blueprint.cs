using Events.ComputerBlueprintEvents;
using SharedKernel;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ComputerBlueprintContext
{
    public class Blueprint : IEventContainer, IEntity<string>
    {
        public string Id { get; }
        public BlueprintStatus BlueprintStatus { get; private set; }

        public IEnumerable<Part> PartsList {
            get => _parts;
        }
        private List<Part> _parts = new List<Part>();
        private readonly IEnumerable<IPartValidator> partValidators;

        public Blueprint(IEnumerable<IPartValidator> partValidators)
        {
            this.partValidators = partValidators;
        }
        // building in any order is desired, so validation should be at the end before "PublishingBlueprint"
        //public bool CanAddPart(Part part)
        //{
        //    // New part valid?
        //    List<Part> parts = _parts.Union(new List<Part> { part }).ToList();
        //    return parts.All(p => p.Validate(parts, p));
        //}
        public void AddPart(Part part)
        {

        }
        private string _reviewer;
        private string _reviewDate;
        public string Reviewer { get; }
        public string ReviewDate { get; }


        /// <summary>
        /// A human specifically reviewed the parts list and signs off that they work together.
        /// </summary>
        /// <param name="ReviewerName"></param>
        public void ReviewPartsList(string ReviewerName)
        {
            // update status to reviewed
            //implementation here
            AddDomainEvent(new BlueprintReviewedEvent(this.Id, ReviewerName, DateTime.Now));
        }
        public void PublishBlueprint()
        {
            // Validate here
            // If valid:
            //     updatestatus to published
            AddDomainEvent(new BlueprintPublishedEvent(this.Id));
            // else:
            AddDomainEvent(new BlueprintPublishFailureEvent(this.Id));
        }

        public void PublishEvents()
        {
            //Implementation Details
        }
        public void AddDomainEvent(IDomainEvent domainEvent)
        {
            //Implementation Details
        }
    }
}
