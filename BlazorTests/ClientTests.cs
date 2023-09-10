using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AngleSharp.Css.Values;
using Bunit;
using CRUDBlazorApp.Client.Pages;
using CRUDBlazorApp.Client.Services.FormService;
using CRUDBlazorApp.Client.Services.ProjectService;
using CRUDBlazorApp.Client.Shared;
using CRUDBlazorApp.Shared;
using Microsoft.AspNetCore.Components;
using Microsoft.Extensions.DependencyInjection;
using Moq;
using Xunit;

namespace BlazorTests 
{
    public class ClientTests : TestContext
    {
        [Fact]
        public void FormsRenderCorrectly()
        {
            var FormServiceMoq = new Mock<IFormService>();
            FormServiceMoq.Setup(m => m.GetForms()).Returns(Task.FromResult( new Form[] {new Form() {
                Id = 1,
                POCName = "Test",
                POCRelationToProp = "Test",
                POCPhone = "123-456-7890",
                PhysicalSetting = "urban",
                Weather = "sunny",
                Zoning = "residential",
                SizeSqFt = 1000,
                NaturalGas = "yes",
                Propane = "yes",
                FuelOil = "yes",
                Electricity = "yes",

                ProjectID = 1
            }} ));
            FormServiceMoq.Setup(m => m.Forms.Equals(FormServiceMoq.Object.Forms));


            var NavigationManagerMoq = new Mock<NavigationManager>();

            Services.AddSingleton<IFormService>(FormServiceMoq.Object);
            Services.AddSingleton<NavigationManager>(NavigationManagerMoq.Object);

            var cut = RenderComponent<Forms>();

            

            cut.Find("#addButton").MarkupMatches(
                @"<button id=""addButton"" class=""btn btn-primary"" >Add Form</button>"); 

  
        }

        [Fact]
        public void ProjectsRenderCorrectly()
        {
            var ProjectServiceMoq = new Mock<IProjectService>();
            Project project = new Project()
            {
                Id = 1,
                Name = "Project 1",
                Status = "Open",
                AddressName = "1",
                City = "1",
                State = "1",
                AssignedTo = "Test",
                CreatedBy = "Test",
                CreateDate = DateTime.UtcNow,
                LastUpdatedBy = "Test",
                LastUpdate = DateTime.UtcNow,
            };
            List<Project> Projects = new List<Project>();
            Projects.Add(project);
            
            ProjectServiceMoq.Setup(m => m.Projects.Equals(Projects));

            var NavigationManagerMoq = new Mock<NavigationManager>();

            Services.AddSingleton<IProjectService>(ProjectServiceMoq.Object);
            Services.AddSingleton<NavigationManager>(NavigationManagerMoq.Object);

            var cut = RenderComponent<Projects>();

            //Verfies that all of the places within the for loop appear. 
            cut.FindAll("div");

            //Verifies SearchComponent shows up on the page. 
            cut.FindComponent<SearchComponent>();

        }
    }
}
