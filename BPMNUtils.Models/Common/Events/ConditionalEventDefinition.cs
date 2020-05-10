namespace BPMNUtils.Models.Common
{
    public class ConditionalEventDefinition : EventDefinition
    {
        public virtual Expression Condition { get; set; }
    }
}