﻿using System;
using System.Collections.Generic;

#nullable disable

namespace DataLayer.Models
{
    public partial class VendorNote
    {
        public int Id { get; set; }
        public string Note { get; set; }
        public int VendorId { get; set; }
        public DateTime CreatedOnUtc { get; set; }

        public virtual Vendor Vendor { get; set; }
    }
}