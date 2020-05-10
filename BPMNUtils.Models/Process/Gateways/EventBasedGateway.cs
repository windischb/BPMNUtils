using BPMNUtils.Models.Common;

namespace BPMNUtils.Models.Process.Gateways
{
    public class EventBasedGateway : Gateway
    {
        public virtual bool Instantiate { get; set; }

        public virtual EventBasedGatewayType EventGatewayType { get; set; } = EventBasedGatewayType.Exclusive;

    }
}
