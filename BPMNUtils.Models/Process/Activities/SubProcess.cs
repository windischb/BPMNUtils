using System.Collections.Generic;
using BPMNUtils.Models.Common;

namespace BPMNUtils.Models.Process.Activities
{
    public class SubProcess : Activity, IFlowElementsContainer
    {
        public virtual bool TriggeredByEvent { get; set; }

        public virtual IList<FlowElement> FlowElements { get; }

        public virtual IList<Artifact> Artifacts { get; protected set; }  = new List<Artifact>();

        public SubProcess()
        {
            FlowElements = new FlowElementCollection(this);
        }
    }
}
