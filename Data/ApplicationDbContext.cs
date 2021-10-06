// using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using CRUD.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CRUD.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        // public DbSet<Category> Category { get; set; }
        public DbSet<ApplicationType> ApplicationType { get; set; }
        // public DbSet<Product> Product { get; set; }
        // public DbSet<ApplicationUser> ApplicationUser { get; set; }
    }
}