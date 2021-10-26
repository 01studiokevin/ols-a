using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OLS.Models
{
    public class Role
    {
        [Key]
        public int Id { get; set; }

        [Required,MaxLength(2)]
       public string RoleValue { get; set; }

        [Required,MaxLength(30)]
       public string RoleName { get; set; }

        [Required, MaxLength(30)]
        public string Describe { get; set; }


    }
}
