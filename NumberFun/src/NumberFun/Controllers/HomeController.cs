using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using NumberFun.Model;

namespace NumberFun.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Results(string number)
        {
            int num;
            if ( int.TryParse(number, out num) )
            {
                NumericProperties numProp = new NumericProperties(num);
                return View(numProp);
            }else
            {
                return Error();
            }  
        }
        

        public IActionResult Error()
        {
            return View();
        }
    }
}
