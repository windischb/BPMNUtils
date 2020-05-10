using BPMNUtils.Models.Foundation;

namespace BPMNUtils.Models.Common
{
    public class Signal : RootElement
    {
        public virtual string Name { get; set; }

        public virtual ItemDefinition StructureRef { get; set; }
    }
}
