using System.Xml.Linq;
using BPMNUtils.Models.Foundation;

namespace BPMNUtils.Parser.Handlers
{
    class ExtensionElementsParseHandler : ParseHandler<BaseElement>
    {
        public override object Create(BaseElement parent, IParseContext context, XElement element)
        {
            var extensionElements = context.BpmnFactory.CreateExtensionElements();
            parent.ExtensionElements = extensionElements;

            return extensionElements;
        }
    }
}
