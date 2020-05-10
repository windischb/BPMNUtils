namespace BPMNUtils.Models.Common
{
    public class Association : Artifact
    {
        public virtual string SourceRef { get; set; }

        public virtual string TargetRef { get; set; }

        public virtual AssociationDirection AssociationDirection { get; set; }
    }
}