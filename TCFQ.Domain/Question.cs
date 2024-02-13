using TCFQ.Domain.SuperClass;

namespace TCFQ.Domain
{
    public class Question : SuperEntity
    {
        public byte[] Description { get; set; } = default!;
        public char Answer { get; set; } = default!;
    }
}
