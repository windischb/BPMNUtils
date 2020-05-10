using System.Collections.Generic;
using BPMNUtils.Models.Process.Data;

namespace BPMNUtils.Models.Common
{
    public abstract class ThrowEvent : Event
    {

        public virtual IList<DataInput> DataInputs { get; protected set; } = new List<DataInput>();

        public virtual IList<DataInputAssociation> DataInputAssociations { get; protected set; } = new List<DataInputAssociation>();

        public virtual InputSet InputSet { get; set; }

        public virtual List<EventDefinition> EventDefinitions { get; protected set; } = new List<EventDefinition>();

        public virtual List<EventDefinition> EventDefinitionRefs { get; protected set; } = new List<EventDefinition>();
    }
}
