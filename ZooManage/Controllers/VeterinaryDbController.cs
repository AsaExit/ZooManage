using Microsoft.AspNetCore.Mvc;
using ZooManage.Data;
using ZooManage.Models;

namespace ZooManage.Controllers
{
    public class VeterinaryDbController : Controller
    {
        readonly ZooManageDbContext _zooManage;
        public VeterinaryDbController(ZooManageDbContext zooManage)
        {
            _zooManage = zooManage;
        }

        public IActionResult Index()
        {
            return View(_zooManage.Veters.ToList());
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Veterinary veterinary)
        {
            ModelState.Remove("Id");
            if (ModelState.IsValid)
            {
                veterinary.Id = veterinary.Id;
                _zooManage.Veters.Add(veterinary);
                _zooManage.SaveChanges();
            }
            return RedirectToAction("index");

        }

    }
}
