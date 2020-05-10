using BPMNUtils.Models.Foundation;
using BPMNUtils.Models.Process.Data;
using BPMNUtils.Models.Services;

namespace BPMNUtils.Models.Process
{
    public class InputOutputBinding : BaseElement
    {
        public virtual Operation OperationRef { get; set; }

        public virtual InputSet InputDataRef { get; set; }

        public virtual OutputSet OutputDataRef { get; set; }
    }
}