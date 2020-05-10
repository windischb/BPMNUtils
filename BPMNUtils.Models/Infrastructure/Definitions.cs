using System;
using System.Collections.Generic;
using System.Linq;
using BPMNUtils.Models.DI;
using BPMNUtils.Models.Foundation;

namespace BPMNUtils.Models.Infrastructure
{

    public class Definitions
    {
        //public const string DefaultExpressionLanguage = "http://www.w3.org/1999/XPath";
        //public const string DefaultTypeLanguage = "http://www.w3.org/2001/XMLSchema";

        //public const string BPMN20_NS = "http://www.omg.org/spec/BPMN/20100524/MODEL";
        //public const string BPMTK_NS = "http://www.bpmtk.org/bpmn/extensions";

        private IDictionary<string, RootElement> rootElementById;

        public virtual IList<RootElement> RootElements { get; protected set; } = new List<RootElement>();

        public virtual IList<Import> Imports { get; protected set; } = new List<Import>();

        public virtual IList<BPMNDiagram> Diagrams { get; protected set; } = new List<BPMNDiagram>();

        public virtual string Id { get; set; }

        public virtual string Name { get; set; }

        public virtual string TargetNamespace { get; set; }

        public virtual string ExpressionLanguage { get; set; }

        public virtual string TypeLanguage { get; set; }

        public virtual string Exporter { get; set; }

        public virtual string ExporterVersion { get; set; }

        public virtual RootElement GetRootElementById(string id)
        {
            if (id == null)
                throw new ArgumentNullException(nameof(id));

            if (this.rootElementById == null)
                this.rootElementById = this.RootElements.ToDictionary(x => x.Id);

            this.rootElementById.TryGetValue(id, out var element);

            return element;
        }

        public virtual TRootElement GetRootElementById<TRootElement>(string id)
            where TRootElement : RootElement
        {
            var element = this.GetRootElementById(id);

            return (TRootElement) element;
        }

        public virtual Process.Process FindProcessById(string id)
        {
            return this.RootElements.OfType<Process.Process>().SingleOrDefault(x => x.Id == id);
        }
    }
}
