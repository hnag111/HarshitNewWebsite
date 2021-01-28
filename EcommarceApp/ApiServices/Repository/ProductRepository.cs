using E_commarceWebApp.ModelLayer;
using EcommarceAppEndUserLayer.ApiServices.IRepository;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace EcommarceAppEndUserLayer.ApiServices.Repository
{
    public class ProductRepository : IProductApiRepository
    {

        private readonly HttpClient client;
        public readonly string BaseUri = "https://localhost:44302/";
        public ProductRepository(HttpClient client)
        {
            this.client = client;
        }
        public async Task<List<Product>> GetAllProduct()
        {
            List<Product> ProductList = new List<Product>();
            using (var httpclient = new HttpClient())
            {
                using (var response = await httpclient.GetAsync(BaseUri + "api/Values/GetAllProdcutsApi"))
                {
                    var APIRes = await response.Content.ReadAsStringAsync();

                    ProductList = JsonConvert.DeserializeObject<List<Product>>(APIRes);

                }
            }
            return ProductList;
        }
    }
}
