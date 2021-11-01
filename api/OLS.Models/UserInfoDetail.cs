using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OLS.Models
{
    public class UserInfoDetail
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public int UserId { get; set; }

        [ForeignKey("UserId")]
        public UserInfo UserInfo{  get; set; }

        [Required]
        public int FllowCount { get; set; }

        [Required]
        public int SubscribeCount { get; set; }

        [Required]
        public int ThumbUpCount { get; set; }

        [Required]
        public int leaningTimeCount { get; set; }
    }
}