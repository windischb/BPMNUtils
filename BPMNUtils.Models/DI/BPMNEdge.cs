using System.Collections.Generic;
using BPMNUtils.Models.DC;

namespace BPMNUtils.Models.DI
{
    public class BPMNEdge : LabeledEdge, ILabeled
    {

        public virtual IList<Point> Waypoints { get; } = new List<Point>();

        public virtual BPMNLabel BpmnLabel { get; set; }

        public override Label Label
        {
            get => this.BpmnLabel;
            set => this.BpmnLabel = (BPMNLabel)value;
        }

        public virtual string BpmnElement { get; set; }

        public virtual string SourceElement { get; set; }

        public virtual string TargetElement { get; set; }

        public virtual MessageVisibleKind MessageVisibleKind { get; set; }
    }
}
