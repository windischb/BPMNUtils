using BPMNUtils.Models.Foundation;

namespace BPMNUtils.Models.Collaboration
{
    public class MessageFlow : BaseElement
    {
        public virtual string Name { get; set; }

        public virtual string SourceRef { get; set; }

        public virtual string TargetRef { get; set; }

        public virtual string MessageRef { get; set; }
    }

}
