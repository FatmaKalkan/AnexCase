using AnexCase.Web.Context;
using AnexCase.Web.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Security.Cryptography.X509Certificates;
using System.Security.Policy;
using System.Configuration;

namespace AnexCase.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly AnexCaseContext _context;

        public HomeController(AnexCaseContext context, ILogger<HomeController> logger)
        {
            _context = context;
            _logger = logger;
        }

        [HttpGet]
        public ActionResult Index()
        {

            var list = _context.Results.ToList();
            return View(list);
        }
    }
}