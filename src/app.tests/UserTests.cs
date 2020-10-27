using System;
using System.Linq;
using app.API.Controllers;
using app.API.Models;
using Xunit;

namespace app.tests
{
    public class UserTests
    {
        [Fact]
        public void CreateUser()
        {
            var controller = new UsersController();

            var user = new User("", "", 12);

                var result = controller.Post(user);
                
            Assert.Equal(3, controller.Get().Count());
        }


        [Fact]
        public void GetUsers()
        {
            var controller = new UsersController();

            var result = controller.Get();

            Assert.Equal(2, result.Count());
        }
    }
}