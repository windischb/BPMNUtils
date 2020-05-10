using System.Collections.Generic;
using BPMNUtils.Models.Foundation;

namespace BPMNUtils.Models.Collaboration
{
    public class CorrelationKey : BaseElement
    {

        public virtual string Name { get; set; }

        public virtual IList<string> CorrelationPropertyRefs { get; } = new List<string>();
    }
}