using BPMNUtils.Models.Foundation;

namespace BPMNUtils.Models.Common
{
    public class ItemDefinition : RootElement
    {
        public virtual string StructureRef { get; set; }

        public virtual bool IsCollection { get; set; }

        public virtual ItemKind ItemKind { get; set; }
    }
}
