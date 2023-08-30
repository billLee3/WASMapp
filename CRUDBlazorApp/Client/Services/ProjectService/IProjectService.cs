namespace CRUDBlazorApp.Client.Services.ProjectService
{
    public interface IProjectService
    {
        event Action ProjectsChanged;
        List<Project> Projects { get; set; }
        string Message { get; set; }
        Task GetProjects();
        Task<Project> GetSingleProject(int id);
        Task CreateProject(Project project);
        Task UpdateProject(Project project);
        Task DeleteProject(int id);
    }
}
