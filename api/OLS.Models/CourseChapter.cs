using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OLS.Models
{
    public class CourseChapter
    {
        [Key]
        public int Id { get; set; }

        [Required,MaxLength(150)]
        public string Title { get; set; }

        [Required]
        public int CourseDetailId { get; set; }

        [ForeignKey("CourseDetailId")]
        public  CourseDetail CourseDetail { get; set; }

        [Required,MaxLength(150)]
        public string Description { get; set; }
    }
}
