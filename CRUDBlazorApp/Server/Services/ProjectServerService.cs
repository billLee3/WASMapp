namespace CRUDBlazorApp.Server.Services
{
    public class ProjectServerService : IProjectServerService
    {
        private readonly DataContext _context;

        public ProjectServerService(DataContext context)
        {
            _context = context;
        }
        
        //Might need to check this
        public async Task<ServiceResponse<List<Project>>> SearchProjects(string searchTerm)
        {
            var response = new ServiceResponse<List<Project>>
            {
                Data = await FindProjectsBySearch(searchTerm)
            };
            return response;
        }

        private async Task<List<Project>> FindProjectsBySearch(string searchTerm)
        {
            return await _context.Projects.Where(p => p.Name.ToLower().Contains(searchTerm.ToLower()) ||
            p.City.ToLower().Contains(searchTerm.ToLower()) || p.State.ToLower().Contains(searchTerm.ToLower())).ToListAsync();
        }

        public Task<List<string>> GetProjectSearchSuggestions(string searchTerm)
        {
            throw new NotImplementedException();
        }
    }
}
