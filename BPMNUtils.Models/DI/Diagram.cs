namespace BPMNUtils.Models.DI
{
    public abstract class Diagram
    {
        public virtual string Id { get; set; }

        public virtual string Name { get; set; }

        public virtual double? Resolution { get; set; }

        public virtual string Documentation { get; set; }
    }
}
