using Bunit;
using CRUDBlazorApp.Client.Shared;
using CRUDBlazorApp.Client.Pages;
using System.Security.Cryptography;

namespace BlazorTestProject
{
    public class UnitTest1 : TestContext
    {
        public void ProjectsRendersCorrectly()
        {
            var cut = RenderComponent<Projects>();

            cut.MarkupMatches("<h3>Projects</h3>");
        }

        public void FormsRenderCorrectly()
        {
            var cut = RenderComponent<Forms>();
            cut.MarkupMatches("<h3>Forms</h3>");
        }
    }
}