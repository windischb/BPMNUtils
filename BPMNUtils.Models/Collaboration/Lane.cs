using BPMNUtils.Models.Foundation;
using BPMNUtils.Models.Process;

namespace BPMNUtils.Models.Collaboration
{
    public class Lane : BaseElement
    {
        public virtual string Name { get; set; }

        public virtual FlowNode FlowNodeRef { get; set; }

        public virtual LaneSet ChildLaneSet { get; set; }

        public virtual BaseElement PartitionElement { get; set; }

        public virtual BaseElement PartitionElementRef { get; set; }
    }
}