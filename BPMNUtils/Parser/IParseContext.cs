﻿using System;
using BPMNUtils.Models.Common;
using BPMNUtils.Models.Foundation;
using BPMNUtils.Models.Process;

namespace BPMNUtils.Parser
{
    public interface IParseContext
    {
        BpmnFactory BpmnFactory { get; }

        void AddReferenceRequest<TBaseElement>(string id, Action<TBaseElement> action)
            where TBaseElement : IBaseElement;

        void Push(FlowElement flowElement);

        void Push(BaseElement baseElement);

        void AddSourceRef(string sourceRef, SequenceFlow sequenceFlow);

        void AddTargetRef(string targetRef, SequenceFlow sequenceFlow);

        void AddFlowNode(FlowNode flowNode);
    }
}
