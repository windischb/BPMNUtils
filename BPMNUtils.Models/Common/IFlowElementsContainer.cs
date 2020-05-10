using System.Collections.Generic;

namespace BPMNUtils.Models.Common
{
    public interface IFlowElementsContainer
    {
        IList<FlowElement> FlowElements { get; }

        IList<Artifact> Artifacts { get; }


    }
}
