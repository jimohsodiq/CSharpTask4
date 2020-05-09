using System;
using Microsoft.AspNetCore.Mvc;

namespace WebApplics.Controllers
{
    public class WebApplicsController : Controller
    {

    [HttpGet]
    public ActionResult SqrRoot()
    {
        return View();
    }

    [HttpPost]
    public ActionResult SqrRoot(int firstNumber, int secondNumber)
    {
        

        double firstnum = Math.Sqrt(firstNumber);
        double secondnum = Math.Sqrt(secondNumber);
        ViewBag.firstNumber = firstnum;
        ViewBag.secondNumber = secondnum;
        ViewBag.result = firstNumber;
        ViewBag.result2 = secondNumber;
        return View();
    }
    }
}
    