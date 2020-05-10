using System.Collections.Generic;
using BPMNUtils.Models.Foundation;

namespace BPMNUtils.Models.Collaboration
{
    public class LaneSet : BaseElement
    {

        public virtual IList<Lane> Lanes { get; } = new List<Lane>();

        public virtual string Name { get; set; }
    }
}
