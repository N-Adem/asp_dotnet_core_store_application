using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace build_one.Controllers
{
    public class OrderingModelController: Controller
    {
        public ActionResult Index()
        {

            return View();
        }

        public ActionResult Delivery()
        {
            
            return View();
        }
    }
}
