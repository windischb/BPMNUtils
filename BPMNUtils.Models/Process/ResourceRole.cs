using System.Collections.Generic;
using BPMNUtils.Models.Common;
using BPMNUtils.Models.Extensions;
using BPMNUtils.Models.Foundation;

namespace BPMNUtils.Models.Process
{
    public class ResourceRole : BaseElement
    {

        public ResourceAssignmentExpression AssignmentExpression { get; set; }

        public virtual Resource ResourceRef { get; set; }

        public virtual IList<ResourceParameterBinding> ParameterBindings { get; protected set; } = new List<ResourceParameterBinding>();

        public virtual string Name { get; set; }

        public virtual ResourceType? Type { get; set; }
    }
}
