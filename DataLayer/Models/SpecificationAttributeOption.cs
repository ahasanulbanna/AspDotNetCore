﻿using System;
using System.Collections.Generic;

#nullable disable

namespace DataLayer.Models
{
    public partial class SpecificationAttributeOption
    {
        public SpecificationAttributeOption()
        {
            ProductSpecificationAttributeMappings = new HashSet<ProductSpecificationAttributeMapping>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string ColorSquaresRgb { get; set; }
        public int SpecificationAttributeId { get; set; }
        public int DisplayOrder { get; set; }

        public virtual SpecificationAttribute SpecificationAttribute { get; set; }
        public virtual ICollection<ProductSpecificationAttributeMapping> ProductSpecificationAttributeMappings { get; set; }
    }
}
