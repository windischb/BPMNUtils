using System.Collections.Generic;
using BPMNUtils.Models.Common;
using BPMNUtils.Models.Extensions;

namespace BPMNUtils.Models.Process
{
    public abstract class FlowNode : FlowElement, IScriptEnabledElement
    {

        public virtual IList<SequenceFlow> Incomings { get; protected set; } = new List<SequenceFlow>();

        public virtual IList<SequenceFlow> Outgoings { get; protected set; } = new List<SequenceFlow>();

        public virtual IList<Script> Scripts { get; protected set; } = new List<Script>();

        public override string ToString()
        {
            return $"{this.GetType().Name}, {this.Id}, {this.Name}";
        }


        public override int GetHashCode()
        {
            if (this.Id != null)
                return this.GetType().Name.GetHashCode() ^ this.Id.GetHashCode();

            return base.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            if (obj is FlowNode flowNode)
                return string.Compare(flowNode.Id, this.Id) == 0;

            return base.Equals(obj);
        }
    }
}
