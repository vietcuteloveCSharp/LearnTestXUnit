using Domain.Entity;
using Domain.Interface;
using Microsoft.Win32;
using Moq;
using Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnTestX
{
	public class UserServiceTest
	{
		[Fact]
		public async Task RegisterUserAsync_ShouldReturnTrue_WhenUserIsAddedSuccessfully()
		{
			// Arrange
			var mockRepository = new Mock<IUserRepository>();
			mockRepository.Setup(r => r.AddUserAsync(It.IsAny<User>())).ReturnsAsync(true);

			var service = new UserService(mockRepository.Object);

			// Act
			var result = await service.RegisterUserAsync("Vanh", "example@gmail.com");
			// Assert
			Assert.True(result);
		}
		[Fact]
		public async Task RegisterUserAsync_ShouldReturnFalse_WhenUserIsNotAdded()
		{
			// Arrange
			var mockRepository = new Mock<IUserRepository>();
			mockRepository.Setup(r => r.AddUserAsync(It.IsAny<User>())).ReturnsAsync(false);
			mockRepository.Verify(r => r.AddUserAsync(It.IsAny<User>()), Times.Once);
			var service = new UserService(mockRepository.Object);
			// Act
			var result = await service.RegisterUserAsync("Vanh", "hehe");
			// Assert
			Assert.False(result);
		}
		public static IEnumerable<object[]> ValidUserData =>
			new List<object[]>
				{
				new object[] { "Vanh", "example@gmail.com" },
				new object[] { "Alice", "alice@gmail.com" },
				new object[] { "Bob", "bob@outlook.com" }
			};
		[Theory]
		[MemberData(nameof(ValidUserData))]
		public async Task ListData_RegisterUserAsync_ShouldReturnTrue_WhenUserIsAddedSuccessfully(string name,string email)
		{
			// Arrange
			var mockRepository = new Mock<IUserRepository>();
			mockRepository.Setup(r => r.AddUserAsync(It.IsAny<User>())).ReturnsAsync(true);

			var service = new UserService(mockRepository.Object);

			// Act
			var result = await service.RegisterUserAsync(name,email);
			// Assert
			Assert.True(result);
		}
	}
}
