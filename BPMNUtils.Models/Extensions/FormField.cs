using System.Collections.Generic;

namespace BPMNUtils.Models.Extensions
{
    public class FormField
    {
        

        public string Id { get; protected set; }

        public string Name { get; protected set; }

        public string Type { get; protected set; }

        public bool Readable { get; protected set; }

        public bool Required { get; protected set; }

        public bool Writable { get; protected set; }

        public string Variable { get; protected set; }

        public string Format { get; protected set; }

        public string Pattern { get; protected set; }

        public string Value { get; protected set; }

        protected readonly List<KeyValuePair<string, string>> values = new List<KeyValuePair<string, string>>();
        public virtual IReadOnlyCollection<KeyValuePair<string, string>> Values => this.values.AsReadOnly();
    }
}
