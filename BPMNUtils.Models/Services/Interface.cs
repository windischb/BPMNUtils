using System.Collections.Generic;
using BPMNUtils.Models.Foundation;

namespace BPMNUtils.Models.Services
{
    public class Interface : RootElement
    {
        public virtual string Name { get; set; }

        public virtual string ImplementationRef { get; set; }

        public virtual List<Operation> Operations { get; protected set; } = new List<Operation>();
    }
}
