using EcommarceAppEndUserLayer.ApiServices.IRepository;
using EcommarceAppEndUserLayer.ApiServices.Repository;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EcommarceApp.Models
{
    public class ProductControler : Controller
    {
        private readonly IProductApiRepository repository;

        public ProductControler(IProductApiRepository repository)
        {
            this.repository = repository;
        }
        public IActionResult Index()
        {

            var result =  repository.GetAllProduct();
            return View(result);
        }
    }
}
