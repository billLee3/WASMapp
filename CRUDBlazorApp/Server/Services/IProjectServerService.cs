namespace CRUDBlazorApp.Server.Services
{
    public interface IProjectServerService
    {
        Task<ServiceResponse<List<Project>>> SearchProjects(string searchTerm);
        Task<ServiceResponse<List<string>>> GetProjectSearchSuggestions(string searchTerm);
    }
}
