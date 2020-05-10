using System;

namespace BPMNUtils.Types
{
    public class ComplexTypeHandler : ITypeHandler
    {
        public string Name { get; }
        public Type ClrType => null;


        public ComplexTypeHandler(string typeName)
        {
            Name = typeName;
        }

        public object Parse(string[] values, bool isCollection = false)
        {
            throw new NotImplementedException();
        }
    }
}
