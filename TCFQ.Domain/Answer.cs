using TCFQ.Domain.SuperClass;

namespace TCFQ.Domain
{
    public class Answer : SuperEntity
    {
        public ushort QuestionId { get; set; } 
        public char UserAnswer { get; set; }
        public virtual Result Result { get; set; }  = default!;
    }
}
