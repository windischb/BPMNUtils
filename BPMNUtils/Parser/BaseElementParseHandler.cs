﻿using System.Linq;
using System.Xml.Linq;
using BPMNUtils.Models.Extensions;
using BPMNUtils.Models.Foundation;

namespace BPMNUtils.Parser
{
    public abstract class BaseElementParseHandler : ParseHandler
    {
        protected BaseElementParseHandler()
        {
            this.handlers.Add("documentation", new ParseHandlerAction<BaseElement>((p, c, x) => {
                this.ParseDocumentation(p, c, x);
            }));

            this.handlers.Add("extensionElements", new ParseHandlerAction<BaseElement>((p, c, x) => {

                //extended attribute.
                var items = x.GetExtendedElements("attribute");
                foreach(var item in items)
                {
                    var attrName = item.Attribute("name").Value;

                    p.Attributes.Add(new ExtendedAttribute() { Name = attrName, Value = item.Value });
                }

                if (p is IScriptEnabledElement)
                {
                    items = x.GetExtendedElements("script");
                    if (items.Any())
                    {
                        var owner = p as IScriptEnabledElement;
                        foreach (var item in items)
                        {
                            var script = new Script();
                            script.ScriptFormat = item.Attribute("scriptFormat").Value;
                            script.On = item.GetAttribute("on");
                            script.Text = item.Value;

                            owner.Scripts.Add(script);
                        }
                    }
                }

                this.ParseExtensionElements(p, c, x);
            }));
        }

        protected virtual void Init(BaseElement baseElement,
            IParseContext context, XElement element)
        {
            baseElement.Id = element.GetAttribute("id");

            if (element.HasElements)
                this.CreateChildren(baseElement, context, element);
        }

        protected virtual Documentation ParseDocumentation(BaseElement parent, IParseContext context,
            XElement element)
        {
            var documentation = context.BpmnFactory.CreateDocumentation();

            documentation.Text = element.Value;
            documentation.Id = element.GetAttribute("id");
            documentation.TextFormat = element.GetAttribute("textFormat");

            parent.Documentations.Add(documentation);

            return documentation;
        }

        protected virtual ExtensionElements ParseExtensionElements(BaseElement parent,
            IParseContext context, XElement element)
        {
            return null;
        }
    }

    public abstract class BaseElementParseHandler<TParent> : ParseHandler<TParent>
    {
        protected BaseElementParseHandler()
        {
            this.handlers.Add("documentation", new ParseHandlerAction<BaseElement>((p, c, x) => {
                this.ParseDocumentation(p, c, x);
            }));

            this.handlers.Add("extensionElements", new ParseHandlerAction<BaseElement>((p, c, x) => {
                var items = x.GetExtendedElements("attribute");
                foreach (var item in items)
                {
                    var attrName = item.Attribute("name").Value;

                    p.Attributes.Add(new ExtendedAttribute() { Name = attrName, Value = item.Value });
                }

                if (p is IScriptEnabledElement)
                {
                    items = x.GetExtendedElements("script");
                    if (items.Any())
                    {
                        var owner = p as IScriptEnabledElement;
                        foreach (var item in items)
                        {
                            var script = new Script();
                            script.ScriptFormat = item.GetAttribute("scriptFormat");
                            script.On = item.GetAttribute("on");
                            script.Text = item.Value;

                            owner.Scripts.Add(script);
                        }
                    }
                }

                this.ParseExtensionElements(p, c, x);
            }));
        }

        protected virtual void Init(BaseElement baseElement,
            IParseContext context, XElement element)
        {
            baseElement.Id = element.GetAttribute("id");

            if (element.HasElements)
                this.CreateChildren(baseElement, context, element);
        }

        protected virtual Documentation ParseDocumentation(BaseElement parent, IParseContext context,
            XElement element)
        {
            var documentation = context.BpmnFactory.CreateDocumentation();

            documentation.Text = element.Value;
            documentation.Id = element.GetAttribute("id");
            documentation.TextFormat = element.GetAttribute("textFormat");

            parent.Documentations.Add(documentation);

            return documentation;
        }

        protected virtual ExtensionElements ParseExtensionElements(BaseElement parent,
            IParseContext context, XElement element)
        {
            return null;
        }
    }
}
