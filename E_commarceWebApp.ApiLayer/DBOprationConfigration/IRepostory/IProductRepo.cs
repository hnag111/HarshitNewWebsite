using E_commarceWebApp.ApiLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace E_commarceWebApp.ApiLayer.DBOprationConfigration.IRepostory
{
    public interface IProductRepo
    {
        Task<Product> CreateProduct(Product product);
        Task<IEnumerable<Product>> GetAllProduct();
        Task<Product> GetProductById(int ProId);
        Task<int> DeleteProduct(int ProId);
        Task<Product> UpdateProduct(Product product);

    }
}
