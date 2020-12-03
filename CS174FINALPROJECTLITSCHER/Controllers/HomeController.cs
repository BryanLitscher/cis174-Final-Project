using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CS174FINALPROJECTLITSCHER.Models;
using Newtonsoft.Json;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Authorization;

namespace CS174FINALPROJECTLITSCHER.Controllers
{
    public class HomeController : Controller 
    {

		private ICS174FinalProjectLitscherUnitOfWork data { get; set; }

		public HomeController(ICS174FinalProjectLitscherUnitOfWork unit)
		{
			data = unit;
		} 

		public IActionResult Add()
        {
			//runs when order button is clicked, 
			//but user is not logged in prior to 
			//clicking the button
			TempData["message"] ="Item not added to cart";
			return RedirectToAction("Index", "Home");
		}
		[Authorize]
		[HttpPost]
		public IActionResult Add(ProductListViewModel p)
		{
			string msg = "";
			var session = new OrdersSession(HttpContext.Session);
			var cheeses = session.GetProducts();

			if (p.SelectedProductID < 0)
            {
				//When remove button is clicked, negative Product ID is returned
				cheeses.RemoveAll((x) => x.productID == ( -1 * p.SelectedProductID ));
				msg = "Removed: " + cheeses[(p.SelectedProductID*-1)].productName ;
			}
            else
            {
				//on repeat button incriment count rather than add a line item
				List<Product> myCheeses = cheeses.Where(i => i.productID == p.SelectedProductID).ToList();
				int i = -1;
				int index = 0;
				
			
				if (myCheeses.Count > 0)
				{
					foreach (Product c in cheeses)
					{
						i++;
						if (c.productID == p.SelectedProductID)
							index = i;
					}
				}
				if (i < 0)
				{
					//new line item
					var b = data.Products.Get( p.SelectedProductID );
					b.quantityOrdered = 1;
					//cheeses.Add(new Product { productID = p.SelectedProductID , quantityOrdered =1});
					cheeses.Add(b);
					msg = "Added first item: " + b.productName;
				}
				else
				{
					//add quantity to an existing line item
					cheeses[index].quantityOrdered++;
					msg = "Added additional item: " + cheeses[index].productName;
				}
            }

			//save orders as session variable
			session.SetProducts(cheeses);

			double totalValue = 0;
			foreach ( Product c in cheeses)
            {
				totalValue += c.quantityOrdered * c.productPrice;
            }
			TempData["currentOrderAmount"] = totalValue.ToString("c2");

			TempData["message"] =   msg;
			//'{AppearanceID}/{HardnessID}'
			return RedirectToAction("Index" ,"Home", new { HardnessID = p.ActiveTexture, AppearanceID = p.ActiveAppearance } );
        }
        public IActionResult Index(string AppearanceID = "all", string HardnessID = "all")
        {

			var session = new OrdersSession(HttpContext.Session);
			var cheeses = session.GetProducts();

			List<Product> Store = data.Products.List(new QueryOptions<Product> { }).ToList();

			//Assign quantities to the items displayed so that the number ordered is added to button
			foreach ( Product item in Store)
            {
				foreach (Product orderedItem in cheeses)
                {
					if( item.productID == orderedItem.productID)
                    {
						item.quantityOrdered = orderedItem.quantityOrdered;
                    }
                }
            }


			if (HardnessID != "all")
				Store = Store.Where(p => p.HardnessID == HardnessID).ToList();
			if (AppearanceID != "all")
				Store = Store.Where(p => p.AppearanceID == AppearanceID).ToList();

			var model = new ProductListViewModel
			{
				ActiveAppearance = AppearanceID,
				ActiveTexture = HardnessID,
                Appearance = data.Appearances.List(new QueryOptions<Appearance> { }).ToList(),
				Moisture = data.Hardnesses.List(new QueryOptions<Hardness> { }).ToList(),
				Products=Store
			};
			return View(model);
        }
		//simple method for test
		public int SumNumbers(int a, int b) { return a + b; }




	}
}

