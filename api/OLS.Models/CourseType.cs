using System.ComponentModel.DataAnnotations;

namespace OLS.Models
{
    public class CourseType
    {
        [Key]
        public int Id { get; set; }

        [Required, MaxLength(50)]
        public string CourseName { get; set; }

        [Required, MaxLength(50)]
        public string CourseValue { get; set; }
    }
}