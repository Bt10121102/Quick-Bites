using Microsoft.AspNetCore.Mvc;
using Quick.DataAccess.Repository;
using Quick.DataAccess.Repository.IRepository;
using Quick.Models;




namespace QuickBites.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class SpecialOfferController : Controller
    {
        private readonly ISpecialOfferRepository _SpecialOfferRepository;
        private object _unitOfWork;

        public SpecialOfferController(ISpecialOfferRepository specialofferRepository)
        {
            _SpecialOfferRepository = specialofferRepository;
        }

        public IActionResult Index()
        {
            var specialoffer = _SpecialOfferRepository.GetAll();
            return View(specialoffer);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(SpecialOffer obj)
        {
            if (ModelState.IsValid)
            {
                _SpecialOfferRepository.Add(obj);
                _SpecialOfferRepository.Save(); // Assuming there's a method like Save() in your repository
                TempData["success"] = "SpecialOffer created successfully";
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
            SpecialOffer SpecialOfferFromDb = _SpecialOfferRepository.GetById(id.Value);

            if (SpecialOfferFromDb == null)
            {
                return NotFound();
            }
            return View(SpecialOfferFromDb);
        }

        [HttpPost]
        public IActionResult Edit(SpecialOffer obj)
        {
            if (ModelState.IsValid)
            {
                _SpecialOfferRepository.Update(obj);
                _SpecialOfferRepository.Save();
                TempData["success"] = "specialoffer updated successfully";
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
           SpecialOffer? SpecialOfferFromDb = _SpecialOfferRepository.GetById(id.Value);

            if (SpecialOfferFromDb == null)
            {
                return NotFound();
            }
            return View(SpecialOfferFromDb);
        }

        [HttpPost, ActionName("Delete")]
        public IActionResult DeletePOST(int? id)
        {
            SpecialOffer? obj = _SpecialOfferRepository.GetById(id.Value);
            if (obj == null)
            {
                return NotFound();
            }
           _SpecialOfferRepository.Remove(obj);
            _SpecialOfferRepository.Save();
            TempData["success"] = "Branch deleted successfully";
            return RedirectToAction("Index");
        }
    }
}