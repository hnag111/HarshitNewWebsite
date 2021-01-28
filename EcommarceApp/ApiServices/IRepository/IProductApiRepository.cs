using E_commarceWebApp.ModelLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EcommarceAppEndUserLayer.ApiServices.IRepository
{
    public interface  IProductApiRepository
    {
        public  Task<List<Product>> GetAllProduct();
        
    }
}
