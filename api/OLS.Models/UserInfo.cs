using System.ComponentModel.DataAnnotations;

namespace OLS.Models
{
    public class UserInfo
    {
        [Key]
        public int Id { get; set; }

        [Required, MaxLength(30)]
        public string UserName { get; set; }

        [Required, MaxLength(1)]
        public string Gender { get; set; }

        [Required, MaxLength(50)]
        public string Account { get; set; }

        [Required, MaxLength(20)]
        public string Password { get; set; }

        [MaxLength(15)]
        public string Tel { get; set; }

        [MaxLength(150)]
        public string Profile { get; set; }

        [Required, MaxLength(20)]
        public string LastLogin { get; set; }

        [Required, MaxLength(200)]
        public string Describe { get; set; }

        [Required, MaxLength(1)]
        public string IsActive { get; set; }

    }
}