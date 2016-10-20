using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MusicShop.Controllers;
using MusicShop.Models;

namespace MusicShop.Tests.Controllers
{
    [TestClass]
    public class HomeControllerTest
    {
        [TestMethod]
        public void Index()
        {
            // Arrange
            HomeController controller = new HomeController();

            // Act
            ViewResult result = controller.Index() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }


        [TestMethod]
        public void SearchNoInputTest()
        {
            // Arrange
            HomeController controller = new HomeController();

            // Act
            ViewResult result = controller.Index("", "", null, null) as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }
        [TestMethod]
        public void Search1InputTest()
        {
            // Arrange
            HomeController controller = new HomeController();

            // Act
            ViewResult result = controller.Index("Vis", "", null, null) as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }
        [TestMethod]
        public void Search2InputTest()
        {
            // Arrange
            HomeController controller = new HomeController();

            // Act
            ViewResult result = controller.Index("Vis", "New Age", null, null) as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }
        [TestMethod]
        public void Search3InputTest()
        {
            // Arrange
            HomeController controller = new HomeController();

            // Act
            ViewResult result = controller.Index("Vis", "New Age", 2000, null) as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }
        [TestMethod]
        public void Search4InputTest()
        {
            // Arrange
            HomeController controller = new HomeController();

            // Act
            ViewResult result = controller.Index("Vis", "New Age", 2000, 2003) as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }
        [TestMethod]
        public void ViewAlbumTest()
        {
            // Arrange
            HomeController controller = new HomeController();

            // Act
            PartialViewResult result = controller.ViewAlbum(3) as PartialViewResult;

            // Assert
            Assert.IsNotNull(result);
         
        }
    }
}