using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CS174FINALPROJECTLITSCHER.Models;

namespace CS174FINALPROJECTLITSCHER.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
			var model = new ProductListViewModel
			{
				Appearance = new List<Appearance>
				{
					new Appearance(){Color = "All" },
					new Appearance(){Color = "White" },
					new Appearance(){Color = "Orange" },
				},
				Moisture = new List<Hardness>
                {
					new Hardness(){Moisture = "All" },
					new Hardness(){Moisture = "Soft" },
					new Hardness(){Moisture = "Semi-soft" },
					new Hardness(){Moisture = "Medium-hard" },
					new Hardness(){Moisture = "Semi-hard or hard" }
				},
				Products = new List<Product>(){
					new Product(){ ImageFile = "amsterdam.jpg"},
					new Product(){ ImageFile = "bravo_cheddar.jpg"},
					new Product(){ ImageFile = "cheddar.jpg"},
					new Product(){ ImageFile = "cheese_curds.jpg"},
					new Product(){ ImageFile = "Colby_Cheese.jpg"},
					new Product(){ ImageFile = "cheddar.jpg"},
					new Product(){ ImageFile = "keens-cheddar.jpg"},
					new Product(){ ImageFile = "limburger_cheese.jpg"},
					new Product(){ ImageFile = "montforte_blue_cheese.jpg"},
					new Product(){ ImageFile = "Swiss_cheese.jpg"},
					new Product(){ ImageFile = "200px-Grana_Padano_at_Eataly_in_Stockholm.jpg"},
					new Product(){ ImageFile = "220px-Brie_01.jpg"},
					new Product(){ ImageFile = "220px-Cœurs_de_Neufchâtel_02.jpg"},
					new Product(){ ImageFile = "220px-Emmental_015.jpg"},
					new Product(){ ImageFile = "220px-Gruyere_alpage_th_wa.jpg"},
					new Product(){ ImageFile = "220px-havarti.jpg"},
					new Product(){ ImageFile = "220px-Jarlsberg_cheese.jpg"},
					new Product(){ ImageFile = "220px-Kaschkawal_Kashkaval_кашкавал_Balkankäse_Sofia_IMG_7649.jpg"},
					new Product(){ ImageFile = "220px-Parmigiano_Reggiano_meules_MIN_Rungis.jpg"},
					new Product(){ ImageFile = "220px-Port_Salut_cheese.jpg"},
					new Product(){ ImageFile = "220px-Somerset-Cheddar.jpg"},
					new Product(){ ImageFile = "220px-Sonoma_Jack_cheese_-_Stierch.jpg"},
					new Product(){ ImageFile = "220px-WikiCheese_-_Gouda_36_mois_03.jpg"},
					new Product(){ ImageFile = "250px-Cantal_03.jpg"},
					new Product(){ ImageFile = "250px-Cheshire_Cheese.jpg"},
					new Product(){ ImageFile = "250px-Colby_Cheese.jpg"},
					new Product(){ ImageFile = "250px-Double_Gloucester_cheese.jpg"},
					new Product(){ ImageFile = "260px-Munster.jpg"},
					new Product(){ ImageFile =  "260px-Pecorino_romano_on_board_cropped.png"},
					new Product(){ ImageFile =  "260px-SmallEdamCheese.jpg"}
				}
		};
            return View(model);
        }
    }
}

//@*
//	soft Brie, Neufchâtel
//	semi soft Havarti, Munster cheese, Port Salut
//	Medium-hard Emmental cheese Gruyère Gouda Edam Jarlsberg Cantal Kashkaval
//	Semi-hard or hard Cheddar Cheshire Gloucester Colby Monterey Jack "Grana Padano" "Parmigiano-Reggiano" Pecorino
//*@