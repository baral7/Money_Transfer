using Microsoft.AspNetCore.Mvc;

namespace MoneyTransfer.Controllers
{
    public class BankController : Controller
    {
        public IActionResult Registration()
        {
            return View();
        }
        public IActionResult Login()
        {
            return View();
        }
        public IActionResult Agent()
        {
            return View();
        }
        public IActionResult Currenttransaction()
        {
            return View();
        }
        public IActionResult Newtransaction()
        {
            return View();
        }
        public IActionResult Nepalagent()
        {
            return View();
        }
        public IActionResult Abroadagent()
        {
            return View();
        }

        public IActionResult Homepage()
        {
            return View();
        }
    }
}
