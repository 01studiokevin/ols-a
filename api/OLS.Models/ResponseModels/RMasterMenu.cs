using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OLS.Models.ResponseModels
{
    public class RMasterMenu
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Action { get; set; }

        public int Pid { get; set; }

        public string IsLeaf { get; set; }

        public string Status { get; set; }

        public int Seq { get; set; }

        public string Path { get; set; }

        public string Describe { get; set; }

        public List<RMasterMenu> SubMenu { get; set; }
    }
}
