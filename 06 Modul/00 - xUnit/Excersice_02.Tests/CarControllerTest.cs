using Excersice_2.Controllers;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excersice_02.Tests
{
    public class CarControllerTest
    {
        [Fact]
        public void Index_Returns_ViewResult()
        {
            //Arrange
            var controller = new CarController();

            //Act
            var result = controller.Index() as ViewResult;
            var model = result.ViewData.Model;

            //Assert
            Assert.IsType<ViewResult>(model);
        }
        [Fact]
        public void Create_Returns_ViewResult()
        {
            //Arrange
            var controller = new CarController();

            //Act
            var result = controller.Create() as ViewResult;
            var model = result.ViewData.Model;

            //Assert
            Assert.IsType<ViewResult>(model);
        }
        [Fact]
        public void Details_Returns_ViewResult()
        {
            //Arrange
            var controller = new CarController();
            int id = 1;

            //Act
            var result = controller.Details(id) as ViewResult;
            var model = result.ViewData.Model;

            //Assert
            Assert.IsType<ViewResult>(model);
        }
        [Fact]
        //estira ako rezultat nije null i ako akcija „Delete” uredno preusmjrava
        //korisnika na „Index” akciju
        public void Delete_Returns_ViewResult()
        {
            //Arrange
            var controller = new CarController();
            int id = 1;

            //Act
            var result = controller.Delete(id) as ViewResult;
            var model = result.ViewData.Model;

            //Assert
            Assert.IsType<ViewResult>(model);
        }
    }
}
