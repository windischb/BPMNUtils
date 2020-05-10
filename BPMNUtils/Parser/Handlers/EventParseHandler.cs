﻿using System.Xml.Linq;
using BPMNUtils.Models.Common;
using BPMNUtils.Models.Foundation;

namespace BPMNUtils.Parser.Handlers
{
    abstract class EventParseHandler : FlowNodeParseHandler
    {
        public EventParseHandler()
        {
            this.handlers.Add("property", new PropertyParseHandler<Event>((evnt, props) =>
            {
                evnt.Properties.Add(props);
            }));
        }
    }

    abstract class CatchEventParseHandler : EventParseHandler
    {
        public CatchEventParseHandler()
        {
            var keys = EventDefinitionParseHandler.Keys;
            IParseHandler handler = new EventDefinitionParseHandler((parent, context, element, result) =>
            {
                ((CatchEvent)parent).EventDefinitions.Add(result);
            });

            foreach (var key in keys)
                this.handlers.Add(key, handler);

            this.handlers.Add("dataOutput", new DataOutputParseHandler<CatchEvent>(
                (target, context, element, result) =>
                {
                    target.DataOutputs.Add(result);
                }));

            this.handlers.Add("dataOutputAssociation", new DataOutputAssociationParseHandler<CatchEvent>((x, y) =>
            {
                x.DataOutputAssociations.Add(y);
            }));

            this.handlers.Add("eventDefinitionRef", new ParseHandlerAction<CatchEvent>((p, c, x) =>
            {
                var eventDefinitionRef = x.Value;
                if(eventDefinitionRef != null)
                    c.AddReferenceRequest<EventDefinition>(eventDefinitionRef,(d) => p.EventDefinitionRefs.Add(d));
            }));
        }

        protected override void Init(BaseElement baseElement, IParseContext context, XElement element)
        {
            var catchEvent = baseElement as CatchEvent;
            catchEvent.ParallelMultiple = element.GetBoolean("parallelMultiple");

            base.Init(catchEvent, context, element);
        }
    }

    abstract class ThrowEventParseHandler : EventParseHandler
    {
        public ThrowEventParseHandler()
        {
            this.handlers.Add("dataInput", new DataInputParseHandler<ThrowEvent>(
                (target, context, element, result) =>
                {
                    target.DataInputs.Add(result);
                }));

            this.handlers.Add("dataInputAssociation", new DataInputAssociationParseHandler<ThrowEvent>((x, y) =>
            {
                x.DataInputAssociations.Add(y);
            }));

            var keys = EventDefinitionParseHandler.Keys;
            IParseHandler handler = new EventDefinitionParseHandler((parent, context, element, result) =>
            {
                ((ThrowEvent)parent).EventDefinitions.Add(result);
            });

            foreach (var key in keys)
                this.handlers.Add(key, handler);

            this.handlers.Add("eventDefinitionRef", new ParseHandlerAction<ThrowEvent>((p, c, x) =>
            {
                var eventDefinitionRef = x.Value;
                if (eventDefinitionRef != null)
                    c.AddReferenceRequest<EventDefinition>(eventDefinitionRef, (d) => p.EventDefinitionRefs.Add(d));
            }));
        }
    }

    class StartEventParseHandler : CatchEventParseHandler
    {
        public override object Create(IFlowElementsContainer parent, IParseContext context, XElement element)
        {
            var startEvent = context.BpmnFactory.CreateStartEvent();
            parent.FlowElements.Add(startEvent);

            startEvent.IsInterrupting = element.GetBoolean("isInterrupting");

            base.Init(startEvent, context, element);

            return startEvent;
        }
    }

    class EndEventParseHandler : ThrowEventParseHandler
    {
        public override object Create(IFlowElementsContainer parent, IParseContext context, XElement element)
        {
            var endEvent = context.BpmnFactory.CreateEndEvent();
            parent.FlowElements.Add(endEvent);

            base.Init(endEvent, context, element);

            return endEvent;
        }
    }
}
