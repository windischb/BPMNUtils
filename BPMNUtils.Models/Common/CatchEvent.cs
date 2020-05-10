using System.Collections.Generic;
using BPMNUtils.Models.Process.Data;

namespace BPMNUtils.Models.Common
{
    public abstract class CatchEvent : Event
    {
       

        public virtual IList<DataOutput> DataOutputs { get; protected set; } = new List<DataOutput>();

        public virtual IList<DataOutputAssociation> DataOutputAssociations { get; protected set; } = new List<DataOutputAssociation>();

        public virtual OutputSet OutputSet { get; set; }

        public virtual IList<EventDefinition> EventDefinitions { get; protected set; } = new List<EventDefinition>();

        public virtual IList<EventDefinition> EventDefinitionRefs  { get; protected set; } = new List<EventDefinition>();

        public virtual bool ParallelMultiple { get; set; }
    }
}
