namespace BPMNUtils.Models.Common
{
    public class SignalEventDefinition : EventDefinition
    {
        public virtual Signal SignalRef { get; set; }
    }
}