using Clouds_AWS.Controllers;
using Clouds_AWS.Entities;
using Clouds_AWS.Repository;
using Microsoft.Extensions.Logging;
using Moq;
using NUnit.Framework;
using System.Collections.Generic;

namespace Clouds_AWS.Tests
{
    [TestFixture]
    public class UserControllerTests
    {
        public IEnumerable<User> expectedUsers = new User[]
        {
            new User {Id = "test_1", Name = "test_user_1", CompanyName = "test_company_1", ImageFile = "test_image" },
            new User {Id = "test_2", Name = "test_user_2", CompanyName = "test_company_2", ImageFile = "test_image" },
            new User {Id = "test_3", Name = "test_user_3", CompanyName = "test_company_3", ImageFile = "test_image" }
        };
        private Mock<IUserRepository> userRepositoryStub;
        private Mock<ILogger<UserController>> logger;

        [SetUp]
        public void Setup()
        {
            userRepositoryStub = new Mock<IUserRepository>();
            logger = new Mock<ILogger<UserController>>();
            userRepositoryStub.Setup(rep => rep.GetUsers()).ReturnsAsync(expectedUsers);
        }

        [Test]
        public void GetUsers_ValidData_CallsOnce()
        {
            // Arrange
            var controller = new UserController(userRepositoryStub.Object, logger.Object);

            // Act
            var actionResult = controller.GetUsers();

            // Assert
            userRepositoryStub.Verify(m => m.GetUsers(), Times.Once);
            //Assert.AreEqual(actionResult, expectedUsers);
        }

        [Test]
        public void CreateUsers_ValidUser_CallsOnce()
        {
            var user = new User
            {
                Name = "testUse",
                Id = "test_4"
            };

            // Arrange
            var controller = new UserController(userRepositoryStub.Object, logger.Object);

            // Act
            var actionResult = controller.CreateUser(user);

            // Assert
            userRepositoryStub.Verify(m => m.CreateUser(It.IsAny<User>()), Times.Once);
        }
    }
}