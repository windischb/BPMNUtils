using System;
using System.IO;
using System.Linq;
using BPMNUtils.Models.Process;
using BPMNUtils.Models.Process.Activities;
using BPMNUtils.Models.Process.Events;
using BPMNUtils.Parser;
using Xunit;

namespace BPMNUtils.Tests
{
    public class ParserTests
    {
        [Theory]
        [InlineData("A.1.0.bpmn")]
        [InlineData("A.2.0.bpmn")]
        [InlineData("A.2.1.bpmn")]
        [InlineData("A.3.0.bpmn")]
        [InlineData("A.4.0.bpmn")]
        [InlineData("A.4.1.bpmn")]
        [InlineData("B.1.0.bpmn")]
        [InlineData("B.2.0.bpmn")]
        [InlineData("C.1.0.bpmn")]
        [InlineData("C.1.1.bpmn")]
        [InlineData("C.2.0.bpmn")]
        [InlineData("C.3.0.bpmn")]
        [InlineData("C.4.0.bpmn")]
        [InlineData("C.5.0.bpmn")]
        [InlineData("C.6.0.bpmn")]
        public void Parse(string filename)
        {
            
                var fileStream = File.OpenRead($"BPMNFiles\\{filename}");
                var parser = BpmnParser.Create();
                var result = parser.Parse(fileStream, true);

        }

        [Fact]
        public void Reference_A_1_0()
        {
            var fileStream = File.OpenRead($"BPMNFiles\\A.1.0.bpmn");
            var parser = BpmnParser.Create();
            var result = parser.Parse(fileStream);


            var tasks = result.FlowElements.Values.Where(el => el is Task);
            var sequenceFlows = result.FlowElements.Values.Where(el => el is SequenceFlow);
            Assert.Contains(result.FlowElements, pair => pair.Value is StartEvent);
            Assert.Contains(result.FlowElements, pair => pair.Value is EndEvent);
            Assert.True(tasks.Count() == 3);
            Assert.True(sequenceFlows.Count() == 4);
            
        }

        [Fact]
        public void Reference_C_5_0()
        {
            var fileStream = File.OpenRead($"BPMNFiles\\C.5.0.bpmn");
            var model = BpmnModel.FromStream(fileStream, true);




        }
    }
}
