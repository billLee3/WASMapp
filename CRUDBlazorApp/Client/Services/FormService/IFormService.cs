using System.Security.Cryptography;

namespace CRUDBlazorApp.Client.Services.FormService
{
    public interface IFormService
    {
        List<Form> Forms { get; set; }
        List<Project> Projects { get; set; }
        Task GetProjects();
        Task GetForms();
        Task<Form> GetSingleForm(int id);

        Task CreateForm(Form form);
        Task UpdateForm(Form form);
        Task DeleteForm(int id);

    }
}
