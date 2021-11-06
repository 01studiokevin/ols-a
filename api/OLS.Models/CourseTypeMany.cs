using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OLS.Models
{
    /// <summary>
    /// 课程与类型中间表
    /// </summary>
    public class CourseTypeMany
    {
        [Key]
        public int id { get; set; }

        [Required]
        public int TypeId { get; set; }

        [Required]
        public int CourseId { get; set; }

        [ForeignKey("TypeId")]
        public  CourseType CourseType { get; set; }

        [ForeignKey("CourseId")]
        public Course  Course { get; set; }
    }
}
