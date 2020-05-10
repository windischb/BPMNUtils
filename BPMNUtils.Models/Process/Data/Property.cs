using BPMNUtils.Models.Common;
using BPMNUtils.Models.Foundation;

namespace BPMNUtils.Models.Process.Data
{
    public class Property : BaseElement, IItemAwareElement
    {
        public virtual DataState DataState { get; set; }

        public virtual string Name { get; set; }

        public virtual ItemDefinition ItemSubjectRef { get; set; }
    }
}
