namespace BPMNUtils.Models.Common
{
    public class ErrorEventDefinition : EventDefinition
    {
        public virtual Error ErrorRef { get; set; }
    }
}