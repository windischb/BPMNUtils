using BPMNUtils.Models.Services;

namespace BPMNUtils.Models.Process.Activities
{
    public class ServiceTask : Task
    { 
        public virtual string Implementation { get; set; }

        public virtual Operation OperationRef { get; set; }


    }
}
