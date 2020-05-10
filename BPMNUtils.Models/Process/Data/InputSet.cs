using System.Collections.Generic;
using BPMNUtils.Models.Foundation;

namespace BPMNUtils.Models.Process.Data
{
    public class InputSet : BaseElement
    {


        public virtual IList<DataInput> DataInputRefs { get; } = new List<DataInput>();

        public virtual IList<DataInput> OptionalInputRefs { get; } = new List<DataInput>();

        public virtual IList<DataInput> WhileExecutingInputRefs { get; } = new List<DataInput>();

        public virtual IList<OutputSet> OutputSetRefs { get; } = new List<OutputSet>();

        public virtual string Name { get; set; }
    }
}
