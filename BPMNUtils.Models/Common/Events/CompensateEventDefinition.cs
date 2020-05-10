using BPMNUtils.Models.Process.Activities;

namespace BPMNUtils.Models.Common
{
    public class CompensateEventDefinition : EventDefinition
    {
        public virtual bool? WaitForCompletion { get; set; }

        public virtual Activity ActivityRef { get; set; }
    }
}