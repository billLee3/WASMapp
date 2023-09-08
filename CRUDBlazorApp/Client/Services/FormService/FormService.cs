using CRUDBlazorApp.Shared;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Routing;
using System.ComponentModel;
using System.Net.Http.Json;

namespace CRUDBlazorApp.Client.Services.FormService
{
    public class FormService : IFormService
    {
        private readonly HttpClient _http;
        private readonly NavigationManager _navigationManager;

        public FormService(HttpClient http, NavigationManager navigationManager)
        {
            _http = http;
            _navigationManager = navigationManager;
        }
        public List<Form> Forms { get; set; } = new List<Form>();
        public List<Project> Projects { get; set; } = new List<Project>();

        public async Task CreateForm(Form form)
        {
            try
            {
                var result = await _http.PostAsJsonAsync("api/form/", form);
                await SetForms(result);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            
            
        }

        private async Task SetForms(HttpResponseMessage result)
        {
            var response = await result.Content.ReadFromJsonAsync<List<Form>>();
            if (response != null)
            {
                Forms = response;
            }
            _navigationManager.NavigateTo("forms");
        }

        public async Task DeleteForm(int id)
        {
            var result = await _http.DeleteAsync($"api/form/{id}/");
            await SetForms(result);
        }

        public async Task GetForms()
        {
            var result = await _http.GetFromJsonAsync<List<Form>>("api/form/");
            if(result != null)
            {
                Forms = result;
            }
        }

        public async Task GetProjects()
        {
            var result = await _http.GetFromJsonAsync<List<Project>>("api/project/");
            if(result != null)
            {
                Projects = result;
            }
        }

        public async Task<Form> GetSingleForm(int id)
        {
            var result = await _http.GetFromJsonAsync<Form>($"api/form/{id}/");
            if(result != null)
            {
                return result;
            }
            throw new Exception("Form not found. ");
        }

        public async Task UpdateForm(Form form)
        {
            var result = await _http.PutAsJsonAsync($"api/form/{form.Id}/", form);
            await SetForms(result);
        }

        
    }
}
