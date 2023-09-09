using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUDBlazorApp.Shared
{
    public class Project
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Name is required.")]

        public string Name { get; set; } = string.Empty;
        public string Type { get; set;} = string.Empty;
        [Required]
        public string Status { get; set; } = string.Empty;
        [Required]
        public string AddressName { get; set; } = string.Empty;
        [Required]
        public string City { get; set; } = string.Empty;
        [Required]
        public string State { get; set; } = string.Empty;
        public string AssignedTo { get; set; } = string.Empty;
        public DateTime CreateDate { get; set; }
        public string CreatedBy { get; set; } = string.Empty;
        public DateTime LastUpdate { get; set; }
        public string LastUpdatedBy { get; set; } = string.Empty;

    }
}
