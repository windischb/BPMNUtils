namespace BPMNUtils.Models.Process.Activities
{
    public class CallActivity : Activity
    {
        public virtual string CalledElement { get; set; }

        public virtual CallableElement CalledElementRef { get; set; }

    }
}
