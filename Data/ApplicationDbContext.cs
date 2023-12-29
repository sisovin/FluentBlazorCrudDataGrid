using FluentBlazorCrudDataGrid.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FluentBlazorCrudDataGrid.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : 
            base(options) 
        {
        }
        public DbSet<Customer> Customers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Customer>().HasData(
                new Customer { Id=1, Name="Test1 Customer", Email="test1@gmail.com"},
                new Customer { Id=2, Name="Test2 Customer", Email="test2@gmail.com"}
            );
            base.OnModelCreating(modelBuilder);
        }
    }
}
