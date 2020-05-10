using System;

namespace BPMNUtils.Types
{
    public class StringTypeHandler : ITypeHandler
    {
        public virtual string Name { get; }

        public virtual Type ClrType { get; }


        public StringTypeHandler()
        {
            Name = "string";
            ClrType = typeof(string);
        }
        
        public virtual object Parse(string[] array, bool isCollection = false)
        {
            if (array == null || array.Length == 0)
                return null;

            if (!isCollection)
                return array[0];

            return array;
        }
    }
}
