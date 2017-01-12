using Microsoft.AspNetCore.Mvc;
using DataBinding.Models;
using System.Linq;

namespace DataBinding.Controllers
{
    public class HomeController : Controller
    {
        private IRepository repository;
        public HomeController(IRepository repo)
        {
            repository = repo;
        }
        //public ViewResult Index(int id) => 
        //    View(repository[id] ?? repository.People.First());
        public IActionResult Index(int? id)
        {
            Person person;
            if (id.HasValue && (person = repository[id.Value]) != null)
            {
                return View(person);
            }
            else
            {
                return NotFound();
            }
        }

        public ViewResult Create() => View(new Person());

        [HttpPost]
        public ViewResult Create(Person model) => View("Index", model);
    }
}
