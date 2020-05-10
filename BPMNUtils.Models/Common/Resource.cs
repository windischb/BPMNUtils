using System.Collections.Generic;
using BPMNUtils.Models.Foundation;

namespace BPMNUtils.Models.Common
{
    public class Resource : RootElement
    {
        public virtual string Name { get; set; }
        
        public virtual IList<ResourceParameter> Parameters { get; protected set; } = new List<ResourceParameter>();
    }
}
