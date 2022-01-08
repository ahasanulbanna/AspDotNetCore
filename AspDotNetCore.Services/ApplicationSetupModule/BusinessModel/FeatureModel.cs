using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AspDotNetCore.Services.ApplicationSetupModule.BusinessModel
{
    public class FeatureModel
    {
        public int FeatureId { get; set; }
        public string FeatureName { get; set; }
        public int ModuleId { get; set; }
        public virtual ModuleModel Module { get; set; }
    }
}
