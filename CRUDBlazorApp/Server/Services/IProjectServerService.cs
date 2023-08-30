namespace CRUDBlazorApp.Server.Services
{
    public interface IProjectServerService
    {
        Task<ServiceResponse<List<Project>>> SearchProjects(string searchTerm);
        Task<List<string>> GetProjectSearchSuggestions(string searchTerm);
    }
}
