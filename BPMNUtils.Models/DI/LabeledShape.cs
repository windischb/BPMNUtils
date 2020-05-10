namespace BPMNUtils.Models.DI
{
    public abstract class LabeledShape : Shape
    {
        public abstract Label Label { get; set; }
    }
}
