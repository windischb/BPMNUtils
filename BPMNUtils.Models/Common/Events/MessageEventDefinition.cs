using BPMNUtils.Models.Services;

namespace BPMNUtils.Models.Common
{
    public class MessageEventDefinition : EventDefinition
    {
        public virtual Operation OperationRef { get; set; }

        public virtual Message MessageRef { get; set; }
    }
}