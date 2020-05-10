using System.Collections.Generic;

namespace BPMNUtils.Models.Extensions
{
    public interface IScriptEnabledElement
    {
        IList<Script> Scripts { get; }
    }
}
