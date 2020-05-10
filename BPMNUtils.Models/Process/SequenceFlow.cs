using System.Collections.Generic;
using BPMNUtils.Models.Common;
using BPMNUtils.Models.Extensions;

namespace BPMNUtils.Models.Process
{
    public class SequenceFlow : FlowElement, IScriptEnabledElement
    {
        public virtual Expression ConditionExpression { get; set; }

        public virtual IList<Script> Scripts { get; protected set; } = new List<Script>();

        public virtual FlowNode SourceRef { get; set; }

        public virtual FlowNode TargetRef { get; set; }

        public bool? IsImmediate { get; set; }


        public override string ToString()
        {
            return $"{this.Id}, {this.Name}";
        }
    }
}
