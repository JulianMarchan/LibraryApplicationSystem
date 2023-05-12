using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using LibraryApplicationSystem.Authorization.Roles;
using LibraryApplicationSystem.Authorization.Users;
using LibraryApplicationSystem.MultiTenancy;
using LibraryApplicationSystem.Entities;

namespace LibraryApplicationSystem.EntityFrameworkCore
{
    public class LibraryApplicationSystemDbContext : AbpZeroDbContext<Tenant, Role, User, LibraryApplicationSystemDbContext>
    {
        /* Define a DbSet for each entity of the application */
        public DbSet<Department> Departments { get; set; }  
        public DbSet<Student>  Students { get; set; }
        public LibraryApplicationSystemDbContext(DbContextOptions<LibraryApplicationSystemDbContext> options)
            : base(options)
        {
        }
    }
}
