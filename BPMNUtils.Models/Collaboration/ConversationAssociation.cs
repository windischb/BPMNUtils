using BPMNUtils.Models.Foundation;

namespace BPMNUtils.Models.Collaboration
{
    public class ConversationAssociation : BaseElement
    {
        public virtual string InnerConversationNodeRef { get; set; }

        public virtual string OuterConversationNodeRef { get; set; }
    }
}
