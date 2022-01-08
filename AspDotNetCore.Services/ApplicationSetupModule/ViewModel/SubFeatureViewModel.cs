using AspDotNetCore.Services.ApplicationSetupModule.BusinessModel;

namespace AspDotNetCore.Services.ApplicationSetupModule.ViewModel
{
    public class SubFeatureViewModel
    {
        public int SubFeatureId { get; set; }
        public string SubFeatureName { get; set; }
        public int FeatureId { get; set; }
        public FeatureModel Feature { get; set; }
    }
}
