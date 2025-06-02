using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using TranAQuyen_2280602684_BT3.Models;
using TranAQuyen_2280602684_BT3.Repositories;
using TranAQuyen_2280602684_Buoi3.Repositories;

namespace TranAQuyen_2280602684_BT3.Controllers
{
    public class HomeController : Controller
    {
        private readonly IProductRepository _productRepository;
        public HomeController(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        // Hiển thị danh sách sản phẩm
        public async Task<IActionResult> Index()
        {
            var products = await _productRepository.GetAllAsync();
            return View(products);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
