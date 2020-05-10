using System.Collections.Generic;
using BPMNUtils.Models.Foundation;

namespace BPMNUtils.Models.Collaboration
{
    public class ConversationNode : BaseElement
    {

        public virtual string Name { get; set; }

        public virtual Participant ParticipantRef { get; set; }

        public virtual MessageFlow MessageFlowRef { get; set; }

        public virtual IList<CorrelationKey> CorrelationKeys { get; } = new List<CorrelationKey>();
    }
}
