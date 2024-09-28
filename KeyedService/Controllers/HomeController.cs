using KeyedService.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using KeyedService.Services;

namespace KeyedService.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IStorageService _storageService;
        public HomeController(ILogger<HomeController> logger, IStorageService storageService)
        {
            _storageService = storageService;
            _logger = logger;
        }

        public IActionResult Index(/*[FromKeyedServices("LocalService")] IStorageService storageService*/)
        {
            //storageService.UploadData("Data from storage service");
            _storageService.UploadData("Data from storage service");
            return View();
        }

        public IActionResult Privacy(/*[FromKeyedServices("CloudService")] IStorageService storageService*/)
        {
            //storageService.UploadData("Data from cloud service");
            _storageService.UploadData("Data from cloud service");
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
