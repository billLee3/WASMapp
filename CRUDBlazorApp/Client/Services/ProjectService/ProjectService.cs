using CRUDBlazorApp.Shared;
using Microsoft.AspNetCore.Components;
using System.Net.Http.Json;
using static System.Net.WebRequestMethods;

namespace CRUDBlazorApp.Client.Services.ProjectService
{
    public class ProjectService : IProjectService
    {
        private readonly HttpClient _http;
        private readonly NavigationManager _navigationManager;

        public ProjectService(HttpClient http, NavigationManager navigationManager)
        {
            _http = http;
            _navigationManager = navigationManager;
        }
        public List<Project> Projects { get; set; }

        public string Message { get; set; } = "Loading projects...";
        public event Action ProjectsChanged;
        public async Task GetProjects()
        {
            var result = await _http.GetFromJsonAsync<List<Project>>("api/project/");
            if (result != null)
            {
                Projects = result;
            }
        }

        public async Task<Project> GetSingleProject(int id)
        {
            var result = await _http.GetFromJsonAsync<Project>($"api/project/{id}");
            if (result != null)
            {
                return result;
            }
            throw new Exception("Project not found");
        }

        public async Task CreateProject(Project project)
        {
            var result = await _http.PostAsJsonAsync("api/project/", project);
            await SetProjects(result);
        }

        public async Task DeleteProject(int id)
        {
            var result = await _http.DeleteAsync($"api/project/{id}");
            await SetProjects(result);
        }

        public async Task UpdateProject(Project project)
        {
            var result = await _http.PutAsJsonAsync($"api/project/{project.Id}/", project);
            await SetProjects(result);
        }

        private async Task SetProjects(HttpResponseMessage result)
        {
            var response = await result.Content.ReadFromJsonAsync<List<Project>>();
            if (response != null)
            {
                Projects = response;
            }
            _navigationManager.NavigateTo("projects");
            
        }

        public async Task SearchProjects(string searchEntry)
        {
            var result = await _http.GetFromJsonAsync<ServiceResponse<List<Project>>>($"api/project/search/{searchEntry}");
            if (result != null && result.Data != null)
            {
                Projects = result.Data;
            }
            if (Projects.Count == 0)
            {
                Message = "No projects found.";
            }
            ProjectsChanged?.Invoke();
        }
    }
}
