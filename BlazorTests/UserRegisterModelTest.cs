using CRUDBlazorApp.Shared;
using FluentAssertions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorTests
{
    public class UserRegisterModelTest
    {

        [Theory]
        [InlineData("john.doe@gmail.com", "testPassword#2", "testPassword#2")]
        public void User_UserCreation(string email, string password, string confirmPassword)
        {
            //Act
            UserRegister request = new UserRegister
            {
                Email = email,
                Password = password,
                ConfirmPassword = confirmPassword
            };

            //Assert
            request.Should().NotBeNull();
            request.Email.Should().Be(email);
            request.Password.Should().BeEquivalentTo(confirmPassword);
            request.Should().BeOfType<UserRegister>();
        }
    }
}
