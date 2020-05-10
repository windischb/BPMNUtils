using BPMNUtils.Models.DC;

namespace BPMNUtils.Models.DI
{
    public abstract class Shape : Node
    {
        public virtual Bounds Bounds { get; set; }
    }
}
