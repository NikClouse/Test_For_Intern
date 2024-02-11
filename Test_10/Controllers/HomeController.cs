using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using System;
using Test_10.Models;

namespace Test_10.Controllers
{
    public class HomeController : Controller
    {
        private readonly IOptions<BankSettings> _bankSettings;

        public HomeController(IOptions<BankSettings> bankSettings)
        {
            _bankSettings = bankSettings;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Calculate(double deposit, int months)
        {
            double result = deposit * Math.Pow(1 + _bankSettings.Value.InterestRate, months);
            // Здесь можно добавить логирование в БД
            return View("Index", result);
        }
    }
}
