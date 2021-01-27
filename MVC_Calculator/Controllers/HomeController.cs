using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MVC_Calculator.Models;

namespace MVC_Calculator.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        // connected to our views/inside home folder
        public IActionResult Calculator()
        {
            return View();
        }

        // connected to our views/inside home folder
        // in the Result method take the CalulatorVeiwModel which has all of the properties
        public IActionResult Result(CalculatorViewModel model)
        {
            // create an object within the memory
            var viewModel = new ResultViewModel();

            // create a if statement to test the conditions for each of the Operations: Plus, Minus, Multiply, Divide

            if (model.Operation == "Plus")
            {
                viewModel.Result = model.Add();
                viewModel.Operation = model.Operation;
            }

            if (model.Operation == "Minus")
            {
                viewModel.Result = model.Minus();
                viewModel.Operation = model.Operation;
            }

            if (model.Operation == "Multiply")
            {
                viewModel.Result = model.Multiply();
                viewModel.Operation = model.Operation;
            }

            if (model.Operation == "Divide")
            {
                viewModel.Result = model.Divide();
                viewModel.Operation = model.Operation;

                // Next go to form and bind the models to the form for the views: Calculator & Result -- Within the Calculator.cshtml
            }
            // returning the actual result and the operation we selected
            return View(viewModel);
            
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
