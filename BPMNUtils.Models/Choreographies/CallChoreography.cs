using System.Collections.Generic;
using BPMNUtils.Models.Collaboration;

namespace BPMNUtils.Models.Choreographies
{
    public class CallChoreography : ChoreographyActivity
    {
        public virtual string CalledChoreographyRef { get; set; }

        public virtual IList<ParticipantAssociation> ParticipantAssociations { get; } = new List<ParticipantAssociation>();

    }
}
