using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using myFirstApp.Models;
using myFirstApp.ViewModels;
// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace myFirstApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly IPieInterface _pieRepository;

        public HomeController(IPieInterface pieRepository)
        {
            _pieRepository = pieRepository;
        }

        // GET: /<controller>/
        public IActionResult Index()
        {
            var pies = _pieRepository.GetAllPies().OrderBy(p => p.Name);
            var homeViewModel = new HomeViewModel()
            {
                Title = "Pie Overview",
                Pies = pies.ToList()
            };

            return View(homeViewModel);
        }

        public IActionResult Details(int id) {
            var pie = _pieRepository.GetPieById(id);
            if (pie ==null){
                return NotFound();
            }

            return View(pie);
        }
    }
}
