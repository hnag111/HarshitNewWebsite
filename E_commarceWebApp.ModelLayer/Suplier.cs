using System;
using System.Collections.Generic;

namespace E_commarceWebApp.ModelLayer
{
    public partial class Suplier
    {
        public Suplier()
        {
            Product = new HashSet<Product>();
        }

        public int SuplierId { get; set; }
        public string Name { get; set; }
        public string Lastname { get; set; }
        public string Title { get; set; }

        public virtual ICollection<Product> Product { get; set; }
    }
}
