using BPMNUtils.Models.Common;
using BPMNUtils.Models.Services;

namespace BPMNUtils.Models.Process.Activities
{
    public class ReceiveTask : Task
    {
        public virtual string Implementation { get; set; }

        public virtual bool Instantiate { get; set; }

        public virtual Message MessageRef { get; set; }

        public virtual Operation OperationRef { get; set; }

    }
}
