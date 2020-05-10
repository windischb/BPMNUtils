using System.Collections.Generic;
using System.Linq;
using BPMNUtils.Models.Collaboration;
using BPMNUtils.Models.Common;
using BPMNUtils.Models.Extensions;
using BPMNUtils.Models.Infrastructure;
using BPMNUtils.Models.Process.Data;
using BPMNUtils.Models.Process.Events;

namespace BPMNUtils.Models.Process
{

    public class Process : CallableElement, IFlowElementsContainer, IScriptEnabledElement
    {
        protected bool isExecutable;
        protected ProcessType processType;
        protected bool isClosed;
        private FlowNode initialNode;

        public virtual IList<Property> Properties { get; protected set; } = new List<Property>();

        public virtual IList<FlowElement> FlowElements { get; }

        public virtual IList<Script> Scripts { get; protected set; } = new List<Script>();

        public virtual IList<Artifact> Artifacts { get; protected set; } = new List<Artifact>();

        public virtual IList<ResourceRole> Resources { get; protected set; } = new List<ResourceRole>();
        public virtual Definitions Definitions { get; set; }
        public virtual IList<LaneSet> LaneSets { get; } = new List<LaneSet>();

        public Process()
        {
            FlowElements = new FlowElementCollection(this);
            this.processType = ProcessType.None;
            this.isClosed = false;
            this.isExecutable = false;
        }


        public virtual FlowNode InitialNode
        {
            get
            {
                if(initialNode == null)
                {
                    this.initialNode = FlowElements
                        .OfType<StartEvent>().FirstOrDefault(x => x.EventDefinitions.Count == 0
                                                                  && x.EventDefinitionRefs.Count == 0);
                }

                return initialNode;
            }
        }


      

    
        #region Properties

        public virtual ProcessType ProcessType { get; set; }

        public virtual bool IsClosed { get; set; }

        public virtual bool IsExecutable { get; set; }

        #endregion
    }
}
