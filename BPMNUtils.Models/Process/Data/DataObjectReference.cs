using BPMNUtils.Models.Common;

namespace BPMNUtils.Models.Process.Data
{
    public class DataObjectReference : FlowElement, IItemAwareElement
    {
        public virtual DataState DataState { get; set; }

        public virtual ItemDefinition ItemSubjectRef { get; set; }

        public virtual DataObject DataObjectRef { get; set; }
    }
}
