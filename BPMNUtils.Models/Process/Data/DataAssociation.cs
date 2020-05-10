using System.Collections.Generic;
using BPMNUtils.Models.Common;
using BPMNUtils.Models.Foundation;

namespace BPMNUtils.Models.Process.Data
{
    public abstract class DataAssociation : BaseElement
    {
        public virtual IList<IItemAwareElement> SourceRefs { get; protected set; } = new List<IItemAwareElement>();

        public virtual IItemAwareElement TargetRef { get; set; }

        public virtual FormalExpression Transformation { get; set; }

        public virtual IList<Assignment> Assignments { get; protected set; } = new List<Assignment>();
    }
}
