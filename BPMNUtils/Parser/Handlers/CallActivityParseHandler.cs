using System.Xml.Linq;
using BPMNUtils.Models.Common;

namespace BPMNUtils.Parser.Handlers
{
    class CallActivityParseHandler : ActivityParseHandler
    {
        public override object Create(IFlowElementsContainer parent, IParseContext context, XElement element)
        {
            var callActivity = context.BpmnFactory.CreateCallActivity();
            parent.FlowElements.Add(callActivity);

            var calledElement = element.GetAttribute("calledElement");
            callActivity.CalledElement = calledElement;

            base.Init(callActivity, context, element);

            return callActivity;
        }
    }
}
