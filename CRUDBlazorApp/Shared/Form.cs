using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace CRUDBlazorApp.Shared
{
    public class Form
    {
        public int Id { get; set; }
       
        public string? POCName { get; set; }
        public string? POCRelationToProp { get; set; }
        public string? POCPhone { get; set; }

        //Urban or Suburban
        public string? PhysicalSetting { get; set; }
        public string? Weather { get; set; }
        //Residential Commercial Industrial Agricultural
        public string? Zoning { get; set; }
        public int SizeSqFt { get; set; }
        public string? NaturalGas { get; set; }
        public string? Propane { get; set; }
        public string? FuelOil { get; set; }
        public string? Electricity { get; set; }

        //public Project? project { get; set; }
        public int ProjectID { get; set; }

    }
}
