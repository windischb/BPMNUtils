using BPMNUtils.Models.Common;

namespace BPMNUtils.Models.Process.Activities
{
    public class AdHocSubProcess : SubProcess
    {
        public virtual Expression CompletionCondition { get; set; }

        public virtual bool CancelRemainingInstances { get; set; }

        public virtual AdHocOrdering Ordering { get; set; }
        
    }
}
