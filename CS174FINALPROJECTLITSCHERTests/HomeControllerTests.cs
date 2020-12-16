using Xunit;
using Moq;
using Microsoft.AspNetCore.Mvc;
using CS174FINALPROJECTLITSCHER.Models;
using CS174FINALPROJECTLITSCHER.Controllers;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.AspNetCore.Http;

namespace CS174FINALPROJECTLITSCHERTests
{
    public class HomeControllerTests
    {

        public ICS174FinalProjectLitscherUnitOfWork GetUnitOfWork()
        {

            var productRep = new Mock<IRepository<Product>>();
            productRep.Setup(m => m.List(It.IsAny<QueryOptions<Product>>())).Returns(new List<Product>());

            var hardnessRep = new Mock<IRepository<Hardness>>();
            hardnessRep.Setup(m => m.List(It.IsAny<QueryOptions<Hardness>>())).Returns(new List<Hardness>());

            var appearanceRep = new Mock<IRepository<Appearance>>();
            appearanceRep.Setup(m => m.List(It.IsAny<QueryOptions<Appearance>>())).Returns(new List<Appearance>());

            var unit = new Mock<ICS174FinalProjectLitscherUnitOfWork>();

            unit.Setup(m => m.Products).Returns(productRep.Object);
            unit.Setup(m => m.Hardnesses).Returns(hardnessRep.Object);
            unit.Setup(m => m.Appearances).Returns(appearanceRep.Object);
            return unit.Object;
        }

        [Fact]
        //Super simple example to make sure that the project is set up ok
        public void SumNumbersMethod_ReturnsFifteen()
        {
            //arrange
            var unit = GetUnitOfWork();
            var controller = new HomeController(unit);
            //act
            var result = controller.SumNumbers(7, 8);
            //assert
            Assert.Equal(15, result);
        }
        //test public IActionResult Add()v
        [Fact]

        public void AddMethod_ReturnsRedirectToActionResult()
        {
            //arrange
            var unit = GetUnitOfWork();
            var temp = new Mock<ITempDataDictionary>();
            var controller = new HomeController(unit) { TempData = temp.Object };

            //act
            var m = controller.Add();

            //assert
            Assert.IsType<RedirectToActionResult>(m);
        }

        [Fact]

        public void AddMethod_ReturnsRedirectToIndex()
        {
            //arrange
            var unit = GetUnitOfWork();
            var temp = new Mock<ITempDataDictionary>();
            var controller = new HomeController(unit) { TempData = temp.Object};

            //act
            var m = controller.Add();
            var c = ((Microsoft.AspNetCore.Mvc.RedirectToActionResult)m).ActionName;

            //assert
            Assert.Equal("Index", c);
        }



        //Unable to create mock session

        //[Fact]
        //public void AddMethodParameter_ReturnsRedirectToIndex()
        //{
        //    //arrange
        //    var session = new Mock<OrdersSession>();
        //    var unit = GetUnitOfWork();
        //    var productListVM = new ProductListViewModel();
        //    productListVM.SelectedProductID = 1;
        //    var temp = new Mock<ITempDataDictionary>();
        //    var controller = new HomeController(unit) { TempData = temp.Object };

        //    //act
        //    var m = controller.Add(productListVM);

        //    //assert
        //    Assert.IsType<RedirectToActionResult>(m);
        //}




    }
}
