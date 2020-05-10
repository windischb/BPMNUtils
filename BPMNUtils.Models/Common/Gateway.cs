using BPMNUtils.Models.Process;

namespace BPMNUtils.Models.Common
{  
    public abstract class Gateway : FlowNode
    {

        public virtual GatewayDirection GatewayDirection { get; set; } = GatewayDirection.Unspecified;

        public virtual SequenceFlow Default { get; set; }
    }
}
