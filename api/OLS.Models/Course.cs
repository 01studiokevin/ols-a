using System.ComponentModel.DataAnnotations;

namespace OLS.Models
{
    public class Course
    {
        [Key]
        public int Id { get; set; }

        [Required, MaxLength(50)]
        public string CourseName { get; set; }

        [Required,MaxLength(30)]
        public string StartTime { get; set; }

        [Required,MaxLength(30)]
        public string EndTime { get; set; }

        [Required, MaxLength(50)]
        public string Describe { get; set; }

    }
}