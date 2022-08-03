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


        //Agent sub field view
        public IActionResult Agent()
        {
            return View();
        }
        public IActionResult Nepalagentlist()
        {
            return View();
        }
        public IActionResult Abroadagentlist()
        {
            return View();
        }
        //


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
