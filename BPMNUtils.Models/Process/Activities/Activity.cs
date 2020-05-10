using System.Collections.Generic;
using BPMNUtils.Models.Process.Data;

namespace BPMNUtils.Models.Process.Activities
{
    public abstract class Activity : FlowNode
    {
        public virtual InputOutputSpecification IOSpecification { get; set; }

        public virtual IList<Property> Properties { get; protected set; } = new List<Property>();

        public virtual IList<DataInputAssociation> DataInputAssociations { get; protected set; } = new List<DataInputAssociation>();

        public virtual IList<DataOutputAssociation> DataOutputAssociations { get; protected set; } = new List<DataOutputAssociation>();

        public virtual IList<ResourceRole> Resources { get; protected set; } = new List<ResourceRole>();

        public virtual LoopCharacteristics LoopCharacteristics { get; set; }

        public virtual bool IsForCompensation { get; set; }

        public virtual int StartQuantity { get; set; }

        public virtual int CompletionQuantity { get; set; }

        public virtual SequenceFlow Default { get; set; }
    }
}
