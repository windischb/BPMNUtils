using System.Collections.Generic;
using BPMNUtils.Models.Foundation;

namespace BPMNUtils.Models.Process.Data
{
    public class OutputSet : BaseElement
    {

        public virtual ICollection<DataOutput> DataOutputRefs { get; } = new List<DataOutput>();

        public virtual ICollection<DataOutput> OptionalOutputRefs { get; } = new List<DataOutput>();

        public virtual ICollection<DataOutput> WhileExecutingOutputRefs { get; } = new List<DataOutput>();

        public virtual ICollection<InputSet> InputSetRefs { get; } = new List<InputSet>();

        public virtual string Name { get; set; }
    }
}
