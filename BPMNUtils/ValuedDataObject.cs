using System;
using System.Collections.Generic;
using System.Linq;
using BPMNUtils.Models.Process.Data;
using BPMNUtils.Types;

namespace BPMNUtils
{
    public class ValuedDataObject : DataObject
    {
        private ITypeHandler typeHandler;

        public virtual void Initialize(BpmnTypes types)
        {
            typeHandler = types.Get(this.TypeName);
        }

        public virtual string TypeName { get; set; }

        public virtual Type ClrType => this.typeHandler.ClrType;

        public virtual IList<string> Values { get; } = new List<string>();

        public virtual object Value
        {
            get
            {
                var values = this.Values.ToArray();
                return this.typeHandler.Parse(values, this.IsCollection);
            }
        }
    }
}
