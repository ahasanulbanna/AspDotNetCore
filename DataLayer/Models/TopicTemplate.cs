using System;
using System.Collections.Generic;

#nullable disable

namespace DataLayer.Models
{
    public partial class TopicTemplate
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ViewPath { get; set; }
        public int DisplayOrder { get; set; }
    }
}
