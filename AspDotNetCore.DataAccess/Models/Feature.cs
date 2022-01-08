using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AspDotNetCore.DataAccess.Models
{
    public class Feature
    {
        public Feature()
        {
            SubFeatures = new HashSet<SubFeature>();
        }
        public int FeatureId { get; set; }
        public string FeatureName { get; set; }
        public int ModuleId { get; set; }
        public virtual Module Module { get; set; }
        public virtual ICollection<SubFeature> SubFeatures { get; set; }
        
    }
}
