using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        [Required]
        public int MyProperty { get; set; }
    }
}
