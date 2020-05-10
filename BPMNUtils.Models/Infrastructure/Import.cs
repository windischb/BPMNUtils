using BPMNUtils.Models.Foundation;

namespace BPMNUtils.Models.Infrastructure
{
    public class Import : BaseElement
    {
        public string Namespace { get; set; }

        public string Location { get; set; }

        public string ImportType { get; set; }
    }
}
