using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace SodaStore.Tests
{
    [TestClass]
    public class ProductsControllerTests
    {
        [TestMethod]
        public void IndexTestNotFound()
        {
            SodaStore.Controllers.ProductsController productsController = new Controllers.ProductsController();
            var result = productsController.Index(3);
            Assert.IsInstanceOfType(result, typeof(NotFoundResult));
        }
        [TestMethod]
        public void IndexTestSuccess()
        {
            SodaStore.Controllers.ProductsController productsController = new Controllers.ProductsController();
            var viewResult = productsController.Index(1);
            Assert.IsInstanceOfType(viewResult, typeof(ViewResult));
            var model = ((ViewResult)viewResult).Model;
            Assert.IsInstanceOfType(model, typeof(SodaStore.Models.ProductViewModel));
            var stronglyTypedModel = (SodaStore.Models.ProductViewModel)model;
            Assert.AreEqual("Exotic Soda", stronglyTypedModel.Name, false);
        }
    }
}