using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OLS.Models
{
    public class CourseGroup
    {
        [Key]
        public int Id { get; set; }

        [Required, MaxLength(50)]
        public string CourseGroupName { get; set; }

        [Required, MaxLength(50)]
        public string CourseGroupValue { get; set; }

        [Required, MaxLength(50)]
        public string CourseGroupRouter { get; set; }

        [Required, MaxLength(200)]
        public string Describe { get; set; }

    }
}