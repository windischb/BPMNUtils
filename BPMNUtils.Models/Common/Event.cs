using System.Collections.Generic;
using BPMNUtils.Models.Process;
using BPMNUtils.Models.Process.Data;

namespace BPMNUtils.Models.Common
{
    public abstract class Event : FlowNode
    {
        public virtual IList<Property> Properties { get; protected set; } = new List<Property>();
    }
}
