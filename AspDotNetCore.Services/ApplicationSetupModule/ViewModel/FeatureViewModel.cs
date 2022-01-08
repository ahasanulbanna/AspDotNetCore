using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AspDotNetCore.Services.ApplicationSetupModule.ViewModel
{
    public class FeatureViewModel
    {
        public FeatureViewModel()
        {
            SubFeatures = new List<SubFeatureViewModel>();
        }
        public int FeatureId { get; set; }
        public string FeatureName { get; set; }
        public int ModuleId { get; set; }
        public List<SubFeatureViewModel> SubFeatures { get; set; }

    }
}
