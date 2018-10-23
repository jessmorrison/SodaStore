using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SodaStore.Models;
namespace SodaStore.Controllers
{
    public class ProductsController : Controller
    {
        public IActionResult Index(int? id)
        {
            if (id == 1)
            {
                ProductViewModel model = new ProductViewModel
                {
                    Name = "Exotic Soda",
                    Description = "This soda is delicious",
                    Price = 2.99m,
                    ImagePath = "~/images/exotic_soda.jpg"
                };
                return View(model);
            }
            else if (id == 2)
            {
                ProductViewModel model = new ProductViewModel
                {
                    Name = "Green Cream Soda",
                    Description = "This is the greenest soda on the market",
                    Price = 3.99m,
                    ImagePath = "~/images/green_cream.jpg"
                };
                return View(model);
            }
            return NotFound();
        }
    }
}