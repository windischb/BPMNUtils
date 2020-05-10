using BPMNUtils.Models.Process.Events;
using BPMNUtils.Models.Process.Gateways;

namespace BPMNUtils.Models
{
    public interface IFlowNodeVisitor : IActivityVisitor
    {
        #region Events

        void Visit(StartEvent startEvent);

        void Visit(EndEvent endEvent);

        void Visit(BoundaryEvent boundryEvent);

        void Visit(ImplicitThrowEvent value);

        void Visit(IntermediateCatchEvent value);

        void Visit(IntermediateThrowEvent value); 

        #endregion

        #region Gateways

        void Visit(ExclusiveGateway value);

        void Visit(InclusiveGateway value);

        void Visit(ParallelGateway value);

        void Visit(ComplexGateway value);

        void Visit(EventBasedGateway value);

        #endregion
    }
}
