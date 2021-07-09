using System;
using System.Collections.Generic;

#nullable disable

namespace AspDotNetCore.DataAccess.Models
{
    public partial class CategoryTemplate
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ViewPath { get; set; }
        public int DisplayOrder { get; set; }
    }
}
