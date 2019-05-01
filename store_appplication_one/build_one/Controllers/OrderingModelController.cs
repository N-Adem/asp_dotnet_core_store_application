using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using build_one.Models;

namespace build_one.Controllers
{
    public class OrderingModelController: Controller
    {
        public ActionResult Index()
        {
            OrderingModel Order1 = new OrderingModel();
            ElectronicsStockModel Electric = new ElectronicsStockModel();
            List<ElectronicsStockModel> electricals = new List<ElectronicsStockModel>(); 
            
            return View(Order1);
        }

        public ActionResult Delivery()
        {
            
            return View();
        }
    }
}
