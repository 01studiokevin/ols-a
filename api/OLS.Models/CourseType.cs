using System.ComponentModel.DataAnnotations;

namespace OLS.Models
{
    public class CourseType
    {
        [Key]
        public int Id { get; set; }

        [Required, MaxLength(50)]
        public string TypeName { get; set; }

        [Required, MaxLength(50)]
        public string TypeValue { get; set; }

        [Required]
        public int GroupTypeId { get; set; }

        public CourseGroup CourseGroup { get; set; }


        [Required, MaxLength(200)]
        public string TypeDescribe { get; set; }
    }
}