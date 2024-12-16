using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SampleCRUDAPPASPNETMVC.Models;

namespace SampleCRUDAPPASPNETMVC.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        // Corrected the DbSet property name to "Employees"
        public DbSet<Employee> Employees { get; set; }
    }
}
