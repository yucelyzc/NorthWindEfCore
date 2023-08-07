using CodeFirstt.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstt.Data
{
    public class BsContext:DbContext
    {    public BsContext()
        {

        }
        public BsContext(DbContextOptions<BsContext>options):base(options)
        {

        }
        
        public virtual DbSet<Author> Authors { get; set; }
        

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlServer("Server=DESKTOP-HGC3T93\\SQLEXPRESS; Database = library; Integrated Security = True" +
            "TrustServerCertificate=True");
    }
}
