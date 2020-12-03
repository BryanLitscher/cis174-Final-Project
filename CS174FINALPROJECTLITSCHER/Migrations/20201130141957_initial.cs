using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CS174FINALPROJECTLITSCHER.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Appearances",
                columns: table => new
                {
                    AppearanceID = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    Color = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Appearances", x => x.AppearanceID);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CartCustomer",
                columns: table => new
                {
                    CartCustomerId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CartName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CartEmail = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CartCustomer", x => x.CartCustomerId);
                });

            migrationBuilder.CreateTable(
                name: "Hardnesses",
                columns: table => new
                {
                    HardnessID = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    Moisture = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Hardnesses", x => x.HardnessID);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Cart",
                columns: table => new
                {
                    CartId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CartCustomerId = table.Column<int>(type: "int", nullable: false),
                    CartDateTime = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cart", x => x.CartId);
                    table.ForeignKey(
                        name: "FK_Cart_CartCustomer_CartCustomerId",
                        column: x => x.CartCustomerId,
                        principalTable: "CartCustomer",
                        principalColumn: "CartCustomerId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    productID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HardnessID = table.Column<string>(type: "nvarchar(10)", nullable: false),
                    AppearanceID = table.Column<string>(type: "nvarchar(10)", nullable: false),
                    ImageFile = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    productName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    productDesc = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    productPrice = table.Column<double>(type: "float", nullable: false),
                    productNominalWeight = table.Column<double>(type: "float", nullable: false),
                    quantityOrdered = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.productID);
                    table.ForeignKey(
                        name: "FK_Products_Appearances_AppearanceID",
                        column: x => x.AppearanceID,
                        principalTable: "Appearances",
                        principalColumn: "AppearanceID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Products_Hardnesses_HardnessID",
                        column: x => x.HardnessID,
                        principalTable: "Hardnesses",
                        principalColumn: "HardnessID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CartItem",
                columns: table => new
                {
                    CartItemId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CartId = table.Column<int>(type: "int", nullable: false),
                    CartItemDescription = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    CartItemQuantity = table.Column<int>(type: "int", nullable: false),
                    CartItemUnitPrice = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CartItem", x => x.CartItemId);
                    table.ForeignKey(
                        name: "FK_CartItem_Cart_CartId",
                        column: x => x.CartId,
                        principalTable: "Cart",
                        principalColumn: "CartId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Appearances",
                columns: new[] { "AppearanceID", "Color" },
                values: new object[,]
                {
                    { "all", "All" },
                    { "white", "White" },
                    { "orange", "Orange" }
                });

            migrationBuilder.InsertData(
                table: "CartCustomer",
                columns: new[] { "CartCustomerId", "CartEmail", "CartName" },
                values: new object[] { 1, "bclitscher@dmacc.edu", "Bryan Litscher" });

            migrationBuilder.InsertData(
                table: "Hardnesses",
                columns: new[] { "HardnessID", "Moisture" },
                values: new object[,]
                {
                    { "all", "All" },
                    { "soft", "Soft" },
                    { "semsoft", "Semi-soft" },
                    { "medhard", "Medium-hard" },
                    { "hard", "Semi-hard or hard" }
                });

            migrationBuilder.InsertData(
                table: "Cart",
                columns: new[] { "CartId", "CartCustomerId", "CartDateTime" },
                values: new object[] { 1, 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "productID", "AppearanceID", "HardnessID", "ImageFile", "productDesc", "productName", "productNominalWeight", "productPrice", "quantityOrdered" },
                values: new object[,]
                {
                    { 26, "orange", "hard", "250px-Colby_Cheese.jpg", "Colby is softer, moister, and milder than cheddar because it is produced through a washed-curd process", "Colby", 0.0, 34.560000000000002, 0 },
                    { 25, "white", "hard", "250px-Cheshire_Cheese.jpg", "Dense and crumbly cheese produced in the English county of Cheshire, and four neighbouring counties", "Cheshire", 0.0, 65.430000000000007, 0 },
                    { 22, "white", "hard", "220px-Sonoma_Jack_cheese_-_Stierch.jpg", "Commonly used as an interior melting cheese for California-style burritos, but also some Mexican-style burritos", "Sonoma Jack", 0.0, 54.32, 0 },
                    { 21, "white", "hard", "220px-Somerset-Cheddar.jpg", "Hard, off-white (or orange if colourings such as annatto are added), sometimes sharp-tasting, natural cheese", "Somerset Cheddar", 0.0, 23.449999999999999, 0 },
                    { 19, "white", "hard", "220px-Parmigiano_Reggiano_meules_MIN_Rungis.jpg", "Parmigiano-Reggiano is commonly grated over pasta dishes, stirred into soups and risottos, and eaten on its own", "Parmigiano", 0.0, 40.399999999999999, 0 },
                    { 11, "white", "hard", "200px-Grana_Padano_at_Eataly_in_Stockholm.jpg", "Hard, crumbly-textured cheese is made with unpasteurized cows' milk that is semi-skimmed through a natural creaming", "Grana Padano", 0.0, 21.34, 0 },
                    { 7, "white", "hard", "keens-cheddar.jpg", "Tangy and rich our Extra Mature Unpasteurised Cheddar Cheese wakes up even the most drab of cheese boards.", "Keens Cheddar", 0.0, 62.350000000000001, 0 },
                    { 6, "orange", "hard", "cheddar.jpg", "Commonly used as an interior melting cheese for California-style burritos, but also some Mexican-style burritos", "Monterey Jack", 0.0, 37.799999999999997, 0 },
                    { 5, "orange", "hard", "Colby_Cheese.jpg", "Colby is softer, moister, and milder than cheddar because it is produced through a washed-curd process", "Colby", 0.0, 21.5, 0 },
                    { 3, "orange", "hard", "cheddar.jpg", "Hard, off-white (or orange if colourings such as annatto are added), sometimes sharp-tasting, natural cheese", "Cheddar", 0.0, 27.800000000000001, 0 },
                    { 2, "white", "hard", "bravo_cheddar.jpg", "Hard, off-white (or orange if colourings such as annatto are added), sometimes sharp-tasting, natural cheese", "Bravo Cheddar", 0.0, 32.5, 0 },
                    { 30, "white", "medhard", "260px-SmallEdamCheese.jpg", "Very mild flavour, slightly salty or nutty, and almost no smell when compared to other cheeses.As the cheese ages, its flavour sharpens, and it becomes firmer", "Small Edam", 0.0, 21.449999999999999, 0 },
                    { 24, "white", "medhard", "250px-Cantal_03.jpg", "Flavor is somewhat reminiscent of Cheddar, is a strong, tangy butter taste and grows with age. A well ripened Cantal has a vigorous taste", "Cantal", 0.0, 12.34, 0 },
                    { 27, "white", "hard", "250px-Double_Gloucester_cheese.jpg", "Slab cheese, made in large creameries operated by major dairy companies such as Dairy Crest.", "Double Gloucester", 0.0, 21.870000000000001, 0 },
                    { 23, "orange", "medhard", "220px-WikiCheese_-_Gouda_36_mois_03.jpg", "Mild-flavored, yellow cow's milk cheese originating from the Netherlands. It is one of the most popular cheeses worldwide.", "Gouda", 0.0, 43.210000000000001, 0 },
                    { 17, "white", "medhard", "220px-Jarlsberg_cheese.jpg", " It is a mild, buttery cheese. The flavor has been described as clean and rich, with a slightly sweet and nutty flavour.", "Jarlsberg", 0.0, 19.190000000000001, 0 },
                    { 15, "white", "medhard", "220px-Gruyere_alpage_th_wa.jpg", "Sweet but slightly salty, with a flavor that varies widely with age. It is often described as creamy and nutty when young", "Gruyere", 0.0, 34.869999999999997, 0 },
                    { 14, "white", "medhard", "220px-Emmental_015.jpg", "Yellow, medium-hard Swiss cheese. It has a savory but mild taste.", "Emmental", 0.0, 24.649999999999999, 0 },
                    { 10, "white", "medhard", "Swiss_cheese.jpg", "Have a distinctive appearance, as the blocks or rounds of the cheese are riddled with holes known as eyes.", "Swiss", 0.0, 60.450000000000003, 0 },
                    { 9, "white", "medhard", "montforte_blue_cheese.jpg", "Vary in color through various shades of blue and green. This carries a distinct smell, either from that or various specially cultivated bacteria.", "Montforte Blue", 0.0, 45.600000000000001, 0 },
                    { 28, "white", "semsoft", "260px-Munster.jpg", "strong-smelling soft cheese with a subtle taste, made mainly from milk from the Vosges", "Munster", 0.0, 32.979999999999997, 0 },
                    { 20, "white", "semsoft", "220px-Port_Salut_cheese.jpg", "Has a mild flavour. The smell increases the longer the cheese is kept", "Port_Salut", 0.0, 32.450000000000003, 0 },
                    { 16, "white", "semsoft", "220px-havarti.jpg", "Danish cow's milk cheese. It is a table cheese that can be sliced, grilled, or melted.[", "Havarti", 0.0, 32.649999999999999, 0 },
                    { 4, "white", "semsoft", "cheese_curds.jpg", "Same firmness and density as cheese, but with a springy or rubbery texture.[1] Fresh curds squeak against the teeth when bitten into", "Cheddar curds", 0.0, 36.539999999999999, 0 },
                    { 13, "white", "soft", "220px-Cœurs_de_Neufchâtel_02.jpg", "soft, slightly crumbly, mold-ripened cheese made in the Neufchâtel-en-Bray, French region of Normandy.", "Neufchâtel", 0.0, 62.149999999999999, 0 },
                    { 12, "white", "soft", "220px-Brie_01.jpg", "Soft cow's-milk cheese. Pale in color with a slight grayish tinge under a rind of white mould. ", "Brie", 0.0, 34.210000000000001, 0 },
                    { 8, "white", "soft", "limburger_cheese.jpg", "The cheese is especially known for its strong smell caused by the bacterium Brevibacterium linens.", "Limburger", 0.0, 16.98, 0 },
                    { 1, "white", "soft", "amsterdam.jpg", "Soft cow's-milk cheese. Pale in color with a slight grayish tinge", "Amsterdam", 0.0, 25.0, 0 },
                    { 18, "white", "medhard", "220px-Kaschkawal_Kashkaval_кашкавал_Balkankäse_Sofia_IMG_7649.jpg", "Type of blue cheese made of cow milk (kashkaval vitosha), sheep milk (kashkaval balkan), or both (kashkaval preslav)", "Kaschkawal", 0.0, 20.199999999999999, 0 },
                    { 29, "white", "hard", "260px-Pecorino_romano_on_board_cropped.png", "served with pears and walnuts or drizzled with strong chestnut honey.", "Pecorino Roman", 0.0, 23.890000000000001, 0 }
                });

            migrationBuilder.InsertData(
                table: "CartItem",
                columns: new[] { "CartItemId", "CartId", "CartItemDescription", "CartItemQuantity", "CartItemUnitPrice" },
                values: new object[] { 1, 1, "this is what you bought", 1, 56.32 });

            migrationBuilder.InsertData(
                table: "CartItem",
                columns: new[] { "CartItemId", "CartId", "CartItemDescription", "CartItemQuantity", "CartItemUnitPrice" },
                values: new object[] { 2, 1, "this is antoher thing that you bought", 1, 56.32 });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Cart_CartCustomerId",
                table: "Cart",
                column: "CartCustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_CartItem_CartId",
                table: "CartItem",
                column: "CartId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_AppearanceID",
                table: "Products",
                column: "AppearanceID");

            migrationBuilder.CreateIndex(
                name: "IX_Products_HardnessID",
                table: "Products",
                column: "HardnessID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "CartItem");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Cart");

            migrationBuilder.DropTable(
                name: "Appearances");

            migrationBuilder.DropTable(
                name: "Hardnesses");

            migrationBuilder.DropTable(
                name: "CartCustomer");
        }
    }
}
