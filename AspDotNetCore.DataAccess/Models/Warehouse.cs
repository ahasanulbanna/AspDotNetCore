using System;
using System.Collections.Generic;

#nullable disable

namespace AspDotNetCore.DataAccess.Models
{
    public partial class Warehouse
    {
        public Warehouse()
        {
            ProductWarehouseInventories = new HashSet<ProductWarehouseInventory>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string AdminComment { get; set; }
        public int AddressId { get; set; }

        public virtual ICollection<ProductWarehouseInventory> ProductWarehouseInventories { get; set; }
    }
}
