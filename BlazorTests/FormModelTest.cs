using Bunit;
using CRUDBlazorApp.Client.Pages;
using CRUDBlazorApp.Client.Services.ProjectService;
using CRUDBlazorApp.Client.Shared;
using CRUDBlazorApp.Server.Controllers;
using CRUDBlazorApp.Server.Data;
using CRUDBlazorApp.Server.Services;
using CRUDBlazorApp.Shared;
using FluentAssertions;
using Microsoft.AspNetCore.Components;
using Microsoft.EntityFrameworkCore.Query.Internal;
using Microsoft.Extensions.DependencyInjection;
using Xunit;

namespace BlazorTests
{
    
    public class ModelTest
    {
        [Theory]
        [InlineData("project 10", "NEPA", "Open", "111 Broad St.", "Columbus", "Ohio")]
       public void Project_CreateProject(string name, string type, string status, string addressName, string city, string state)
        {
            //Act
            Project project = new Project{ Name=name, Type=type, Status=status, AddressName=addressName, City=city, State=state};

            //Assert
            project.Should().NotBeNull();
            project.Name.Should().Be(name);
            project.Type.Should().Be(type);
            project.Status.Should().Be(status);
            project.Should().BeOfType<Project>();
        }

        [Theory]
        [InlineData("John Doe", "Owner", "123-456-7890", "Urban", "Raining", "Commercial", 1000, "Yes", "Yes", "Yes", "No", 1)]
        public void Form_CreateForm(string POCName, string relation, string phone, string setting, string weather, string zoning, int sqft, string nG, string propane, string oil, string electric, int projectID)
        {
            //Act
            Form form = new Form
            {
                POCName = POCName,
                POCRelationToProp = relation,
                POCPhone = phone,
                PhysicalSetting = setting,
                Weather = weather,
                Zoning = zoning,
                SizeSqFt = sqft,
                NaturalGas = nG,
                Propane = propane,
                FuelOil = oil,
                Electricity = electric,
                ProjectID = projectID
            };

            //Assert
            form.Should().NotBeNull();
            form.SizeSqFt.Should().Be(sqft);
            form.SizeSqFt.Should().BeGreaterThan(0);
            form.ProjectID.Should().BeGreaterThan(0);
            form.Should().BeOfType<Form>();
        }

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