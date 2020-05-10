using System.Collections.Generic;

namespace BPMNUtils.Models.Process.Activities
{
    public class GlobalTask : CallableElement
    {

        public virtual IList<ResourceRole> Resources { get; } = new List<ResourceRole>();
    }
}
