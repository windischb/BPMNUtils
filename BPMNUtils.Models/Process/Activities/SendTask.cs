using BPMNUtils.Models.Common;
using BPMNUtils.Models.Services;

namespace BPMNUtils.Models.Process.Activities
{
    /// <summary>
    /// Upon activation, the data in the associated Message is assigned from the data in the Data Input of
    /// the Send Task.The Message is sent and the Send Task completes.
    /// </summary>
    public class SendTask : Task
    {
        public virtual string Implementation { get; set; }

        public virtual Message MessageRef { get; set; }

        public virtual Operation OperationRef { get; set; }

    }
}
