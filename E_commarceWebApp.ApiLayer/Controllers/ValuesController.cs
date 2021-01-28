using E_commarceWebApp.ApiLayer.DBOprationConfigration.IRepostory;
using E_commarceWebApp.ApiLayer.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace E_commarceWebApp.ApiLayer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private readonly IProductRepo productRepo;

        public ValuesController(IProductRepo productRepo)
        {
            this.productRepo = productRepo;
        }


        [HttpGet]
        [Route("GetAllProdcutsApi")]
        public async Task<ActionResult> GetAllProdcutsApi()
        {
            try
            {
                var result = await productRepo.GetAllProduct();
                return Ok(result);
            }
            catch (Exception)
            {

                throw;
            }

        }
        [HttpGet]
        [Route("GetProductById")]
        public async Task<ActionResult> GetProductById(int Id)
        {
            var result = await productRepo.GetProductById(Id);
            return Ok(result);

        }
        [HttpPost]
        [Route("CreateProductApi")]
        public async Task<ActionResult> CreateProductApi(Product product)
        {
            try
            {
                var result = await productRepo.CreateProduct(product);
                return Ok(result);
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Internal Error Found During Creating Product");

                throw;
            }

        }
        [HttpPut]
        [Route("UpdateProductApi")]
        public async Task<ActionResult> UpdateProductApi(Product product)
        {

            try
            {
                var result = await productRepo.UpdateProduct(product);
                return Ok(result);
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Internal Error Found During Creating Product");


                throw;
            }
        }
        [HttpDelete]
        [Route("DeleteProductApi")]
        public async Task<ActionResult> DeleteProductApi(int ProId)
        {

            try
            {
                var result = await productRepo.DeleteProduct(ProId);
                return Ok(result);
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Internal Error occured While Updating The Product Record");
                throw;
            }
        }
    }
}
