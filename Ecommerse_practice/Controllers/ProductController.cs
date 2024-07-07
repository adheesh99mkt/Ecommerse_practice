using Ecommerse_practice.Models;
using Ecommerse_practice.Services;
using Microsoft.AspNetCore.Mvc;

namespace Ecommerse_practice.Controllers
{
    public class ProductController : Controller
    {
        private IProductService productService;

        public ProductController(IProductService productService)
        {
            this.productService = productService;

        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult GetAllProduct()
        {
            List<Products> product = productService.GetAll();
            ViewData["catalog"] = (product);
            return View();
        }
        [HttpGet]
        public IActionResult GetById()
        {
            return View();
        }

        [HttpPost]
        public IActionResult GetById(int id)
        {
            Products product = productService.GetById(id);
            ViewData["catalog1"] = (product);
            return View();
        }


        [HttpGet]
        public IActionResult AddProduct()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddProduct(string title, string description, double unitPrice, string? imageUrl, int quantity)
        {
            Products product = new Products(title, description, unitPrice, imageUrl, quantity);
            productService.Add(product);
            return View();
        }
        [HttpGet]
        public IActionResult DeleteProduct()
        {
            return View();
        }
        [HttpPost]
        public IActionResult DeleteProduct(int id)
        {
            productService.Delete(id);
            return RedirectToAction("Index", "Home");
        }
        [HttpGet]
        public IActionResult UpdateProduct()
        {
            return View();
        }
        [HttpPost]
        public IActionResult UpdateProduct(int id, string title, string description, double unitPrice, string? imageUrl, int quantity)
        {
            Products product = new Products(id, title, description, unitPrice, imageUrl, quantity);
            productService.Update(product);
            return RedirectToAction("Index", "Home");
        }
    }
    
}
