using Microsoft.EntityFrameworkCore;
using SaleService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SaleService
{
    public class SalesContext: DbContext
    {       
        public DbSet<User> Users { get; set; }
        public DbSet<Column> Columns { get; set; }
        public DbSet<Article> Articles { get; set; }

        public SalesContext(DbContextOptions<SalesContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {           
            modelBuilder.Entity<User>().ToTable("SYS_USER");
            modelBuilder.Entity<Column>().ToTable("CMS_COLUMN");
            modelBuilder.Entity<Article>().ToTable("CMS_Article");

        }
    }
}
