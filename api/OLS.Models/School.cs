using System.ComponentModel.DataAnnotations;

namespace OLS.Models
{
    public class School
    {
        [Key]
        public int Id { get; set; }

        [Required, MaxLength(10)]
        public string SchoolName { get; set; }

        [Required]
        public string SchoolValue { get; set; }
    }
}