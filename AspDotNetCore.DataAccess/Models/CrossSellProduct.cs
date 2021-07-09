using System;
using System.Collections.Generic;

#nullable disable

namespace AspDotNetCore.DataAccess.Models
{
    public partial class CrossSellProduct
    {
        public int Id { get; set; }
        public int ProductId1 { get; set; }
        public int ProductId2 { get; set; }
    }
}
