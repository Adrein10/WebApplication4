using System.Diagnostics;

using Microsoft.AspNetCore.Mvc;

using WebApplication4.Models;

namespace WebApplication4.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly mydataContext context;

        public HomeController(ILogger<HomeController> logger,mydataContext context)
        {
            _logger = logger;
            this.context = context;
        }

        public IActionResult Index()
        {
            var show = context.Users.ToList();
            return View(show);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(User user)
        {
            context.Users.Add(user);
            context.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult Edit(int id)
        {
            var show = context.Users.Find(id);
            return View(show);
        }
        [HttpPost]
        public IActionResult Edit(User user,int id)
        {
            context.Users.Update(user);
            context.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult Details(int id)
        {
            var show = context.Users.Find(id);
            return View(show);
        }
        public IActionResult Delete(int id)
        {
            var show = context.Users.Find(id);
            return View(show);
        }
        [HttpPost]
        public IActionResult Delete(User user,int id)
        {
            context.Users.Remove(user);
            context.SaveChanges();
            return RedirectToAction("Index");
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