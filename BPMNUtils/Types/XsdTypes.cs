using System.Collections.Generic;

namespace BPMNUtils.Types
{
    public class XsdTypes : BpmnTypes
    {
        private static XsdTypes instance;

        static XsdTypes()
        {
            instance = new XsdTypes();
        }

        public static XsdTypes Instance => instance;

        private Dictionary<string, ITypeHandler> mappings = new Dictionary<string, ITypeHandler>();

        public XsdTypes()
        {
            mappings.Add("xsd:string", new StringTypeHandler());
            mappings.Add("xsd:datetime", new DateTypeHandler());
        }

        public override ITypeHandler Get(string typeName)
        {
            ITypeHandler type = null;
            if (this.mappings.TryGetValue(typeName, out type))
                return type;

            return null;
        }
    }
}
