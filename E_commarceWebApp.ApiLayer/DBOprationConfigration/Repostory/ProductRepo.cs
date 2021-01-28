using E_commarceWebApp.ApiLayer.DBOprationConfigration.IRepostory;
using E_commarceWebApp.ApiLayer.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace E_commarceWebApp.ApiLayer.DBOprationConfigration.Repostory
{
    public class ProductRepo : IProductRepo
    {
        private readonly AttemptCodeContext codeContext;

        public ProductRepo(AttemptCodeContext codeContext)
        {
            this.codeContext = codeContext;
        }



        public async Task<Product> CreateProduct(Product product)
        {
            try
            {

                Inventory inventory = new Inventory()
                {
                    Quantity = product.Inventory.Quantity
                };
                var ResultInverty = await codeContext.Inventory.AddAsync(inventory);
                await codeContext.SaveChangesAsync();

                Product model = new Product
                {
                    InventoryId = ResultInverty.Entity.InventoryId,
                    Name = product.Name,
                    FileName = product.FileName,
                    FileExtension = product.FileExtension,
                    AdditionDate = product.AdditionDate,
                    IsAvailable = product.IsAvailable,
                    CategoryId = product.CategoryId,
                    SupplierId = product.SupplierId,
                    UnitPrice = product.UnitPrice,
                    ProductDiscription = product.ProductDiscription

                };
                var resultProduct = await codeContext.Product.AddAsync(product);
                await codeContext.SaveChangesAsync();
                return  product;


                
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<int> DeleteProduct(int ProId)
        {
            var result = codeContext.Product.Find(ProId);
            if (result != null)
            {
                codeContext.Product.Remove(result);
                await codeContext.SaveChangesAsync();
                return 1;
            }
            return 0;
        }

        public async Task<IEnumerable<Product>> GetAllProduct()
        {
            var result = await codeContext.Product.ToListAsync();
            return result;
        }

        public async Task<Product> GetProductById(int ProId)
        {

            try
            {
                var result = codeContext.Product.FirstOrDefaultAsync(e => e.ProductId == ProId);
                if (result == null)
                {

                    return await result;
                }
                return await result;
            }
            catch (Exception)
            {

                throw;
            }

        }

        public async Task<Product> UpdateProduct(Product product)
        {
            try
            {
                var result = codeContext.Product.Attach(product);
                result.State = EntityState.Modified;
                await codeContext.SaveChangesAsync();
                return product;
            }
            catch (Exception)
            {

                throw;
            }
        }


    }
}
