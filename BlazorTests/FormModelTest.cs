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
    
    public class FormModelTest
    {
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

        





    }
}