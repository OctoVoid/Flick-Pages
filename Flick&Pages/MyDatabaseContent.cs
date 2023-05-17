using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flick_Pages
{
    class MyDatabaseContent : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source = MyData.db");
        }

        public DbSet<Show> Shows { get; set; }

        public DbSet<Movie> Movies { get; set; }

        public DbSet<Book> Books { get; set; }

    }
}
