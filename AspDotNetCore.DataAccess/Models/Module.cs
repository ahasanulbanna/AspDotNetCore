using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AspDotNetCore.DataAccess.Models
{
    public class Module
    {
        public Module()
        {
            Features = new HashSet<Feature>();
        }
        public int ModuleId { get; set; }
        public string ModuleName { get; set; }
        public virtual ICollection<Feature> Features { get; set; }
    }
}
