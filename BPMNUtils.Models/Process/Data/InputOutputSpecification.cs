using System.Collections.Generic;
using BPMNUtils.Models.Foundation;

namespace BPMNUtils.Models.Process.Data
{
    public class InputOutputSpecification : BaseElement
    {
        public virtual IList<DataInput> DataInputs { get; } = new List<DataInput>();

        public virtual IList<DataOutput> DataOutputs { get; } = new List<DataOutput>();

        public virtual List<InputSet> InputSets { get; } = new List<InputSet>();

        public virtual List<OutputSet> OutputSets { get; } = new List<OutputSet>();
    }
}
