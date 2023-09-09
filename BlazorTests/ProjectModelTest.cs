using CRUDBlazorApp.Shared;
using FluentAssertions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorTests
{
    public class ProjectModelTest
    {
        [Theory]
        [InlineData("project 10", "NEPA", "Open", "111 Broad St.", "Columbus", "Ohio")]
        public void Project_CreateProject(string name, string type, string status, string addressName, string city, string state)
        {
            //Act
            Project project = new Project { Name = name, Type = type, Status = status, AddressName = addressName, City = city, State = state };

            //Assert
            project.Should().NotBeNull();
            project.Name.Should().Be(name);
            project.Type.Should().Be(type);
            project.Status.Should().Be(status);
            project.Should().BeOfType<Project>();
        }
    }
}
