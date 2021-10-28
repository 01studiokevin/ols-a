using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OLS.Models
{
    public class CourseDetail
    {
        [Key]
        public int Id { get; set; }
        
        [Required]
        public int CourseId { get; set; }

        [ForeignKey("CourseId")]
        public Course  Course{ get; set; }

        [Required, MaxLength(50)]
        public string Period { get; set; }//每周学时

        [Required, MaxLength(500)]
        public string Summarize { get; set; }

        [Required, MaxLength(50)]
        public string Description { get; set; }

        [Required, MaxLength(500)]
        public string Prepare { get; set; }

        [Required, MaxLength(250)]
        public string Target { get; set; }

        [Required]
        public string Reference { get; set; } //参考资料字段

    }
}
