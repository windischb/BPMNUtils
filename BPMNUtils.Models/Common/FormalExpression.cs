namespace BPMNUtils.Models.Common
{
    public class FormalExpression : Expression
    {
        public virtual string Language { get; set; }

        public virtual string EvaluatesToTypeRef { get; set; }
    }
}