using Demo.Entites;
using Microsoft.EntityFrameworkCore;
using System;

namespace Demo.Infrastructure.Sql
{
    public class DemoContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.;Initial Catalog=School03;integrated security=true");
        }
        public DbSet<Student> Students { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
    }
}
