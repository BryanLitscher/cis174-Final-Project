using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using CS174FINALPROJECTLITSCHER.Models;


namespace CS174FINALPROJECTLITSCHER.Controllers
{
    public class CartController : Controller
    {
        private ICS174FinalProjectLitscherUnitOfWork data { get; set; }

        public CartController(ICS174FinalProjectLitscherUnitOfWork unit)
        {
            data = unit;
        }
        public IActionResult Index()
        {
            var session = new OrdersSession(HttpContext.Session);
            var cheeses = session.GetProducts();
            double totalValue = 0;
            foreach (Product c in cheeses)
            {
                totalValue += c.quantityOrdered * c.productPrice;
            }

            var model = new CartViewModel
            {
                Products = cheeses,
                TotalValue = totalValue
            };
            return View(model);
        }



        public ViewResult Checkout()
        {
            var session = new OrdersSession(HttpContext.Session);
            var cheeses = session.GetProducts();
            string myName = this.User.Identity.Name;

            ///////////////////////////////////
            ///write to cartcustomer
            //////////////////////////////////

            QueryOptions<CartCustomer> qo = new QueryOptions<CartCustomer>
            {
                Where = b => b.CartName == myName.ToLower()
            };

            //List<CartCustomer> Store = data.CartCustomers.List(new QueryOptions<CartCustomer> { }).ToList();
            List<CartCustomer> cartCust = data.CartCustomers.List(qo).ToList();

            if(cartCust.Count == 0)
            {
                data.CartCustomers.Insert(new CartCustomer { CartName = myName.ToLower() });
                data.CartCustomers.Save();
            }

            ///
            ///get id
            ///

            cartCust = data.CartCustomers.List(qo).ToList();
            int cartCustomerID = cartCust[0].CartCustomerId;

            ///////////////////////////////////
            ///write to cart
            //////////////////////////////////



            DateTime dt = DateTime.Now;


            Cart cart = new Cart() { CartCustomerId = cartCustomerID, CartDateTime= dt };

            data.Carts.Insert(cart);

            data.Carts.Save();

            //// get id
            QueryOptions<Cart> carQo = new QueryOptions<Cart>
            {
                Where = b => b.CartDateTime == dt && b.CartCustomerId== cartCustomerID
            };
            List<Cart> cartList = data.Carts.List(carQo).ToList();
            int cartID = cartList[0].CartId;

            ///////////////////////////////////
            ///write to cartitems
            //////////////////////////////////


            var test = new CartItem()
            {
                CartId=cartID,
                CartItemDescription = cheeses[0].productDesc,
                CartItemQuantity = cheeses[0].quantityOrdered,
                CartItemUnitPrice = cheeses[0].productPrice
            };

            // cart.cartItems.Add(cart);

            data.CartItems.Insert(test);

            data.CartItems.Save();


            //var session = new OrdersSession(HttpContext.Session);
            //var cheeses = session.GetProducts();
            double totalValue = 0;
            foreach (Product c in cheeses)
            {
                totalValue += c.quantityOrdered * c.productPrice;
            }

            var model = new CartViewModel
            {
                Products = cheeses,
                TotalValue = totalValue,
                UserName= myName
            };

            //get id on insert/add
            //https://entityframework.net/retrieve-id-of-inserted-entity
            return View(model);
        }
    }
}
