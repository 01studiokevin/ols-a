using System.ComponentModel.DataAnnotations;

namespace OLS.Models
{
    public class UserInfo
    {
        [Key]
        public int Id { get; set; }

        [Required,MaxLength(20)]
        public string? Name { get; set; }

        [Required,MaxLength(1)]
        public string? Gender { get; set; }

        [Required,MaxLength(20)]
        public string? Account { get; set; }

        [Required, MaxLength(20)]
        public string? Password { get; set; }

        [MaxLength(15)]
        public string? Tel { get; set; }

        [Required,MaxLength(1)]
        public string? IsActive { get; set; }

    }
}