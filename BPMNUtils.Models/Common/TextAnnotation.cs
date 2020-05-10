namespace BPMNUtils.Models.Common
{
    public class TextAnnotation : Artifact
    {
        public virtual string Text { get; set; }

        public virtual string TextFormat { get; set; } = "text/plain";
    }
}