using BPMNUtils.Models.Common;
using BPMNUtils.Models.Foundation;

namespace BPMNUtils.Models.Process.Data
{
    public interface IItemAwareElement : IBaseElement
    {
        string Name { get; set; }

        ItemDefinition ItemSubjectRef { get; set; }

        DataState DataState { get; set; }
    }
}
