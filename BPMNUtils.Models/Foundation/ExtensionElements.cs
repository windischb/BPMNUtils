using System.Collections.Generic;
using System.Xml.Linq;

namespace BPMNUtils.Models.Foundation
{
    public class ExtensionElements
    {
        public virtual IList<XElement> Items { get; protected set; } = new List<XElement>();
    }
}
