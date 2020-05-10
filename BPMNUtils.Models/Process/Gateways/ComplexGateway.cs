using BPMNUtils.Models.Common;

namespace BPMNUtils.Models.Process.Gateways
{
    public class ComplexGateway : Gateway
    {
        public virtual Expression ActivationCondition { get; set; }

    }
}
