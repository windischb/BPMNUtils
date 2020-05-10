using System.Collections.Generic;
using BPMNUtils.Models.Collaboration;
using BPMNUtils.Models.Process;

namespace BPMNUtils.Models.Choreographies
{
    public abstract class ChoreographyActivity : FlowNode
    {
        public virtual string InitiatingParticipantRef { get; set; }

        public virtual ChoreographyLoopType LoopType { get; set; }

        public virtual IList<string> ParticipantRefs { get; } = new List<string>();

        public virtual IList<CorrelationKey> CorrelationKeys { get; } = new List<CorrelationKey>();
    }
}
