using TCFQ.Domain.SuperClass;

namespace TCFQ.Domain
{
    public class Result : SuperEntity
    {
        public string Name { get; set; } = default!;
        public ushort ExamId { get; set; } = default!;
        public string Level { get; set; } = default!;
        public ushort Points { get; set; } = default!;
        public virtual ICollection<Answer> Answers { get; set; } = default!;
        public DateTime CreateAt { get; set; } = DateTime.UtcNow;
    }
}
