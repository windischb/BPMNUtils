using BPMNUtils.Models.Foundation;
using BPMNUtils.Models.Process.Data;

namespace BPMNUtils.Models.Common
{
    public class DataStore : RootElement
    {
        public virtual string Name { get; set; }

        public virtual int? Capacity { get; set; }

        public virtual bool IsUnlimited { get; set; } = true;

        public virtual ItemDefinition ItemSubjectRef { get; set; }

        public DataState DataState { get; set; }
    }
}
