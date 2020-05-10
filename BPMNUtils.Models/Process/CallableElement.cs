using System.Collections.Generic;
using BPMNUtils.Models.Foundation;
using BPMNUtils.Models.Process.Data;
using BPMNUtils.Models.Services;

namespace BPMNUtils.Models.Process
{
    public abstract class CallableElement : RootElement
    {
        public virtual IList<Interface> SupportedInterfaceRefs { get; protected set; } = new List<Interface>();

        public virtual InputOutputSpecification IOSpecification { get; set; }

        public virtual IList<InputOutputBinding> IOBindings { get; protected set; } = new List<InputOutputBinding>();

        public virtual string Name { get; set; }
    }
}
