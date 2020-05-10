using BPMNUtils.Models.DC;

namespace BPMNUtils.Models.DI
{
    public abstract class Label : Node
    {
        public virtual Bounds Bounds { get; set; }
    }
}
