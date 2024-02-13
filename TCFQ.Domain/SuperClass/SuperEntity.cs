using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TCFQ.Domain.SuperClass
{
    public class SuperEntity
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        [Column(TypeName = "BIGINT")]
        public int Id { get; set; }
    }
}
