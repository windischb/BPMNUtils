﻿using BPMNUtils.Models.Foundation;

namespace BPMNUtils.Models.Common
{
    public abstract class FlowElement : BaseElement
    {
        public virtual IFlowElementsContainer Container { get; set; }

        public virtual string Name { get; set; }

        public override string ToString()
        {
            if (!string.IsNullOrEmpty(this.Id))
                return this.Id;

            return base.ToString();
        }
    }
}
