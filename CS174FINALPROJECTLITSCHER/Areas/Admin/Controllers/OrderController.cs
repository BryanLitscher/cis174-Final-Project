using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CS174FINALPROJECTLITSCHER.Models;
using Microsoft.AspNetCore.Authorization;

//namespace CS174FINALPROJECTLITSCHER.Areas.Admin.Controllers
namespace CS174FINALPROJECTLITSCHER
{
        [Authorize(Roles = "Admin")]
        [Area("Admin")]
    public class OrderController : Controller
    {
        private  CS174FinalProjectLitscherContext context { get; set; }
        private ICS174FinalProjectLitscherUnitOfWork data { get; set; }

        public OrderController (ICS174FinalProjectLitscherUnitOfWork unit)
        {
            data = unit;
        }

        public IActionResult Index()
        {

            var cartOptions = new QueryOptions<Cart>
            {
                Includes = "cartCustomer"
            };
            List<Cart> testcart = data.Carts.List(cartOptions).ToList();

            return View(testcart);
        }

        public IActionResult PickTicket( int id)
        {


            var cartOptions = new QueryOptions<Cart>
            {
                Includes = "cartCustomer, cartItems",
                Where = a => a.CartId == id
            };
            Cart pickcart = data.Carts.Get(cartOptions);



            return View(pickcart);
        }


        public IActionResult Delete( int id)
        {
            Cart cart = data.Carts.Get(id);

            data.Carts.Delete(cart);
            data.Carts.Save();

            return RedirectToAction("Index");
        }
    }
}
