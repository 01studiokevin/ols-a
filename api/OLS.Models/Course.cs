using System.ComponentModel.DataAnnotations;

namespace OLS.Models
{
    public class Course
    {
        [Key]
        public int Id { get; set; }

        [Required, MaxLength(50)]
        public string CourseName { get; set; }

        [Required, MaxLength(30)]
        public string StartTime { get; set; }

        [Required, MaxLength(30)]
        public string EndTime { get; set; }

        [Required]
        public int JoinCount { get; set; }

        [Required, MaxLength(30)]
        public string CourseStatus { get; set; }

       [Required,MaxLength(100)]
        public string  PeriodCount { get; set; }//?????
    }
}