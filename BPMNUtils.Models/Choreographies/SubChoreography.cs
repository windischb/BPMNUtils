using System.Collections.Generic;
using BPMNUtils.Models.Common;

namespace BPMNUtils.Models.Choreographies
{
    public class SubChoreography : ChoreographyActivity
    {
        public virtual IList<FlowElement> FlowElements { get; }  = new List<FlowElement>();

        public virtual IList<Artifact> Artifacts { get; }  = new List<Artifact>();

    }
}
