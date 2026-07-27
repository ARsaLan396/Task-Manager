using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task_Manager.Application.Interfaces.Context;
using Task_Manager.Domain.Entities;

namespace Task_Manager.Persistence.Context
{
    public class DatabaseContext : DbContext , IDatabaseContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options):base(options)
        {
        }

        public DbSet<TaskItem> Tasks { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            ApplyQueryFiltr(modelBuilder);
        }
        public void ApplyQueryFiltr(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TaskItem>().HasQueryFilter(p => !p.IsRemoved);
        }
    }
}
