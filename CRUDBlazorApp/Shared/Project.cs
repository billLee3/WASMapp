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
        [Required(ErrorMessage = "Name is a required field")]
        public string Name { get; set; } = string.Empty;
        public string Type { get; set;} = string.Empty;
        [Required(ErrorMessage = "Status is a required field")]
        public string Status { get; set; } = string.Empty;
        [Required(ErrorMessage = "Address name is a required field")]
        public string AddressName { get; set; } = string.Empty;
        [Required(ErrorMessage = "City is a required field")]
        public string City { get; set; } = string.Empty;
        [Required(ErrorMessage = "State is a required field")]
        public string State { get; set; } = string.Empty;
        public string AssignedTo { get; set; } = string.Empty;
        public DateTime CreateDate { get; set; }
        public string CreatedBy { get; set; } = string.Empty;
        public DateTime LastUpdate { get; set; }
        public string LastUpdatedBy { get; set; } = string.Empty;

    }
}
