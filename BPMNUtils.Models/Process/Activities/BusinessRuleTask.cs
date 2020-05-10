namespace BPMNUtils.Models.Process.Activities
{
    public class BusinessRuleTask : Task
    {
        public virtual string Implementation { get; set; } = "##WebService";

    }
}
