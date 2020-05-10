namespace BPMNUtils.Models.Process.Activities
{
    public class Transaction : SubProcess
    {
        public virtual string Method { get; set; } = "##Compensate";

    }
}
