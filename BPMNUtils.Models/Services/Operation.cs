using System.Collections.Generic;
using BPMNUtils.Models.Common;
using BPMNUtils.Models.Foundation;

namespace BPMNUtils.Models.Services
{
    public class Operation : BaseElement
    {

        public string Name { get; set; }

        public virtual Interface Interface { get; set; }

        public string ImplementationRef { get; set; }

        public virtual Message InMessageRef { get; set; }

        public virtual Message OutMessageRef { get; set; }

        public virtual IList<Error> ErrorRefs { get; protected set; } = new List<Error>();
    }
}
