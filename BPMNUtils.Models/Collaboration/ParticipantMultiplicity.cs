namespace BPMNUtils.Models.Collaboration
{
    public class ParticipantMultiplicity
    {

        public virtual int Minimum { get; set; } = 0;

        public virtual int Maximum { get; set; } = 1;
    }
}