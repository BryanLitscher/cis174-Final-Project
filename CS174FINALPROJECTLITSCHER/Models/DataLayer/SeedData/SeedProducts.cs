﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CS174FINALPROJECTLITSCHER.Models
{
    internal class SeedProducts : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> entity)
        {
            entity.HasData(
                new Product() { productID = 1, productPrice = 25, quantityOrdered = 0, HardnessID = "soft", AppearanceID = "white", productDesc = "Soft cow's-milk cheese. Pale in color with a slight grayish tinge", productName = "Amsterdam", ImageFile = "amsterdam.jpg" },
                new Product() { productID = 2, productPrice = 32.5, quantityOrdered = 0, HardnessID = "hard", AppearanceID = "white", productDesc = "Hard, off-white (or orange if colourings such as annatto are added), sometimes sharp-tasting, natural cheese", productName = "Bravo Cheddar", ImageFile = "bravo_cheddar.jpg" },
                new Product() { productID = 3, productPrice = 27.8, quantityOrdered = 0, HardnessID = "hard", AppearanceID = "orange", productDesc = "Hard, off-white (or orange if colourings such as annatto are added), sometimes sharp-tasting, natural cheese", productName = "Cheddar", ImageFile = "cheddar.jpg" },
                new Product() { productID = 4, productPrice = 36.54, quantityOrdered = 0, HardnessID = "semsoft", AppearanceID = "white", productDesc = "Same firmness and density as cheese, but with a springy or rubbery texture.[1] Fresh curds squeak against the teeth when bitten into", productName = "Cheddar curds", ImageFile = "cheese_curds.jpg" },
                new Product() { productID = 5, productPrice = 21.50, quantityOrdered = 0, HardnessID = "hard", AppearanceID = "orange", productDesc = "Colby is softer, moister, and milder than cheddar because it is produced through a washed-curd process", productName = "Colby", ImageFile = "Colby_Cheese.jpg" },
                new Product() { productID = 6, productPrice = 37.8, quantityOrdered = 0, HardnessID = "hard", AppearanceID = "orange", productDesc = "Commonly used as an interior melting cheese for California-style burritos, but also some Mexican-style burritos", productName = "Monterey Jack", ImageFile = "cheddar.jpg" },
                new Product() { productID = 7, productPrice = 62.35, quantityOrdered = 0, HardnessID = "hard", AppearanceID = "white", productDesc = "Tangy and rich our Extra Mature Unpasteurised Cheddar Cheese wakes up even the most drab of cheese boards.", productName = "Keens Cheddar", ImageFile = "keens-cheddar.jpg" },
                new Product() { productID = 8, productPrice = 16.98, quantityOrdered = 0, HardnessID = "soft", AppearanceID = "white", productDesc = "The cheese is especially known for its strong smell caused by the bacterium Brevibacterium linens.", productName = "Limburger", ImageFile = "limburger_cheese.jpg" },
                new Product() { productID = 9, productPrice = 45.60, quantityOrdered = 0, HardnessID = "medhard", AppearanceID = "white", productDesc = "Vary in color through various shades of blue and green. This carries a distinct smell, either from that or various specially cultivated bacteria.", productName = "Montforte Blue", ImageFile = "montforte_blue_cheese.jpg" },
                new Product() { productID = 10, productPrice = 60.45, quantityOrdered = 0, HardnessID = "medhard", AppearanceID = "white", productDesc = "Have a distinctive appearance, as the blocks or rounds of the cheese are riddled with holes known as eyes.", productName = "Swiss", ImageFile = "Swiss_cheese.jpg" },
                new Product() { productID = 11, productPrice = 21.34, quantityOrdered = 0, HardnessID = "hard", AppearanceID = "white", productDesc = "Hard, crumbly-textured cheese is made with unpasteurized cows' milk that is semi-skimmed through a natural creaming", productName = "Grana Padano", ImageFile = "200px-Grana_Padano_at_Eataly_in_Stockholm.jpg" },
                new Product() { productID = 12, productPrice = 34.21, quantityOrdered = 0, HardnessID = "soft", AppearanceID = "white", productDesc = "Soft cow's-milk cheese. Pale in color with a slight grayish tinge under a rind of white mould. ", productName = "Brie", ImageFile = "220px-Brie_01.jpg" },
                new Product() { productID = 13, productPrice = 62.15, quantityOrdered = 0, HardnessID = "soft", AppearanceID = "white", productDesc = "soft, slightly crumbly, mold-ripened cheese made in the Neufchâtel-en-Bray, French region of Normandy.", productName = "Neufchâtel", ImageFile = "220px-Cœurs_de_Neufchâtel_02.jpg" },
                new Product() { productID = 14, productPrice = 24.65, quantityOrdered = 0, HardnessID = "medhard", AppearanceID = "white", productDesc = "Yellow, medium-hard Swiss cheese. It has a savory but mild taste.", productName = "Emmental", ImageFile = "220px-Emmental_015.jpg" },
                new Product() { productID = 15, productPrice = 34.87, quantityOrdered = 0, HardnessID = "medhard", AppearanceID = "white", productDesc = "Sweet but slightly salty, with a flavor that varies widely with age. It is often described as creamy and nutty when young", productName = "Gruyere", ImageFile = "220px-Gruyere_alpage_th_wa.jpg" },
                new Product() { productID = 16, productPrice = 32.65, quantityOrdered = 0, HardnessID = "semsoft", AppearanceID = "white", productDesc = "Danish cow's milk cheese. It is a table cheese that can be sliced, grilled, or melted.[", productName = "Havarti", ImageFile = "220px-havarti.jpg" },
                new Product() { productID = 17, productPrice = 19.19, quantityOrdered = 0, HardnessID = "medhard", AppearanceID = "white", productDesc = " It is a mild, buttery cheese. The flavor has been described as clean and rich, with a slightly sweet and nutty flavour.", productName = "Jarlsberg", ImageFile = "220px-Jarlsberg_cheese.jpg" },
                new Product() { productID = 18, productPrice = 20.20, quantityOrdered = 0, HardnessID = "medhard", AppearanceID = "white", productDesc = "Type of blue cheese made of cow milk (kashkaval vitosha), sheep milk (kashkaval balkan), or both (kashkaval preslav)", productName = "Kaschkawal", ImageFile = "220px-Kaschkawal_Kashkaval_кашкавал_Balkankäse_Sofia_IMG_7649.jpg" },
                new Product() { productID = 19, productPrice = 40.40, quantityOrdered = 0, HardnessID = "hard", AppearanceID = "white", productDesc = "Parmigiano-Reggiano is commonly grated over pasta dishes, stirred into soups and risottos, and eaten on its own", productName = "Parmigiano", ImageFile = "220px-Parmigiano_Reggiano_meules_MIN_Rungis.jpg" },
                new Product() { productID = 20, productPrice = 32.45, quantityOrdered = 0, HardnessID = "semsoft", AppearanceID = "white", productDesc = "Has a mild flavour. The smell increases the longer the cheese is kept", productName = "Port_Salut", ImageFile = "220px-Port_Salut_cheese.jpg" },
                new Product() { productID = 21, productPrice = 23.45, quantityOrdered = 0, HardnessID = "hard", AppearanceID = "white", productDesc = "Hard, off-white (or orange if colourings such as annatto are added), sometimes sharp-tasting, natural cheese", productName = "Somerset Cheddar", ImageFile = "220px-Somerset-Cheddar.jpg" },
                new Product() { productID = 22, productPrice = 54.32, quantityOrdered = 0, HardnessID = "hard", AppearanceID = "white", productDesc = "Commonly used as an interior melting cheese for California-style burritos, but also some Mexican-style burritos", productName = "Sonoma Jack", ImageFile = "220px-Sonoma_Jack_cheese_-_Stierch.jpg" },
                new Product() { productID = 23, productPrice = 43.21, quantityOrdered = 0, HardnessID = "medhard", AppearanceID = "orange", productDesc = "Mild-flavored, yellow cow's milk cheese originating from the Netherlands. It is one of the most popular cheeses worldwide.", productName = "Gouda", ImageFile = "220px-WikiCheese_-_Gouda_36_mois_03.jpg" },
                new Product() { productID = 24, productPrice = 12.34, quantityOrdered = 0, HardnessID = "medhard", AppearanceID = "white", productDesc = "Flavor is somewhat reminiscent of Cheddar, is a strong, tangy butter taste and grows with age. A well ripened Cantal has a vigorous taste", productName = "Cantal", ImageFile = "250px-Cantal_03.jpg" },
                new Product() { productID = 25, productPrice = 65.43, quantityOrdered = 0, HardnessID = "hard", AppearanceID = "white", productDesc = "Dense and crumbly cheese produced in the English county of Cheshire, and four neighbouring counties", productName = "Cheshire", ImageFile = "250px-Cheshire_Cheese.jpg" },
                new Product() { productID = 26, productPrice = 34.56, quantityOrdered = 0, HardnessID = "hard", AppearanceID = "orange", productDesc = "Colby is softer, moister, and milder than cheddar because it is produced through a washed-curd process", productName = "Colby", ImageFile = "250px-Colby_Cheese.jpg" },
                new Product() { productID = 27, productPrice = 21.87, quantityOrdered = 0, HardnessID = "hard", AppearanceID = "white", productDesc = "Slab cheese, made in large creameries operated by major dairy companies such as Dairy Crest.", productName = "Double Gloucester", ImageFile = "250px-Double_Gloucester_cheese.jpg" },
                new Product() { productID = 28, productPrice = 32.98, quantityOrdered = 0, HardnessID = "semsoft", AppearanceID = "white", productDesc = "strong-smelling soft cheese with a subtle taste, made mainly from milk from the Vosges", productName = "Munster", ImageFile = "260px-Munster.jpg" },
                new Product() { productID = 29, productPrice = 23.89, quantityOrdered = 0, HardnessID = "hard", AppearanceID = "white", productDesc = "served with pears and walnuts or drizzled with strong chestnut honey.", productName = "Pecorino Roman", ImageFile = "260px-Pecorino_romano_on_board_cropped.png" },
                new Product() { productID = 30, productPrice = 21.45, quantityOrdered = 0, HardnessID = "medhard", AppearanceID = "white", productDesc = "Very mild flavour, slightly salty or nutty, and almost no smell when compared to other cheeses.As the cheese ages, its flavour sharpens, and it becomes firmer", productName = "Small Edam", ImageFile = "260px-SmallEdamCheese.jpg" }
            );
        }
    }
}