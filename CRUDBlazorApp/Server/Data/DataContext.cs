using Microsoft.EntityFrameworkCore;


namespace CRUDBlazorApp.Server.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) 
        { 

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Project>().HasData(
                    new Project
                    {
                        Id = 1,
                        Name = "Project 1",

                        Status = "Open",
                        AddressName = "1",
                        City = "1",
                        State = "1",
                        AssignedTo = "Test",
                        CreatedBy = "Test",
                        CreateDate = DateTime.UtcNow,
                        LastUpdatedBy = "Test",
                        LastUpdate = DateTime.UtcNow,
                    },
                    new Project
                    {
                        Id = 2,
                        Name = "Project 2",

                        Status = "Open",
                        AddressName = "Columbus Ave",
                        City = "Huntsville",
                        State = "AL",
                        AssignedTo = "Test",
                        CreatedBy = "Test",
                        CreateDate = DateTime.UtcNow,
                        LastUpdatedBy = "Test",
                        LastUpdate = DateTime.UtcNow,
                    },
                    new Project
                    {
                        Id = 3,
                        Name = "Project 3",

                        Status = "Open",
                        AddressName = "Huntsvill Road",
                        City = "Columbus",
                        State = "OH",
                        AssignedTo = "Test",
                        CreatedBy = "Test",
                        CreateDate = DateTime.UtcNow,
                        LastUpdatedBy = "Test",
                        LastUpdate = DateTime.UtcNow,
                    });
            modelBuilder.Entity<Form>().HasData(
                    new Form
                    {
                        Id = 1,
                        //DateTimeOfInspection = DateTime.UtcNow,
                        POCName = "Test",
                        POCRelationToProp = "Test",
                        POCPhone = "123-456-7890",
                        PhysicalSetting = "urban",
                        Weather = "sunny",
                        Zoning = "residential",
                        SizeSqFt = 1000,
                        NaturalGas = "yes",
                        Propane = "yes",
                        FuelOil = "yes",
                        Electricity = "yes",

                        ProjectID = 1

                    }, new Form
                    {
                        Id = 2,
                        //DateTimeOfInspection = DateTime.UtcNow,
                        POCName = "Test",
                        POCRelationToProp = "Test",
                        POCPhone = "123-456-7890",
                        PhysicalSetting = "urban",
                        Weather = "sunny",
                        Zoning = "residential",
                        SizeSqFt = 1000,
                        NaturalGas = "yes",
                        Propane = "yes",
                        FuelOil = "yes",
                        Electricity = "yes",

                        ProjectID = 1

                    }
                );
        }

        public DbSet<Project> Projects { get; set; }
        public DbSet<Form> Forms { get; set; }
        public DbSet<User> Users { get; set; }

    }
}
