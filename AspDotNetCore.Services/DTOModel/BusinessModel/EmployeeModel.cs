using System.ComponentModel.DataAnnotations;

namespace AspDotNetCore.Services.DTOModel.BusinessModel
{
    public class EmployeeModel
    {
        public int EmployeeId { get; set; }
        public string Name { get; set; }
        [Required]
        [StringLength(10)]
        public string Designation { get; set; }
        public virtual EmployeeDetailsModel EmployeeDetails { get; set; }
    }
}
