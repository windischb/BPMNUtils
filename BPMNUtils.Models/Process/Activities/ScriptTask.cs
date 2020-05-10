namespace BPMNUtils.Models.Process.Activities
{
    public class ScriptTask : Task
    {
        public virtual string Script { get; set; }

        public virtual string ScriptFormat { get; set; }

    }
}
