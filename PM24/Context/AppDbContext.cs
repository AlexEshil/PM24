using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PM24.Models.Entity;
using PM24.Models.Admin;

namespace PM24.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<User> Users { get; set; }
        public DbSet<TaskD> Tasks { get; set; }
        public DbSet<TaskReport> TaskReports { get; set; }
        public DbSet<ConstructionObject> ConstructionObjects { get; set; }
        public DbSet<ReportFile> ReportFiles { get; set; }

        //Admin
        public DbSet<AdminUser> AdminUsers { get; set; }
        
        //отключаем каскад
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            foreach (var relationship in modelBuilder.Model.GetEntityTypes()
            .SelectMany(e => e.GetForeignKeys()))
            {
                if (relationship.Properties.All(p => p.IsNullable))
                    relationship.DeleteBehavior = DeleteBehavior.SetNull;
                else
                    relationship.DeleteBehavior = DeleteBehavior.Restrict;
            }
        }
    
    }
}