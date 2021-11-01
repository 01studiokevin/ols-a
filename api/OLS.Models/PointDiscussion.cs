using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OLS.Models
{
    public class PointDiscussion
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public int SectionPointId { get; set; }

        [ForeignKey("SectinPointId")]
        public SectionPoint SectionPoint { get; set; }
    }
}
