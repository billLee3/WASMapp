namespace CRUDBlazorApp.Server.Services
{
    public class ProjectServerService : IProjectServerService
    {
        private readonly DataContext _context;

        public ProjectServerService(DataContext context)
        {
            _context = context;
        }
        
        
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

        public async Task<ServiceResponse<List<string>>> GetProjectSearchSuggestions(string searchTerm)
        {
            var projects = await FindProjectsBySearch(searchTerm);
            List<string> result = new List<string>();

            foreach(var project in projects)
            {
                if(project.Name.Contains(searchTerm, StringComparison.OrdinalIgnoreCase))
                {
                    result.Add(project.Name);
                }
                if(project.City.Contains(searchTerm, StringComparison.OrdinalIgnoreCase))
                {
                    result.Add(project.City);
                }
            }
            return new ServiceResponse<List<string>> { Data = result };
        }

        
    }
}
