using System;
using System.Collections.Generic;

namespace E_commarceWebApp.ModelLayer
{
    public partial class Inventory
    {
        public Inventory()
        {
            Product = new HashSet<Product>();
        }

        public int InventoryId { get; set; }
        public long Quantity { get; set; }
        public long AvailableQuantity { get; set; }

        public virtual ICollection<Product> Product { get; set; }
    }
}
