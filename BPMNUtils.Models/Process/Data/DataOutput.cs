using BPMNUtils.Models.Common;
using BPMNUtils.Models.Foundation;

namespace BPMNUtils.Models.Process.Data
{
    public class DataOutput : BaseElement, IItemAwareElement
    {
        public DataState DataState { get; set; }

        public string Name { get; set; }

        public virtual ItemDefinition ItemSubjectRef { get; set; }

        public bool IsCollection { get; set; }
    }
}
