using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OLS.Models
{
    public  class PointType
    {
        [Key]
        public int Id { get; set; }

        [Required,MaxLength(50)]
        public string TypeName { get; set; }

        [Required,MaxLength(50)]
        public string  Describe { get; set; }
    }
}
