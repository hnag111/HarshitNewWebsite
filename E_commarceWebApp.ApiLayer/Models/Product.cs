using System;
using System.Collections.Generic;

namespace E_commarceWebApp.ApiLayer.Models
{
    public partial class Product
    {
        public int ProductId { get; set; }
        public string Name { get; set; }
        public int InventoryId { get; set; }
        public DateTime AdditionDate { get; set; }
        public string IsAvailable { get; set; }
        public string FileName { get; set; }
        public string FileExtension { get; set; }
        public int CategoryId { get; set; }
        public string ProductDiscription { get; set; }
        public int SupplierId { get; set; }
        public decimal UnitPrice { get; set; }

        public virtual Category Category { get; set; }
        public virtual Inventory Inventory { get; set; }
        public virtual Suplier Supplier { get; set; }
    }
}
