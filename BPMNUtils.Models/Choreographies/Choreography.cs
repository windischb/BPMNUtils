using System.Collections.Generic;
using BPMNUtils.Models.Common;

namespace BPMNUtils.Models.Choreographies
{
    public class Choreography : Collaboration.Collaboration
    {
        public virtual IList<FlowElement> FlowElements { get; } = new List<FlowElement>();
    }
}
