using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OLS.Models
{
    public class MasterMenu
    {
        [Key]
        public int Id { get; set; }

        [Required,MaxLength(50)]
        public string Name { get; set; }

        [Required,MaxLength(50)]
        public string Action { get; set; }

        public int Pid { get; set; }

        [Required,MaxLength(1)]
        public string Status { get; set; }

        [Required]
        public int Seq { get; set; }

        [Required,MaxLength(50)]
        public string Path { get; set; }

        [Required,MaxLength(100)]
        public string Describe { get; set; }

    }
}
