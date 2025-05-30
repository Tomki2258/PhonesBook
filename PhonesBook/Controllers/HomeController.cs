using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using PhonesBook.Fabrics;
using PhonesBook.Models;
using PhonesBook.Repositories;

namespace PhonesBook.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly CreateViewModel createViewModel = new CreateViewModel();
        private readonly MainViewModel mainViewModel =  MainViewModel.GetInstance();
        private readonly ModifyViewModel modifyViewModel = new ModifyViewModel();
        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult MainView()
        {   
            return View(mainViewModel);
        }
        public IActionResult Create()
        {
            return View(createViewModel);
        }
        [HttpPost]
        public IActionResult Create(Contact contact)
        {
            Debug.WriteLine($"Contact info {contact.name} {contact.number}");
            if (mainViewModel.AddContact(contact))
            {
                return RedirectToAction("MainView");
            }
            return View();
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
        [HttpPost]
        public IActionResult Remove(int id)
        {
            mainViewModel.Remove(id);
            return RedirectToAction("MainView");
        }
        [HttpPost]
        public IActionResult Modify(int id) {
            modifyViewModel.contactID = id;
            return View(modifyViewModel);
        }
        [HttpPost]
        public IActionResult ModifyContact(Contact contact)
        {
            if (ContactFabric.CheckContact(contact))
            {
                mainViewModel.ReplaceContact(contact.id, contact);
                return RedirectToAction("MainView");
            }
            return View(modifyViewModel);
        }
    }
}
