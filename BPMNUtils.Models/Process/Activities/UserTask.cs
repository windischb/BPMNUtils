using System.Collections.Generic;
using BPMNUtils.Models.Common;

namespace BPMNUtils.Models.Process.Activities
{
    public class UserTask : Task
    {

        public virtual IList<Rendering> Renderings { get; protected set; } = new List<Rendering>();

        public virtual string Implementation { get; set; }  = "##unspecified";
    }
}
