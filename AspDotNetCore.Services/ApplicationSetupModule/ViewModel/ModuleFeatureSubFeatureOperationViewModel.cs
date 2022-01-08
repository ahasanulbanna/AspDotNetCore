using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AspDotNetCore.DataAccess.Models;

namespace AspDotNetCore.Services.ApplicationSetupModule.ViewModel
{
    public class ModuleFeatureSubFeatureOperationViewModel
    {
        public ModuleFeatureSubFeatureOperationViewModel()
        {
            Features = new List<FeatureViewModel>();
        }
        public int ModuleId { get; set; }
        public string ModuleName { get; set; }
        public List<FeatureViewModel> Features { get; set; } 
    }
}
