namespace BPMNUtils.Models.DI
{
    public abstract class LabeledEdge : Edge
    {
        public abstract Label Label { get; set; }
    }
}
