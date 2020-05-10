using BPMNUtils.Models.Common;
using BPMNUtils.Models.Foundation;

namespace BPMNUtils.Models.Process.Data
{
    public class Assignment : BaseElement
    {
        public virtual Expression From { get; set; }

        public virtual Expression To { get; set; }
    }
}
