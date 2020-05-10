using BPMNUtils.Models.Foundation;

namespace BPMNUtils.Models.Collaboration
{
    public class MessageFlowAssociation : BaseElement
    {
        public string InnerMessageFlowRef { get; set; }

        public string OuterMessageFlowRef { get; set; }
    }
}
