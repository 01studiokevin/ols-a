using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OLS.Models
{
    public class SectionPoint
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public int SectionId { get; set; }

        [ForeignKey("SectionId")]
        public ChapterSection ChapterSection { get; set; }

        [Required, MaxLength(500)]
        public string PointUrl { get; set; }

        [Required]
        public string typeId { get; set; }

        [ForeignKey("TypeId")]
        public PointType PointType { get; set; }

    }
}
