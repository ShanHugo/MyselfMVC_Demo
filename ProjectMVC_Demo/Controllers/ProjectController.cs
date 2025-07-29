using Microsoft.AspNetCore.Mvc;
using ProjectMVC.Models;

namespace ProjectMVC.Controllers
{
    public class ProjectController : Controller
    {
        private readonly ForProjectContext _db;

        //  透過建構式注入 DbContext
        public ProjectController(ForProjectContext context)
        {
            _db = context;
        }

        public IActionResult Index()
        {
            var projects = _db.Projects.ToList();
            return View(projects);
        }

        public IActionResult Details(int id)
        {
            var project = _db.Projects.FirstOrDefault(p => p.Id == id);
            if (project == null)
                return NotFound();
            return View(project);
        }

        public IActionResult Contact()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Contact(Contacts contact)
        {
            if (ModelState.IsValid)
            {
                contact.SubmitDate = DateTime.Now;
                _db.Contacts.Add(contact);
                _db.SaveChanges();
                return RedirectToAction("Index", "Home");
            }
            return View(contact);
        }
    }
}
