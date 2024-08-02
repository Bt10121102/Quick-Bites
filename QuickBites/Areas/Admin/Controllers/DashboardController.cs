using Microsoft.AspNetCore.Mvc;
using Quick.DataAccess.Repository.IRepository;
using Quick.Models;
using QuickBites.Utility;
using System.Linq;
using System.Threading.Tasks;

namespace QuickBites.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class DashboardController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;

        public DashboardController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<IActionResult> Index(int? categoryId)
        {
            var viewModel = new ProductDashboardViewModel
            {
                Categories = _unitOfWork.Category.GetAll().ToList(),
                Products = categoryId == null
                    ? _unitOfWork.Product.GetAll().ToList()
                    : _unitOfWork.Product.GetAll(p => p.CategoryId == categoryId).ToList(),
                SelectedCategoryId = categoryId
            };

            return View(viewModel);
        }





        public IActionResult FilterByCategory(int categoryId)
        {
            // Logging the category ID to ensure it's correctly received
            Console.WriteLine("Category ID received: " + categoryId);

            var products = _unitOfWork.Product.GetAll(d => d.CategoryId == categoryId).ToList();
            var viewModel = new ProductDashboardViewModel
            {
                Categories = _unitOfWork.Category.GetAll().ToList(),
                Products = products,
                SelectedCategoryId = categoryId
            };

            // Logging the count of products to debug the fetched data
            Console.WriteLine("Number of products fetched: " + products.Count);

            return View("Index", viewModel);
        }


    }
}
