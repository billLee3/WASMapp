using CRUDBlazorApp.Client.Services.ProjectService;
using CRUDBlazorApp.Server.Services;
using CRUDBlazorApp.Shared;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CRUDBlazorApp.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProjectController : ControllerBase
    {
        private readonly DataContext _context;
        private readonly IProjectServerService _projectServerService;

        public ProjectController(DataContext context, IProjectServerService projectServerService)
        {
            _context = context;
            _projectServerService = projectServerService;
        }


        [HttpGet]
        public async Task<ActionResult<List<Project>>> GetProjects()
        {
            var projects = await _context.Projects.ToListAsync();
            return Ok(projects);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Project>> GetProject(int id)
        {
            var project = await _context.Projects.FirstOrDefaultAsync(p => p.Id == id);
            if (project == null)
            {
                return NotFound("Sorry, there is no project with that ID. ");
            }
            return Ok(project);
        }

        [HttpPost]
        public async Task<ActionResult<List<Project>>> CreateProject(Project project)
        {
            project.CreateDate = DateTime.UtcNow;
            project.CreatedBy = GlobalConfig.user;
            project.AssignedTo = GlobalConfig.user;
            project.LastUpdate = DateTime.UtcNow;
            project.LastUpdatedBy = GlobalConfig.user;

            _context.Projects.Add(project);
            try
            {
                await _context.SaveChangesAsync();
                
            }catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
            

            return Ok(await GetDbProjects());
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<List<Project>>> UpdateProject(Project project, int id)
        {
            var dbProject = await _context.Projects.FirstOrDefaultAsync(p => p.Id == id);
            if (dbProject == null)
            {
                return NotFound("Project not found!");
            }
            else
            {
                dbProject.Name = project.Name;
                dbProject.Type = project.Type;
                dbProject.Status = project.Status;
                dbProject.AddressName = project.AddressName;
                dbProject.City = project.City;
                dbProject.State = project.State;
                dbProject.AssignedTo = GlobalConfig.user;
                dbProject.LastUpdate = DateTime.UtcNow;
                dbProject.LastUpdatedBy = GlobalConfig.user;

                await _context.SaveChangesAsync();
            }

            return Ok(await GetDbProjects());
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<List<Project>>> DeleteProject(int id)
        {
            var dbProject = await _context.Projects.FirstOrDefaultAsync(p => p.Id == id);
            if (dbProject == null)
            {
                return NotFound("Project not found!");
            }
            _context.Projects.Remove(dbProject);
            await _context.SaveChangesAsync();
            return Ok(await GetDbProjects());
        }

        private async Task<List<Project>> GetDbProjects()
        {
            return await _context.Projects.ToListAsync();
        }

        [HttpGet("search/{searchTerm}")]
        public async Task<ActionResult<ServiceResponse<List<Project>>>> SearchProjects(string searchTerm)
        {
            var result = await _projectServerService.SearchProjects(searchTerm);
            return Ok(result);
        }

        [HttpGet("searchsuggestions/{searchTerm}")]
        public async Task<ActionResult<ServiceResponse<List<Project>>>> GetSearchSuggestions(string searchTerm)
        {
            var result = await _projectServerService.GetProjectSearchSuggestions(searchTerm);
            return Ok(result);
        }


    }
}
