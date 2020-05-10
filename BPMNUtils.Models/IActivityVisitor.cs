using BPMNUtils.Models.Process.Activities;

namespace BPMNUtils.Models
{
    public interface IActivityVisitor
    {
        void Visit(AdHocSubProcess adHocSubProcess);

        void Visit(SubProcess subProcess);

        void Visit(Transaction transaction);

        void Visit(CallActivity value);

        #region Tasks

        void Visit(UserTask userTask);

        void Visit(ManualTask value);

        void Visit(Task value);

        void Visit(ReceiveTask value);

        void Visit(SendTask value);

        void Visit(ScriptTask scriptTask);

        void Visit(ServiceTask value);

        void Visit(BusinessRuleTask value);

        #endregion
    }
}