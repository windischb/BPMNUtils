namespace BPMNUtils.Models.Common
{
    public class TimerEventDefinition : EventDefinition
    {
        public virtual Expression TimeDate { get; set; }

        public virtual Expression TimeDuration { get; set; }

        public virtual Expression TimeCycle { get; set; }
    }
}