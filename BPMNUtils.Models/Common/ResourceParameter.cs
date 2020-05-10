using BPMNUtils.Models.Foundation;

namespace BPMNUtils.Models.Common
{
    public class ResourceParameter : BaseElement
    {
        public virtual string Name { get; set; }

        public virtual ItemDefinition Type { get; set; }

        public bool? IsRequired { get; set; }

    }
}