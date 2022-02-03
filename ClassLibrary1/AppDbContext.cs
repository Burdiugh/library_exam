using library.data.Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace library.data
{
    internal class AppDbContext : DbContext
    {

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        { 
            if (!optionsBuilder.IsConfigured)
            { 
                  optionsBuilder.UseSqlServer(@"Server=194.44.93.225;Database=Burdiughs_library2;User Id=test;Password=Qwerty-1;MultipleActiveResultSets =True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Sales>().HasOne(s => s.Client).WithMany(c => c.Sales).HasForeignKey(s => s.ClientId);
            modelBuilder.Entity<Sales>().HasOne(s => s.Book).WithMany(b => b.Sales).HasForeignKey(s => s.BookId);
        }
       

        public DbSet<Book> Books { get; set; }
       public DbSet<Client> Clients { get; set; }
        public DbSet<Sales> Sales { get; set; }

    }
}
