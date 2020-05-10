using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Schema;
using BPMNUtils.Models.Infrastructure;

namespace BPMNUtils.Parser
{
    public class BpmnParser
    {

        protected BpmnFactory factory = new BpmnFactory();
        protected Definitions definitions;

        protected readonly XmlReaderSettings settings;
        private const string schemaLocation = "BPMNUtils.Schema";
        private static readonly string[] schemaNames = new string[]
            {
                "BPMN20.xsd", "BPMNDI.xsd", "DI.xsd", "DC.xsd", "Semantic.xsd", "Extensions.xsd"
            };
        
        private static Lazy<XmlSchemaSet> LazyXmlSchemaSet = new Lazy<XmlSchemaSet>(() =>
        {
            var assembly = typeof(BpmnParser).Assembly;
            var names = assembly.GetManifestResourceNames();
            XmlSchemaSet schemaSet = new XmlSchemaSet();
            foreach (var name in schemaNames)
            {
                var resourceKey = $"{schemaLocation}.{name}";
                using (var stream = assembly.GetManifestResourceStream(resourceKey))
                {
                    var schema = XmlSchema.Read(stream, null);
                    schemaSet.Add(schema);
                }
            }

            return schemaSet;
        });

        protected static XmlSchemaSet XmlSchemaSet = LazyXmlSchemaSet.Value;

        static BpmnParser()
        {
            
        }

        protected BpmnParser()
        {
            settings = new XmlReaderSettings();
            settings.IgnoreComments = true;
            settings.IgnoreWhitespace = true;
            settings.ValidationType = ValidationType.Schema;
            settings.ValidationFlags |= XmlSchemaValidationFlags.ProcessInlineSchema;
            //_settings.ValidationFlags |= XmlSchemaValidationFlags.ProcessSchemaLocation;
            //settings.ValidationFlags |= XmlSchemaValidationFlags.ReportValidationWarnings;
            settings.ValidationEventHandler += OnValidationEventHandler;

            settings.Schemas.Add(XmlSchemaSet);
        }

        private List<Exception> exceptions = new List<Exception>();

        protected virtual void OnValidationEventHandler(object sender, ValidationEventArgs e)
        {
            this.exceptions.Add(e.Exception);
        }

        public static BpmnParser Create()
        {
            return new BpmnParser();
        }

        public virtual BpmnParserResults Parse(Stream stream, bool disableValidation = false)
        {
            this.exceptions.Clear();

            if (disableValidation)
            {
                settings.ValidationFlags &= ~XmlSchemaValidationFlags.ReportValidationWarnings;
            }
            else
            {
                settings.ValidationFlags |= XmlSchemaValidationFlags.ReportValidationWarnings;
            }


            XDocument document = null;
            using (var reader = XmlReader.Create(stream, settings))
            {
                document = XDocument.Load(reader);
            }

            if (this.exceptions.Count > 0)
            {
                var message = this.GetErrorDetails();
                throw new Exception("The BPMN model parse error: \n" + message);
            }

            var element = document.Root;

            var handler = new DefinitionsParseHandler();

            var context = new BpmnParseContext(definitions, this.factory);

            this.definitions = handler.Create(null, context, element) as Definitions;

            context.Complete();

            var flowElements = context.FlowElements;
            return new BpmnParserResults(definitions, flowElements, this.exceptions);
        }

        protected virtual string GetErrorDetails()
        {
            var sb = new StringBuilder();

            foreach(var ex in this.exceptions)
            {
                sb.AppendLine(ex.Message);
            }

            return sb.ToString();
        }
    }
}
