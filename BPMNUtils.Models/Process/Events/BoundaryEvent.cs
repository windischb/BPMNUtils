using BPMNUtils.Models.Common;
using BPMNUtils.Models.Process.Activities;

namespace BPMNUtils.Models.Process.Events
{
    public class BoundaryEvent : CatchEvent
    {
        public virtual bool CancelActivity { get; set; }

        public virtual Activity AttachedToRef { get; set; }

    }
}
