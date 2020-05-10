using System.Collections.Generic;

namespace BPMNUtils.Models.Common
{
    public class LinkEventDefinition : EventDefinition
    {

        public virtual IList<string> Source { get; } = new List<string>();

        public virtual string Target { get; set; }

        public virtual string Name { get; set; }
    }
}