using System.Collections.Generic;

namespace BPMNUtils.Models.Choreographies
{
    public class ChoreographyTask : ChoreographyActivity
    {
        public virtual IList<string> MessageFlowRefs { get; } = new List<string>();

    }
}
