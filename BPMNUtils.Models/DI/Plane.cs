using System.Collections.Generic;

namespace BPMNUtils.Models.DI
{
    public abstract class Plane : Node
    {
        public virtual IList<DiagramElement> DiagramElements { get; } = new List<DiagramElement>();
    }
}
