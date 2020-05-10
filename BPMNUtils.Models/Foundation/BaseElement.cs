using System.Collections.Generic;
using BPMNUtils.Models.Extensions;

namespace BPMNUtils.Models.Foundation
{
    public abstract class BaseElement : IBaseElement
    {
        public virtual ExtensionElements ExtensionElements { get; set; }

        public virtual string Id { get; set; }

        public virtual IList<ExtendedAttribute> Attributes { get; protected set; } = new List<ExtendedAttribute>();

        public virtual IList<Documentation> Documentations { get; protected set; } = new List<Documentation>();

        public override string ToString()
        {
            if (this.Id != null)
                return $"{this.GetType().Name} [{this.Id}]";

            return base.ToString();
        }
    }
}
