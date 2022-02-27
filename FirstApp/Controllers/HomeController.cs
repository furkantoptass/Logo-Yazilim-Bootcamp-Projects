using FirstApp.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace FirstApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
        [HttpPost]
        public IActionResult Sample( CustomerViewModel model)
        {
            if (ModelState.IsValid)
            {
                return View();
            }
            return View("Sample");
        }
        public IActionResult Sample()
        {

            return View();
            //var customer = new CustomerViewModel
            //{
            //    FirstName = "Furkan",
            //    LastName = "Toptas",
            //    Age = 25,
            //    Adress = "Isparta",
            //    BirtDate = new DateTime(1997, 02, 11),

            //};
            //return View(customer);


            //var firstCostumer = new CustomerViewModel
            //{
            //    FirstName = "John",
            //    LastName = "Doe",
            //    Age = 30,
            //    Adress = "New York"
            //};


            //if (model.Adress.Contains("Canada"))
            //{
            //    return Ok(new SuccessViewModel { message = "Adress is Canada", statusCode = 200 })
            //}

        }

        public IActionResult Index()
        {
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

        public IActionResult BadReq()
        {
            return BadRequest("Başarısız");
        }

        public IActionResult Success()
        {
            return Ok(new SuccessViewModel { message = "Mesaj Başarılı", statusCode = 200 });
        }

        public IActionResult PageNotFound()
        {
            return NotFound();
        }
        public IActionResult Forbidden()
        {
            return StatusCode(403);
        }
        public IActionResult AllStatusCode()
        {
            return StatusCode(StatusCodes.Status510NotExtended);
        }
        public IActionResult ServerError()
        {
            return StatusCode(StatusCodes.Status500InternalServerError);
        }
    }
}
