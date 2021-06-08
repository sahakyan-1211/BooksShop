using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebApplicationUniversity.Models;

namespace WebApplicationUniversity.Data
{
    public class BooksShopContext : DbContext
    {
        public BooksShopContext (DbContextOptions<BooksShopContext> options)
            : base(options)
        {
        }

        public DbSet<WebApplicationUniversity.Models.Book> Book { get; set; }
    }
}
