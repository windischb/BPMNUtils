using System.Collections.Generic;
using BPMNUtils.Models.Common;

namespace BPMNUtils.Models.Process.Activities
{
    public class GlobalUserTask : GlobalTask
    {
        public virtual IList<Rendering> Renderings { get; }

        public virtual string Implementation { get; set; }
    }
}
