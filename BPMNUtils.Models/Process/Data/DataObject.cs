using BPMNUtils.Models.Common;

namespace BPMNUtils.Models.Process.Data
{
    public class DataObject : FlowElement, IItemAwareElement
    {
        public virtual DataState DataState { get; set; }

        public virtual ItemDefinition ItemSubjectRef { get; set; }

        public virtual bool IsCollection { get; set; }
    }
}
