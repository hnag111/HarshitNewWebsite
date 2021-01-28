using EcommarceApp.Models;
using EcommarceAppEndUserLayer.ApiServices.IRepository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace EcommarceApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly IProductApiRepository repository;

        public HomeController(IProductApiRepository repository)
        {
            this.repository = repository;
        }
        public IActionResult Index()
        {

            var result = repository.GetAllProduct();
            return View(result);

        }
    }
}
