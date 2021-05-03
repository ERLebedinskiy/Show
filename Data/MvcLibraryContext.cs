using Microsoft.EntityFrameworkCore;
using MvcLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcLibrary.Data
{
    public class MvcLibraryContext : DbContext
    {
        public MvcLibraryContext(DbContextOptions<MvcLibraryContext> options)
            : base(options)
        {
        }

        public DbSet<Book> Book { get; set; }
    }
}

