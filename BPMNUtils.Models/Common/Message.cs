using BPMNUtils.Models.Foundation;

namespace BPMNUtils.Models.Common
{ 
    public class Message : RootElement
    {
        public virtual string Name { get; set; }

        public virtual ItemDefinition ItemRef { get; set; }
    }
}
