namespace BPMNUtils.Models.Process.Activities
{
    public class GlobalScriptTask : GlobalTask
    {
        public virtual string Script { get; set; }

        public virtual string ScriptLanguage { get; set; }
    }
}
