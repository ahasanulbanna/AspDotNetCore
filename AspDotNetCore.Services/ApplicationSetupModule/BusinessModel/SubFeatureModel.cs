using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AspDotNetCore.Services.ApplicationSetupModule.BusinessModel
{
    public class SubFeatureModel
    {
        public int SubFeatureId { get; set; }
        public string SubFeatureName { get; set; }
        public int FeatureId { get; set; }
    }
}
