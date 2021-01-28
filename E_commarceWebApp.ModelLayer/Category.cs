using System;
using System.Collections.Generic;

namespace E_commarceWebApp.ModelLayer
{
    public partial class Category
    {
        public Category()
        {
            Product = new HashSet<Product>();
        }

        public int CategoryId { get; set; }
        public string Name { get; set; }
        public string CategoryDiscription { get; set; }

        public virtual ICollection<Product> Product { get; set; }
    }
}
