using System.Collections.Generic;
using BPMNUtils.Models.Common;
using BPMNUtils.Models.Foundation;

namespace BPMNUtils.Models.Collaboration
{
    public class Collaboration : RootElement
    {

        public virtual string Name { get; set; }

        public virtual bool IsClosed { get; set; }

        public virtual IList<Participant> Participants { get; } = new List<Participant>();
    

        public virtual IList<MessageFlow> MessageFlows { get; } = new List<MessageFlow>();

        public virtual IList<Artifact> Artifacts { get; } = new List<Artifact>();

        public virtual IList<ConversationNode> ConversationNodes { get; } = new List<ConversationNode>();

        public virtual IList<ConversationAssociation> ConversationAssociations { get; } = new List<ConversationAssociation>();

        public virtual IList<MessageFlowAssociation> MessageFlowAssociations { get; } = new List<MessageFlowAssociation>();

        public virtual IList<CorrelationKey> CorrelationKeys { get; } = new List<CorrelationKey>();

        public virtual IList<string> ChoreographyRefs { get; } = new List<string>();

        public virtual IList<ConversationLink> ConversationLinks { get; } = new List<ConversationLink>();
    }
}
