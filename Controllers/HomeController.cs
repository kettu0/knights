using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Knights.Models;
using Knights.Repositories;

namespace Knights.Controllers
{
    public class HomeController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;

        public HomeController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public IActionResult Index()
        {
            var knights = _unitOfWork.Knights.GetAll();
            var horses = _unitOfWork.Horses.GetAll();
            var vows = _unitOfWork.Vows.GetAll();
            var weapons = _unitOfWork.Weapons.GetAll();
            return View(new KnightsHorsesVowWeaponsViewModel { Knights = knights, Horses = horses, Vows = vows, Weapons = weapons });
        }

        public IActionResult GetSers()
        {
            var serKnights = _unitOfWork.Knights.GetKnightsContainingSer();
            return View(serKnights);
        }

        public IActionResult GetLands()
        {
            var landsWithLands = _unitOfWork.Knights.GetKnightsWithLandsInLandName();
            return View(landsWithLands);
        }

        public IActionResult GetFastestHorses()
        {
            var fastestHorses = _unitOfWork.Horses.GetTheFastestHorses();
            return View(fastestHorses);
        }

        public IActionResult GetStrongestHorses()
        {
            var strongestHorses = _unitOfWork.Horses.GetTheStrongestHorses();
            return View(strongestHorses);
        }

        public IActionResult GroupKnightsByWeapons()
        {
            var knightsAndWeapons = _unitOfWork.Knights.GroupKnightsByWeapons();
            return View(knightsAndWeapons);
        }

        public IActionResult AddKnight()
        {
            _unitOfWork.Knights.Add(new Knight
            {
                Name = "Ser/Lady",
                Land = "One of the Seven Kingdoms",
                Castle = "Their Keep",
            });

            _unitOfWork.Complete();
            return RedirectToAction("Index");

        }

        protected override void Dispose(bool disposing)
        {
            _unitOfWork.Dispose();
            base.Dispose(disposing);
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
