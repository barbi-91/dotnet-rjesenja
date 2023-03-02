using Exercise_1.Controllers;
using Exercise_1.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Excersice_1.Tests
{
    public class BookControllerTest
    {
        [Fact]
        public void Index_ReturnsView_NotNull()
        {
            // 1 Arrange
            var contorller = new BookController();

            // 2 Act 
            var result = contorller.Index() as ViewResult; 
            var model = result.ViewData.Model as List<Book>;

            // 3 Assert 
            Assert.NotNull(model);
        }

        [Fact]
        public void Index_ReturnsView_WithBookList() 
        {
            // 1 Arrange
            var controller = new BookController();

            // 2 Act
            var result = controller.Index() as ViewResult;
            var model = result.ViewData.Model as List<Book>;

            // 3 Assert
            Assert.IsAssignableFrom<List<Book>>(model);
        }

        [Fact]
        public void Index_ReturnsView_WithoutEmptyElements()
        {
            var controller = new BookController();
            var result = controller.Index() as ViewResult;
            var model = result.ViewData.Model as List<Book>;
            Assert.True(model.Count() > 1);
        }
    }
}
