using CRUDBlazorApp.Client.Pages;
using CRUDBlazorApp.Shared;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CRUDBlazorApp.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FormController : ControllerBase
    {
        private readonly DataContext _context;
        public FormController(DataContext context)
        {
            _context = context;
        }
        

        [HttpGet]
        public async Task<ActionResult<List<Shared.Project>>> GetForms()
        {
            var forms = await _context.Forms.ToListAsync();
            return Ok(forms);
        }

        [HttpGet("projects")]
        public async Task<ActionResult<List<Project>>> GetProjects()
        {
            var projects = await _context.Projects.ToListAsync();
            return Ok(projects);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Form>> GetForm(int id)
        {
            //var form = await _context.Forms.Include(p => p.project).FirstOrDefaultAsync(f => f.Id == id);
            var form = await _context.Forms.FirstOrDefaultAsync(f => f.Id == id);
            if (form == null)
            {
                return NotFound("Sorry, there is no project with that ID. ");
            }
            return Ok(form);
        }

        [HttpPost]
        public async Task<ActionResult<List<Project>>> CreateForm(Form form)
        {
            //form.project = null;
            _context.Forms.Add(form);
            await _context.SaveChangesAsync();

            return Ok(await GetDbForms());

        }

        [HttpPut("{id}")]
        public async Task<ActionResult<List<Project>>> UpdateForm(Form form, int id)
        {
            //form.project = null;
            //var dbForm = await _context.Forms.Include(f => f.project).FirstOrDefaultAsync(f => f.Id == id);
            var dbForm = await _context.Forms.FirstOrDefaultAsync(f => f.Id == id);
            if (dbForm == null)
            {
                return NotFound();
            }
            else
            {
                //dbForm.DateTimeOfInspection = form.DateTimeOfInspection;
                dbForm.POCName = form.POCName;
                dbForm.POCRelationToProp = form.POCRelationToProp;
                dbForm.POCPhone = form.POCPhone;
                dbForm.PhysicalSetting = form.PhysicalSetting;
                dbForm.Weather = form.Weather;
                dbForm.Zoning = form.Zoning;
                dbForm.SizeSqFt = form.SizeSqFt;
                dbForm.NaturalGas = form.NaturalGas;
                dbForm.Propane = form.Propane;
                dbForm.FuelOil = form.FuelOil;
                dbForm.Electricity = form.Electricity;
                //dbForm.project = form.project;
                dbForm.ProjectID = form.ProjectID;

                await _context.SaveChangesAsync();
            }
            return Ok(await GetDbForms());
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<List<Project>>> DeleteForm(int id)
        {

            //var dbForm = await _context.Forms.Include(f => f.project).FirstOrDefaultAsync(f => f.Id == id);
            var dbForm = await _context.Forms.FirstOrDefaultAsync(f => f.Id == id);
            if (dbForm == null)
            {
                return NotFound("There is no project matching this description");
            }
            _context.Forms.Remove(dbForm);
            await _context.SaveChangesAsync();

            return Ok(await GetDbForms());
        }

        private async Task<List<Form>> GetDbForms()
        {
            // return await _context.Forms.Include(f => f.project).ToListAsync();
            return await _context.Forms.ToListAsync();
        }
    }
}
