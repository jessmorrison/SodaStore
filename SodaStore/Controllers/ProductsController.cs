using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SodaStore.Data;
using SodaStore.Models;

namespace SodaStore.Controllers
{
    public class ProductsController : Controller
    {
        private ApplicationDbContext _context;

        public ProductsController(ApplicationDbContext context)
        {
            _context = context;
        }

        private void PopulateEmptyProducts()
        {
            if(_context.SodaProducts.Count() == 0)
            {
                _context.SodaProducts.AddRange(new SodaProduct
                {
                    ImageURL = "~/images/exotic_soda.jpg",
                    Name = "Exotic Sode",
                    Description = "wow great soda",
                    Price = 1.99m

                }, new SodaProduct
                {
                    ImageURL = "~/images/green_cream.jpg",
                    Name = "Green Soda",
                    Description = "wow great sodaa",
                    Price = 2.99m

                });
                _context.SaveChanges();
            }
        }

        public IActionResult Index(int? id)
        {
            SodaProduct product = _context.SodaProducts.Find(id);

            if (product != null)
            {

                ProductViewModel model = new ProductViewModel
                {
                    Name = product.Name,
                    Description = product.Description,
                    Price = product.Price ?? 0m,
                    ImagePath = product.ImageURL

                    //ImagePath = "~/images/exotic_soda.jpg"
                };
                return View(model);
            }
            /*
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
            }*/

            return NotFound();
        }

        public IActionResult List()
        {
            return View(_context.SodaProducts);
        }
    }
}