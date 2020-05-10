using BPMNUtils.Models.Foundation;

namespace BPMNUtils.Models.Collaboration
{
    public class ParticipantAssociation : BaseElement
    {
        public virtual string InnerParticipantRef { get; set; }

        public virtual string OuterParticipantRef { get; set; }
    }
}
