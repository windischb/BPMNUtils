using BPMNUtils.Models.Foundation;

namespace BPMNUtils.Models.Collaboration
{
    public class ConversationLink : BaseElement
    {
        public virtual string Name { get; set; }

        public virtual string SourceRef { get; set; }

        public virtual string TargetRef { get; set; }
    }
}
