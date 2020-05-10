using System;
using BPMNUtils.Models.Foundation;

namespace BPMNUtils.Models.Collaboration
{
    public class Participant : BaseElement
    {
        public virtual string Name { get; set; }

        public virtual String processRef { get; set; }

        public virtual string InterfaceRef { get; set; }

        public virtual string EndPointRef { get; set; }

        public virtual ParticipantMultiplicity ParticipantMultiplicity { get; set; }
    }
}
