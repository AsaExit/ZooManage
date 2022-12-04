using Microsoft.AspNetCore.Mvc;
using ZooManage.Data;
using ZooManage.Models;

namespace ZooManage.Controllers
{
    public class AnimalDbController : Controller
    {
        readonly ZooManageDbContext _zooManage;
        public AnimalDbController(ZooManageDbContext zooManage)
        {
            _zooManage=zooManage;
        }
        [HttpGet]
        public IActionResult Index()
        {
            return View(_zooManage.Animals.ToList());
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]  
        public IActionResult Create(Animal animal)
        {
            ModelState.Remove("Id");
            if (ModelState.IsValid)
            {
                animal.Id=animal.Id;
                _zooManage.Animals.Add(animal);
                _zooManage.SaveChanges();
            }
            return RedirectToAction("index");
            
        }

    }
}
