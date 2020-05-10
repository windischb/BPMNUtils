using BPMNUtils.Models.Foundation;

namespace BPMNUtils.Models.Process.Activities
{
    public abstract class LoopCharacteristics : BaseElement
    {
        public virtual Activity Activity { get; set; }

    }
}
