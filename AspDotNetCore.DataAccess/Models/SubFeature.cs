using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AspDotNetCore.DataAccess.Models
{
    public class SubFeature
    {
        public int SubFeatureId { get; set; }
        public string SubFeatureName { get; set; }
        public int FeatureId { get; set; }
        public Feature Feature { get; set; }
    }
}
