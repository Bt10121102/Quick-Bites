using Microsoft.AspNetCore.Mvc;
using Quick.DataAccess.Repository.IRepository;
using Quick.Models;




namespace QuickBites.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class BranchController : Controller
    {
        private readonly IBranchRepository _branchRepository;
        private object _unitOfWork;

        public BranchController(IBranchRepository branchRepository)
        {
            _branchRepository = branchRepository;
        }

        public IActionResult Index()
        {
            var branches = _branchRepository.GetAll();
            return View(branches);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Branch obj)
        {
            if (ModelState.IsValid)
            {
                _branchRepository.Add(obj);
                _branchRepository.Save(); // Assuming there's a method like Save() in your repository
                TempData["success"] = "Branch created successfully";
                return RedirectToAction("Index");
            }
            return View(obj);
        }

        public IActionResult Edit(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            Branch branchFromDb = _branchRepository.GetById(id.Value);

            if (branchFromDb == null)
            {
                return NotFound();
            }
            return View(branchFromDb);
        }

        [HttpPost]
        public IActionResult Edit(Branch obj)
        {
            if (ModelState.IsValid)
            {
                _branchRepository.Update(obj);
                _branchRepository.Save();
                TempData["success"] = "Branch updated successfully";
                return RedirectToAction("Index");
            }
            return View(obj);
        }



        public IActionResult Delete(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            Branch? branchFromDb = _branchRepository.GetById(id.Value);

            if (branchFromDb == null)
            {
                return NotFound();
            }
            return View(branchFromDb);
        }

        [HttpPost, ActionName("Delete")]
        public IActionResult DeletePOST(int? id)
        {
            Branch? obj = _branchRepository.GetById(id.Value);
            if (obj == null)
            {
                return NotFound();
            }
            _branchRepository.Remove(obj);
            _branchRepository.Save();
            TempData["success"] = "Branch deleted successfully";
            return RedirectToAction("Index");
        }
    }
}