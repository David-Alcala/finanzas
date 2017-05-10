using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace finanzas.Models
{
    public class FinanzasContext:DbContext
    {
        public FinanzasContext(DbContextOptions<FinanzasContext> options)
            : base(options)
        {
        }
        public DbSet<User> Users { get; set; }
    }
}
