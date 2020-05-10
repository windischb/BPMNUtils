using BPMNUtils.Models.Common;
using BPMNUtils.Models.Foundation;

namespace BPMNUtils.Models.Process
{
    public class ResourceParameterBinding : BaseElement
    {
        public virtual Expression Expression { get; set; }

        public virtual ResourceParameter ParameterRef { get; set; }
    }
}